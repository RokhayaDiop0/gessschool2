namespace gesschoool
{
    partial class FormClasse
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtaclasse = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.NIVEAU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.cmbspecialite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaclasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "AJOUT CLASSE";
            // 
            // dtaclasse
            // 
            this.dtaclasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaclasse.Location = new System.Drawing.Point(123, 227);
            this.dtaclasse.Name = "dtaclasse";
            this.dtaclasse.RowHeadersWidth = 62;
            this.dtaclasse.RowTemplate.Height = 28;
            this.dtaclasse.Size = new System.Drawing.Size(555, 216);
            this.dtaclasse.TabIndex = 20;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsave.Location = new System.Drawing.Point(277, 164);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(166, 38);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // NIVEAU
            // 
            this.NIVEAU.AutoSize = true;
            this.NIVEAU.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIVEAU.Location = new System.Drawing.Point(148, 121);
            this.NIVEAU.Name = "NIVEAU";
            this.NIVEAU.Size = new System.Drawing.Size(102, 28);
            this.NIVEAU.TabIndex = 18;
            this.NIVEAU.Text = "NIVEAU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "SPECIALITE";
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.cmbniveau.Location = new System.Drawing.Point(277, 121);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(166, 28);
            this.cmbniveau.TabIndex = 16;
            // 
            // cmbspecialite
            // 
            this.cmbspecialite.FormattingEnabled = true;
            this.cmbspecialite.Items.AddRange(new object[] {
            "IAGE",
            "GL",
            "RESEAU",
            "FC"});
            this.cmbspecialite.Location = new System.Drawing.Point(276, 68);
            this.cmbspecialite.Name = "cmbspecialite";
            this.cmbspecialite.Size = new System.Drawing.Size(166, 28);
            this.cmbspecialite.TabIndex = 15;
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtaclasse);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.NIVEAU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.cmbspecialite);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            ((System.ComponentModel.ISupportInitialize)(this.dtaclasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtaclasse;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label NIVEAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.ComboBox cmbspecialite;
    }
}