namespace gesschoool
{
    partial class FormUtilisateurs
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.dtaUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(17, 370);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(187, 30);
            this.txtpassword.TabIndex = 22;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(12, 244);
            this.txtlogin.Multiline = true;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(192, 30);
            this.txtlogin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Username";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(12, 477);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(150, 50);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtaUser
            // 
            this.dtaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaUser.Location = new System.Drawing.Point(322, 152);
            this.dtaUser.Name = "dtaUser";
            this.dtaUser.RowHeadersWidth = 62;
            this.dtaUser.RowTemplate.Height = 28;
            this.dtaUser.Size = new System.Drawing.Size(482, 282);
            this.dtaUser.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "AJOUT_USER";
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnannuler.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(446, 477);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(197, 50);
            this.btnannuler.TabIndex = 26;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(210, 477);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(176, 50);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FormUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 548);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaUser);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormUtilisateurs";
            this.Text = "FormUtilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtaUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dtaUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btndelete;
    }
}