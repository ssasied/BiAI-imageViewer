namespace ColorPickerResults
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SourceImage = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color4 = new System.Windows.Forms.PictureBox();
            this.color5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color5)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImage
            // 
            this.SourceImage.AccessibleName = "SourceImage";
            this.SourceImage.Image = ((System.Drawing.Image)(resources.GetObject("SourceImage.Image")));
            this.SourceImage.Location = new System.Drawing.Point(12, 109);
            this.SourceImage.Name = "SourceImage";
            this.SourceImage.Size = new System.Drawing.Size(388, 240);
            this.SourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceImage.TabIndex = 0;
            this.SourceImage.TabStop = false;
            this.SourceImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // previousButton
            // 
            this.previousButton.AccessibleName = "previousButton";
            this.previousButton.Location = new System.Drawing.Point(13, 30);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            this.previousButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.previousButton_KeyDown);
            // 
            // nextButton
            // 
            this.nextButton.AccessibleName = "nextButton";
            this.nextButton.Location = new System.Drawing.Point(137, 29);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextButton_KeyDown);
            // 
            // color1
            // 
            this.color1.AccessibleName = "color1";
            this.color1.Location = new System.Drawing.Point(445, 205);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(40, 40);
            this.color1.TabIndex = 13;
            this.color1.TabStop = false;
            this.color1.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // color2
            // 
            this.color2.AccessibleName = "color2";
            this.color2.Location = new System.Drawing.Point(491, 205);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(40, 40);
            this.color2.TabIndex = 14;
            this.color2.TabStop = false;
            // 
            // color3
            // 
            this.color3.AccessibleName = "color3";
            this.color3.Location = new System.Drawing.Point(537, 205);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(40, 40);
            this.color3.TabIndex = 15;
            this.color3.TabStop = false;
            // 
            // color4
            // 
            this.color4.AccessibleName = "color4";
            this.color4.Location = new System.Drawing.Point(583, 205);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(40, 40);
            this.color4.TabIndex = 16;
            this.color4.TabStop = false;
            // 
            // color5
            // 
            this.color5.AccessibleName = "color5";
            this.color5.Location = new System.Drawing.Point(629, 205);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(40, 40);
            this.color5.TabIndex = 17;
            this.color5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(445, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(491, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(537, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(583, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(629, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color5);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.SourceImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.PictureBox color4;
        private System.Windows.Forms.PictureBox color5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox SourceImage;
        private System.Windows.Forms.Button previousButton;
    }
}

