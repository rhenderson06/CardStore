namespace HOT4
{
    partial class frmCardStoreHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardStoreHome));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnCustomizeCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(505, 279);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // btnCustomizeCard
            // 
            this.btnCustomizeCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCustomizeCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeCard.Location = new System.Drawing.Point(161, 372);
            this.btnCustomizeCard.Name = "btnCustomizeCard";
            this.btnCustomizeCard.Size = new System.Drawing.Size(206, 40);
            this.btnCustomizeCard.TabIndex = 0;
            this.btnCustomizeCard.Text = "Customize Card";
            this.btnCustomizeCard.UseVisualStyleBackColor = true;
            this.btnCustomizeCard.Click += new System.EventHandler(this.btnCustomizeCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(161, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(206, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCardStoreHome
            // 
            this.AcceptButton = this.btnCustomizeCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(529, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomizeCard);
            this.Controls.Add(this.imgLogo);
            this.Name = "frmCardStoreHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic Cards | Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnCustomizeCard;
        private System.Windows.Forms.Button btnExit;
    }
}

