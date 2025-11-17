namespace VistaSGI
{
    partial class FrmInicioSesion
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
            this.btnVerPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.btnLoin = new System.Windows.Forms.Button();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerPass
            // 
            this.btnVerPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerPass.FlatAppearance.BorderSize = 0;
            this.btnVerPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnVerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerPass.Location = new System.Drawing.Point(290, 118);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(39, 20);
            this.btnVerPass.TabIndex = 18;
            this.btnVerPass.Text = "Ver";
            this.btnVerPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPass.UseVisualStyleBackColor = false;
            this.btnVerPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVerPass_MouseDown);
            this.btnVerPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerPass_MouseDown);
            this.btnVerPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerPass_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(31, 58);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(43, 13);
            this.lblPregunta1.TabIndex = 16;
            this.lblPregunta1.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login SGI";
            // 
            // lnkRecuperarContrasena
            // 
            this.lnkRecuperarContrasena.AutoSize = true;
            this.lnkRecuperarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRecuperarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRecuperarContrasena.Location = new System.Drawing.Point(191, 175);
            this.lnkRecuperarContrasena.Name = "lnkRecuperarContrasena";
            this.lnkRecuperarContrasena.Size = new System.Drawing.Size(149, 15);
            this.lnkRecuperarContrasena.TabIndex = 14;
            this.lnkRecuperarContrasena.TabStop = true;
            this.lnkRecuperarContrasena.Text = "Recuperar contraseña";
            this.lnkRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRecuperarContrasena_LinkClicked);
            // 
            // btnLoin
            // 
            this.btnLoin.Location = new System.Drawing.Point(32, 170);
            this.btnLoin.Name = "btnLoin";
            this.btnLoin.Size = new System.Drawing.Size(117, 26);
            this.btnLoin.TabIndex = 13;
            this.btnLoin.Text = "Confirmar";
            this.btnLoin.UseVisualStyleBackColor = true;
            this.btnLoin.Click += new System.EventHandler(this.BtnLoin_Click);
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(32, 118);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(241, 20);
            this.txtPasword.TabIndex = 12;
            this.txtPasword.TextChanged += new System.EventHandler(this.TxtPasword_TextChanged);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(32, 74);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(241, 20);
            this.textUsername.TabIndex = 11;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 272);
            this.Controls.Add(this.btnVerPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkRecuperarContrasena);
            this.Controls.Add(this.btnLoin);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.textUsername);
            this.Name = "FrmInicioSesion";
            this.Text = "FrmInicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkRecuperarContrasena;
        private System.Windows.Forms.Button btnLoin;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox textUsername;
    }
}