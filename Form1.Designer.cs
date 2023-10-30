namespace UP_L2_Skaner
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
            scanButton = new Button();
            saveImage = new Button();
            scanPreview = new PictureBox();
            formatsList = new ListBox();
            label1 = new Label();
            rotateLeft = new Button();
            rotateRightButton = new Button();
            label2 = new Label();
            brightnessValue = new NumericUpDown();
            contrastValue = new NumericUpDown();
            Constrast = new Label();
            filenameInput = new TextBox();
            saveSettingsButton = new Button();
            label3 = new Label();
            label4 = new Label();
            heightValue = new NumericUpDown();
            widthValue = new NumericUpDown();
            label5 = new Label();
            colorBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)scanPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brightnessValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrastValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthValue).BeginInit();
            SuspendLayout();
            // 
            // scanButton
            // 
            scanButton.Location = new Point(12, 12);
            scanButton.Name = "scanButton";
            scanButton.Size = new Size(166, 40);
            scanButton.TabIndex = 0;
            scanButton.Text = "Skanuj podgląd";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += scanButton_Click;
            // 
            // saveImage
            // 
            saveImage.Location = new Point(10, 192);
            saveImage.Name = "saveImage";
            saveImage.Size = new Size(121, 23);
            saveImage.TabIndex = 2;
            saveImage.Text = "Skanuj i zapisz jako";
            saveImage.UseVisualStyleBackColor = true;
            saveImage.Click += saveImage_Click;
            // 
            // scanPreview
            // 
            scanPreview.Location = new Point(248, 12);
            scanPreview.Name = "scanPreview";
            scanPreview.Size = new Size(530, 616);
            scanPreview.TabIndex = 3;
            scanPreview.TabStop = false;
            scanPreview.Click += scanPreview_Click_1;
            // 
            // formatsList
            // 
            formatsList.FormattingEnabled = true;
            formatsList.ItemHeight = 15;
            formatsList.Items.AddRange(new object[] { "png", "jpg", "bmp", "tiff", "rle" });
            formatsList.Location = new Point(11, 92);
            formatsList.Name = "formatsList";
            formatsList.Size = new Size(120, 94);
            formatsList.TabIndex = 4;
            formatsList.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 74);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Wybierz format";
            // 
            // rotateLeft
            // 
            rotateLeft.Location = new Point(248, 634);
            rotateLeft.Name = "rotateLeft";
            rotateLeft.Size = new Size(154, 23);
            rotateLeft.TabIndex = 6;
            rotateLeft.Text = "Obróć w lewo o 90 stopni";
            rotateLeft.UseVisualStyleBackColor = true;
            rotateLeft.Click += rotateLeft_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Location = new Point(616, 634);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(162, 23);
            rotateRightButton.TabIndex = 7;
            rotateRightButton.Text = "Obróć w prawo o 90 stopni";
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 285);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Brightness";
            label2.Click += label2_Click;
            // 
            // brightnessValue
            // 
            brightnessValue.Location = new Point(12, 303);
            brightnessValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            brightnessValue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            brightnessValue.Name = "brightnessValue";
            brightnessValue.Size = new Size(120, 23);
            brightnessValue.TabIndex = 11;
            // 
            // contrastValue
            // 
            contrastValue.Location = new Point(12, 347);
            contrastValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            contrastValue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            contrastValue.Name = "contrastValue";
            contrastValue.Size = new Size(120, 23);
            contrastValue.TabIndex = 12;
            // 
            // Constrast
            // 
            Constrast.AutoSize = true;
            Constrast.Location = new Point(13, 329);
            Constrast.Name = "Constrast";
            Constrast.Size = new Size(52, 15);
            Constrast.TabIndex = 13;
            Constrast.Text = "Contrast";
            // 
            // filenameInput
            // 
            filenameInput.Location = new Point(137, 193);
            filenameInput.Name = "filenameInput";
            filenameInput.Size = new Size(100, 23);
            filenameInput.TabIndex = 14;
            filenameInput.Text = "scan-name";
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.Location = new Point(12, 496);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(120, 36);
            saveSettingsButton.TabIndex = 15;
            saveSettingsButton.Text = "Zapisz ustawienia";
            saveSettingsButton.UseVisualStyleBackColor = true;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 391);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 16;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 442);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Width";
            // 
            // heightValue
            // 
            heightValue.Location = new Point(12, 409);
            heightValue.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightValue.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(120, 23);
            heightValue.TabIndex = 18;
            heightValue.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // widthValue
            // 
            widthValue.Location = new Point(13, 460);
            widthValue.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            widthValue.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            widthValue.Name = "widthValue";
            widthValue.Size = new Size(120, 23);
            widthValue.TabIndex = 19;
            widthValue.Value = new decimal(new int[] { 300, 0, 0, 0 });
            widthValue.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 227);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 20;
            label5.Text = "USTAWIENIA";
            // 
            // colorBox
            // 
            colorBox.FormattingEnabled = true;
            colorBox.Items.AddRange(new object[] { "Kolorowy", "Szary" });
            colorBox.Location = new Point(13, 255);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(121, 23);
            colorBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 683);
            Controls.Add(colorBox);
            Controls.Add(label5);
            Controls.Add(widthValue);
            Controls.Add(heightValue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(saveSettingsButton);
            Controls.Add(filenameInput);
            Controls.Add(Constrast);
            Controls.Add(contrastValue);
            Controls.Add(brightnessValue);
            Controls.Add(label2);
            Controls.Add(rotateRightButton);
            Controls.Add(rotateLeft);
            Controls.Add(label1);
            Controls.Add(formatsList);
            Controls.Add(scanPreview);
            Controls.Add(saveImage);
            Controls.Add(scanButton);
            Name = "Form1";
            Text = "Skaner";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)scanPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)brightnessValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrastValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scanButton;
        private Button saveImage;
        private PictureBox scanPreview;
        private ComboBox formatsBox;
        private ListBox formatsList;
        private Label label1;
        private Button rotateLeft;
        private Button rotateRightButton;
        private Label label2;
        private NumericUpDown brightnessValue;
        private NumericUpDown contrastValue;
        private Label Constrast;
        private TextBox filenameInput;
        private Button saveSettingsButton;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown heightValue;
        private NumericUpDown widthValue;
        private Label label5;
        private ComboBox colorBox;
    }
}