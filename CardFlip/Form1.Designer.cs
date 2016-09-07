namespace CardFlip
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
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::CardFlip.Properties.Resources.Ace_Spades;
            this.cardFacePictureBox.Location = new System.Drawing.Point(160, 12);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(112, 157);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 0;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            this.cardFacePictureBox.Click += new System.EventHandler(this.cardFacePictureBox_Click);
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::CardFlip.Properties.Resources.Backface_Blue;
            this.cardBackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(111, 157);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPictureBox.TabIndex = 1;
            this.cardBackPictureBox.TabStop = false;
            this.cardBackPictureBox.Click += new System.EventHandler(this.cardBackPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cardBackPictureBox);
            this.Controls.Add(this.cardFacePictureBox);
            this.Name = "Form1";
            this.Text = "Card Flip Demo";
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
    }
}

