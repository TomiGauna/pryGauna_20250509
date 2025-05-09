namespace pryGauna_20250509
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboSports = new System.Windows.Forms.ComboBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pboImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSports
            // 
            this.cboSports.FormattingEnabled = true;
            this.cboSports.Location = new System.Drawing.Point(12, 111);
            this.cboSports.Name = "cboSports";
            this.cboSports.Size = new System.Drawing.Size(416, 21);
            this.cboSports.TabIndex = 0;
            this.cboSports.SelectedIndexChanged += new System.EventHandler(this.cboSports_SelectedIndexChanged);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(12, 83);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(35, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "label1";
            // 
            // pboImage
            // 
            this.pboImage.Location = new System.Drawing.Point(12, 190);
            this.pboImage.Name = "pboImage";
            this.pboImage.Size = new System.Drawing.Size(741, 503);
            this.pboImage.TabIndex = 2;
            this.pboImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(345, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label2";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(353, 147);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "button1";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 705);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pboImage);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.cboSports);
            this.Name = "Form1";
            this.Text = "Sports Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSports;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox pboImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShow;
    }
}

