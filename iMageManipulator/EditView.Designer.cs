namespace ImageManipulatorView
{
    partial class EditView
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
            this.FlipBtn = new System.Windows.Forms.Button();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FlipBtn
            // 
            this.FlipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipBtn.Location = new System.Drawing.Point(12, 785);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(78, 75);
            this.FlipBtn.TabIndex = 1;
            this.FlipBtn.Text = "🔄";
            this.FlipBtn.UseVisualStyleBackColor = true;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // RotateBtn
            // 
            this.RotateBtn.Location = new System.Drawing.Point(96, 785);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(78, 75);
            this.RotateBtn.TabIndex = 2;
            this.RotateBtn.Text = "Rotate!!!";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Location = new System.Drawing.Point(268, 785);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(333, 75);
            this.SaveImageBtn.TabIndex = 3;
            this.SaveImageBtn.Text = "Save Your Masterpiece!!!";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(846, 756);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 872);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.FlipBtn);
            this.Name = "EditView";
            this.Text = "EditView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FlipBtn;
        private System.Windows.Forms.Button RotateBtn;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}