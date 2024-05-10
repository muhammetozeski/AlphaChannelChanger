namespace AlphaChannelChanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Log = new RichTextBox();
            pictureBoxMain = new PictureBox();
            pictureBoxAlpha = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBoxResult = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            MergeButton = new Button();
            SaveButton = new Button();
            ImageFormatComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            UseWhitenessCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            SuspendLayout();
            // 
            // Log
            // 
            Log.BackColor = SystemColors.Window;
            Log.Location = new Point(12, 473);
            Log.Multiline = false;
            Log.Name = "Log";
            Log.ReadOnly = true;
            Log.Size = new Size(776, 33);
            Log.TabIndex = 0;
            Log.Text = "";
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMain.Location = new Point(12, 50);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(264, 173);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain.TabIndex = 1;
            pictureBoxMain.TabStop = false;
            // 
            // pictureBoxAlpha
            // 
            pictureBoxAlpha.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAlpha.Location = new Point(289, 50);
            pictureBoxAlpha.Name = "pictureBoxAlpha";
            pictureBoxAlpha.Size = new Size(382, 173);
            pictureBoxAlpha.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlpha.TabIndex = 2;
            pictureBoxAlpha.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 3;
            label1.Text = "Drag and drop the main picture here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 18);
            label2.Name = "label2";
            label2.Size = new Size(382, 20);
            label2.TabIndex = 4;
            label2.Text = "Drag and drop the picture which has alpha channel here:";
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxResult.Location = new Point(12, 260);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(382, 173);
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.TabIndex = 5;
            pictureBoxResult.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 450);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Logs:";
            // 
            // MergeButton
            // 
            MergeButton.Location = new Point(677, 50);
            MergeButton.Name = "MergeButton";
            MergeButton.Size = new Size(94, 75);
            MergeButton.TabIndex = 8;
            MergeButton.Text = "Merge alpha channel";
            MergeButton.UseVisualStyleBackColor = true;
            MergeButton.Click += MergeButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(400, 404);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(143, 29);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save result image";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ImageFormatComboBox
            // 
            ImageFormatComboBox.FormattingEnabled = true;
            ImageFormatComboBox.Location = new Point(400, 285);
            ImageFormatComboBox.Name = "ImageFormatComboBox";
            ImageFormatComboBox.Size = new Size(151, 28);
            ImageFormatComboBox.TabIndex = 10;
            ImageFormatComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 260);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Save format:\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(400, 316);
            label7.Name = "label7";
            label7.Size = new Size(348, 40);
            label7.TabIndex = 12;
            label7.Text = "png format supports alpha channel but if you want \r\nyou can save the image in different formats";
            // 
            // UseWhitenessCheckBox
            // 
            UseWhitenessCheckBox.AutoSize = true;
            UseWhitenessCheckBox.Location = new Point(677, 140);
            UseWhitenessCheckBox.Name = "UseWhitenessCheckBox";
            UseWhitenessCheckBox.Size = new Size(95, 104);
            UseWhitenessCheckBox.TabIndex = 13;
            UseWhitenessCheckBox.Text = "no alpha\r\nchannel.\r\nJust use\r\nwhiteness\r\nvalue";
            UseWhitenessCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 513);
            Controls.Add(UseWhitenessCheckBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ImageFormatComboBox);
            Controls.Add(SaveButton);
            Controls.Add(MergeButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBoxResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxAlpha);
            Controls.Add(pictureBoxMain);
            Controls.Add(Log);
            Name = "Form1";
            ShowIcon = false;
            Text = "Alpha Channel Changer";
            Load += Start;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Log;
        private PictureBox pictureBoxMain;
        private PictureBox pictureBoxAlpha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBoxResult;
        private Label label3;
        private Label label4;
        private Button MergeButton;
        private Button SaveButton;
        private ComboBox ImageFormatComboBox;
        private Label label6;
        private Label label7;
        private CheckBox UseWhitenessCheckBox;
    }
}
