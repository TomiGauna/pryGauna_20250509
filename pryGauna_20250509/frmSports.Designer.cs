namespace pryGauna_20250509
{
    partial class frmSports
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
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblSkillfulness = new System.Windows.Forms.Label();
            this.nudSkillfulness = new System.Windows.Forms.NumericUpDown();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.btnRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkillfulness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSports
            // 
            this.cboSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.pboImage.Size = new System.Drawing.Size(741, 420);
            this.pboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImage.TabIndex = 2;
            this.pboImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(350, 9);
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
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(508, 39);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(35, 13);
            this.lblStrength.TabIndex = 5;
            this.lblStrength.Text = "label1";
            // 
            // lblSkillfulness
            // 
            this.lblSkillfulness.AutoSize = true;
            this.lblSkillfulness.Location = new System.Drawing.Point(508, 95);
            this.lblSkillfulness.Name = "lblSkillfulness";
            this.lblSkillfulness.Size = new System.Drawing.Size(35, 13);
            this.lblSkillfulness.TabIndex = 6;
            this.lblSkillfulness.Text = "label2";
            // 
            // nudSkillfulness
            // 
            this.nudSkillfulness.Location = new System.Drawing.Point(511, 111);
            this.nudSkillfulness.Name = "nudSkillfulness";
            this.nudSkillfulness.Size = new System.Drawing.Size(242, 20);
            this.nudSkillfulness.TabIndex = 7;
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(511, 56);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(242, 20);
            this.nudStrength.TabIndex = 8;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(677, 147);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "button1";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // frmSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 625);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.nudStrength);
            this.Controls.Add(this.nudSkillfulness);
            this.Controls.Add(this.lblSkillfulness);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pboImage);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.cboSports);
            this.Name = "frmSports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkillfulness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSports;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox pboImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblSkillfulness;
        private System.Windows.Forms.NumericUpDown nudSkillfulness;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.Button btnRecord;
    }
}

