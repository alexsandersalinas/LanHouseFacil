namespace LanHouseFacil
{
    partial class frmSetup
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
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.mskTempo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(99, 70);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(75, 23);
            this.btnINCLUIR.TabIndex = 1;
            this.btnINCLUIR.Text = "INCLUIR";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // mskTempo
            // 
            this.mskTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempo.Location = new System.Drawing.Point(66, 25);
            this.mskTempo.Mask = "#:##";
            this.mskTempo.Name = "mskTempo";
            this.mskTempo.Size = new System.Drawing.Size(140, 29);
            this.mskTempo.TabIndex = 0;
            this.mskTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 105);
            this.Controls.Add(this.mskTempo);
            this.Controls.Add(this.btnINCLUIR);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.MaskedTextBox mskTempo;
    }
}