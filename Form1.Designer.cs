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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)scanPreview).BeginInit();
            SuspendLayout();
            // 
            // scanButton
            // 
            scanButton.Location = new Point(12, 12);
            scanButton.Name = "scanButton";
            scanButton.Size = new Size(75, 23);
            scanButton.TabIndex = 0;
            scanButton.Text = "Skanuj";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += scanButton_Click;
            // 
            // saveImage
            // 
            saveImage.Location = new Point(12, 201);
            saveImage.Name = "saveImage";
            saveImage.Size = new Size(75, 23);
            saveImage.TabIndex = 2;
            saveImage.Text = "Zapisz jako";
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
            // 
            // formatsList
            // 
            formatsList.FormattingEnabled = true;
            formatsList.ItemHeight = 15;
            formatsList.Items.AddRange(new object[] { "png", "jpg", "bmp", "tiff", "rle" });
            formatsList.Location = new Point(12, 101);
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
            rotateLeft.Location = new Point(269, 648);
            rotateLeft.Name = "rotateLeft";
            rotateLeft.Size = new Size(154, 23);
            rotateLeft.TabIndex = 6;
            rotateLeft.Text = "Obróć w lewo o 90 stopni";
            rotateLeft.UseVisualStyleBackColor = true;
            rotateLeft.Click += rotateLeft_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Location = new Point(456, 648);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(162, 23);
            rotateRightButton.TabIndex = 7;
            rotateRightButton.Text = "Obróć w prawo o 90 stopni";
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 442);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 683);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(rotateRightButton);
            Controls.Add(rotateLeft);
            Controls.Add(label1);
            Controls.Add(formatsList);
            Controls.Add(scanPreview);
            Controls.Add(saveImage);
            Controls.Add(scanButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)scanPreview).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
    }
}