using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AlphaChannelChanger
{
    public partial class Form1 : Form
    {
        Bitmap mainPic, alpha, result;
        ImageFormat DefaultImageFormat = ImageFormat.Bmp;

        public Form1()
        {
            InitializeComponent();

            pictureBoxMain.AllowDrop = true;
            pictureBoxMain.DragEnter += new DragEventHandler(All_DragEnter);
            pictureBoxMain.DragDrop += new DragEventHandler(pictureBoxMain_DragDrop);

            pictureBoxAlpha.AllowDrop = true;
            pictureBoxAlpha.DragEnter += new DragEventHandler(All_DragEnter);
            pictureBoxAlpha.DragDrop += new DragEventHandler(pictureBoxAlpha_DragDrop);

            ImageFormatComboBox.Items.Add(ImageFormat.Bmp);
            ImageFormatComboBox.Items.Add(ImageFormat.Emf);
            ImageFormatComboBox.Items.Add(ImageFormat.Exif);
            ImageFormatComboBox.Items.Add(ImageFormat.Gif);
            ImageFormatComboBox.Items.Add(ImageFormat.Icon);
            ImageFormatComboBox.Items.Add(ImageFormat.Jpeg);
            ImageFormatComboBox.Items.Add(ImageFormat.MemoryBmp);
            ImageFormatComboBox.Items.Add(ImageFormat.Png);
            ImageFormatComboBox.Items.Add(ImageFormat.Tiff);
            ImageFormatComboBox.Items.Add(ImageFormat.Wmf);
            ImageFormatComboBox.SelectedItem = DefaultImageFormat;
        }

        /// <summary>
        /// start is called 1 time on form1 loaded
        /// </summary>
        private void Start(object sender, EventArgs e)
        {

        }

        //fast debug printer
        public void p(object message)
        {
            Log.Text = message.ToString() + " - " + Log.Text;
        }

        void All_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void pictureBoxMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                p("main picture: " + files[0]);
                mainPic = new Bitmap(files[0]);
                pictureBoxMain.Image = mainPic;
            }
            catch (Exception ex)
            {
                p("error time: " + DateTime.Now + " error: " + ex.Message);
            }
        }
        private void pictureBoxAlpha_DragDrop(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                p("alpha picture: " + files[0]);
                alpha = new Bitmap(files[0]);
                pictureBoxAlpha.Image = alpha;
            }
            catch (Exception ex)
            {
                p("error time: " + DateTime.Now + " error: " + ex.Message);
            }
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            if (mainPic.Width != alpha.Width || mainPic.Height != alpha.Height)
            {
                p("error! main picture and alpha picture width and height must be same. the process canceled " + DateTime.Now);
                return;
            }
            try
            {
                p("merge started at " + DateTime.Now);
                result = new Bitmap(mainPic.Width, mainPic.Height);

                // change alpha channel of every pixel
                for (int x = 0; x < mainPic.Width; x++)
                {
                    for (int y = 0; y < mainPic.Height; y++)
                    {
                        Color color1 = mainPic.GetPixel(x, y);
                        Color color2 = alpha.GetPixel(x, y);

                        if (!UseWhitenessCheckBox.Checked)
                        {
                            Color newColor = Color.FromArgb(color2.A, color1.R, color1.G, color1.B);
                            result.SetPixel(x, y, newColor);
                        }
                        else
                        {
                            byte A = (byte)((color2.R + color2.G + color2.B) / 3);
                            Color newColor = Color.FromArgb(A, color1.R, color1.G, color1.B);
                            result.SetPixel(x, y, newColor);
                        }
                    }
                }
                pictureBoxResult.Image = result;
                p("merge finished successfully at " + DateTime.Now);
            }
            catch (Exception ex)
            {
                p("error time: " + DateTime.Now + " error: " + ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            p("Save button clicked at " + DateTime.Now);
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Image|*." + DefaultImageFormat;
                saveDialog.Title = "Save an Image File";
                var res = saveDialog.ShowDialog();
                if (res != DialogResult.OK)
                {
                    p("save dialog result is not OK");
                    return;
                }
                string path = saveDialog.FileName;
                if (string.IsNullOrWhiteSpace(path) && !IsValidPath(path))
                {
                    p("Save file dialog window returned an incorrect path text. File will be saved to the current folder of this program");
                    path = "";
                }
                result.Save(path, DefaultImageFormat);
                p("image successfully saved to " + path + " at " + DateTime.Now);
            }
            catch (Exception ex)
            {
                p("error time: " + DateTime.Now + " error: " + ex.Message);
            }
        }

        static bool IsValidPath(string path)
        {
            try
            {
                string fullPath = Path.GetFullPath(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DefaultImageFormat = ImageFormatComboBox.SelectedItem as ImageFormat;
                p("image formate changed to " + DefaultImageFormat);
            }
            catch (Exception ex)
            {
                p("error time: " + DateTime.Now + " error: " + ex.Message);
            }
        }
    }
}
