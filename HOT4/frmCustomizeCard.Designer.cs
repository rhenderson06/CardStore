namespace HOT4
{
    partial class frmCustomizeCard
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
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cmbOccasion = new System.Windows.Forms.ComboBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.chkEnvelope = new System.Windows.Forms.CheckBox();
            this.chkStamp = new System.Windows.Forms.CheckBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOccasion
            // 
            this.lblOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(24, 26);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(120, 30);
            this.lblOccasion.TabIndex = 8;
            this.lblOccasion.Text = "Occasion:";
            // 
            // lblStyle
            // 
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(24, 83);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(120, 30);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style:";
            // 
            // cmbOccasion
            // 
            this.cmbOccasion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOccasion.FormattingEnabled = true;
            this.cmbOccasion.Location = new System.Drawing.Point(150, 23);
            this.cmbOccasion.Name = "cmbOccasion";
            this.cmbOccasion.Size = new System.Drawing.Size(166, 28);
            this.cmbOccasion.TabIndex = 0;
            this.cmbOccasion.SelectedIndexChanged += new System.EventHandler(this.cmbOccasion_SelectedIndexChanged);
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(150, 80);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(166, 28);
            this.cmbStyle.TabIndex = 1;
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // chkEnvelope
            // 
            this.chkEnvelope.AutoSize = true;
            this.chkEnvelope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnvelope.Location = new System.Drawing.Point(29, 154);
            this.chkEnvelope.Name = "chkEnvelope";
            this.chkEnvelope.Size = new System.Drawing.Size(148, 24);
            this.chkEnvelope.TabIndex = 2;
            this.chkEnvelope.Text = "Envelope ($0.25)";
            this.chkEnvelope.UseVisualStyleBackColor = true;
            // 
            // chkStamp
            // 
            this.chkStamp.AutoSize = true;
            this.chkStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStamp.Location = new System.Drawing.Point(29, 189);
            this.chkStamp.Name = "chkStamp";
            this.chkStamp.Size = new System.Drawing.Size(129, 24);
            this.chkStamp.TabIndex = 3;
            this.chkStamp.Text = "Stamp ($0.50)";
            this.chkStamp.UseVisualStyleBackColor = true;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMessage.Location = new System.Drawing.Point(29, 224);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(206, 24);
            this.chkMessage.TabIndex = 4;
            this.chkMessage.Text = "Custom Message ($0.30)";
            this.chkMessage.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(29, 259);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(256, 180);
            this.txtMessage.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(24, 478);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(145, 30);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost:";
            // 
            // picCard
            // 
            this.picCard.Location = new System.Drawing.Point(344, 12);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(515, 430);
            this.picCard.TabIndex = 10;
            this.picCard.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(650, 472);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(206, 40);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(344, 472);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(206, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(498, 307);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(216, 132);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCustomizeCard
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(883, 541);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.chkMessage);
            this.Controls.Add(this.chkStamp);
            this.Controls.Add(this.chkEnvelope);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.cmbOccasion);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Name = "frmCustomizeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic Cards | Customize Card";
            this.Load += new System.EventHandler(this.frmCustomizeCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cmbOccasion;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.CheckBox chkEnvelope;
        private System.Windows.Forms.CheckBox chkStamp;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMessage;
    }
}