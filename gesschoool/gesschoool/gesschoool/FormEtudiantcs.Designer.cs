namespace gesschoool
{
    partial class FormEtudiantcs
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.dtaetudiant = new System.Windows.Forms.DataGridView();
            this.btnvalide = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.txtanneescolaire = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaetudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(660, 553);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 40);
            this.btnclear.TabIndex = 41;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(454, 553);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 40);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmodifier.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(223, 553);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(127, 40);
            this.btnmodifier.TabIndex = 39;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // dtaetudiant
            // 
            this.dtaetudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaetudiant.Location = new System.Drawing.Point(440, 130);
            this.dtaetudiant.Name = "dtaetudiant";
            this.dtaetudiant.RowHeadersWidth = 62;
            this.dtaetudiant.RowTemplate.Height = 28;
            this.dtaetudiant.Size = new System.Drawing.Size(550, 410);
            this.dtaetudiant.TabIndex = 38;
            // 
            // btnvalide
            // 
            this.btnvalide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnvalide.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalide.ForeColor = System.Drawing.Color.Black;
            this.btnvalide.Location = new System.Drawing.Point(12, 555);
            this.btnvalide.Name = "btnvalide";
            this.btnvalide.Size = new System.Drawing.Size(134, 40);
            this.btnvalide.TabIndex = 37;
            this.btnvalide.Text = "Valider";
            this.btnvalide.UseVisualStyleBackColor = false;
            this.btnvalide.Click += new System.EventHandler(this.btnvalide_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(152, 235);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(189, 40);
            this.txtnom.TabIndex = 36;
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(152, 300);
            this.txtcredit.Multiline = true;
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(189, 38);
            this.txtcredit.TabIndex = 35;
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(152, 360);
            this.txtreglement.Multiline = true;
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(189, 41);
            this.txtreglement.TabIndex = 34;
            // 
            // txtanneescolaire
            // 
            this.txtanneescolaire.Location = new System.Drawing.Point(152, 426);
            this.txtanneescolaire.Multiline = true;
            this.txtanneescolaire.Name = "txtanneescolaire";
            this.txtanneescolaire.Size = new System.Drawing.Size(189, 43);
            this.txtanneescolaire.TabIndex = 33;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(152, 166);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(189, 41);
            this.txtprenom.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Anneescolaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Reglement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(40, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "classe";
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(152, 498);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(189, 28);
            this.cmbclasse.TabIndex = 43;
            this.cmbclasse.SelectedIndexChanged += new System.EventHandler(this.cmbclasse_SelectedIndexChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.IndianRed;
            this.txtRecherche.Location = new System.Drawing.Point(643, 71);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(176, 40);
            this.txtRecherche.TabIndex = 44;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(521, 58);
            this.label7.TabIndex = 46;
            this.label7.Text = "Informations_Etudiant";
            // 
            // FormEtudiantcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 619);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.dtaetudiant);
            this.Controls.Add(this.btnvalide);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.txtreglement);
            this.Controls.Add(this.txtanneescolaire);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEtudiantcs";
            this.Text = "FormEtudiantcs";
            ((System.ComponentModel.ISupportInitialize)(this.dtaetudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.DataGridView dtaetudiant;
        private System.Windows.Forms.Button btnvalide;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.TextBox txtanneescolaire;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label7;
    }
}