namespace ImageManipulatorView
{
    partial class GalleryView
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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.LoadImagesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Location = new System.Drawing.Point(12, 12);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(926, 694);
            this.ImagePanel.TabIndex = 0;
            // 
            // LoadImagesBtn
            // 
            this.LoadImagesBtn.Location = new System.Drawing.Point(337, 712);
            this.LoadImagesBtn.Name = "LoadImagesBtn";
            this.LoadImagesBtn.Size = new System.Drawing.Size(250, 63);
            this.LoadImagesBtn.TabIndex = 1;
            this.LoadImagesBtn.Text = "Load Images!!!";
            this.LoadImagesBtn.UseVisualStyleBackColor = true;
            this.LoadImagesBtn.Click += new System.EventHandler(this.LoadImagesBtn_Click);
            // 
            // GalleryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 787);
            this.Controls.Add(this.LoadImagesBtn);
            this.Controls.Add(this.ImagePanel);
            this.Name = "GalleryView";
            this.Text = "GalleryView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Button LoadImagesBtn;
    }
}