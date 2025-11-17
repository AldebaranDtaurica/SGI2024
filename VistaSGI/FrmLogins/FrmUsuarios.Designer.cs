namespace VistaSGI
{
    partial class FrmUsuarios
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
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnLustaUsr = new System.Windows.Forms.Button();
            this.btnAltaUsr = new System.Windows.Forms.Button();
            this.btnBajaUsr = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnIrMenu = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscarUsr = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(12, 12);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 37);
            this.btnRoles.TabIndex = 4;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnLustaUsr
            // 
            this.btnLustaUsr.Location = new System.Drawing.Point(93, 12);
            this.btnLustaUsr.Name = "btnLustaUsr";
            this.btnLustaUsr.Size = new System.Drawing.Size(75, 37);
            this.btnLustaUsr.TabIndex = 5;
            this.btnLustaUsr.Text = "Lista de Usr";
            this.btnLustaUsr.UseVisualStyleBackColor = true;
            this.btnLustaUsr.Click += new System.EventHandler(this.btnLustaUsr_Click);
            // 
            // btnAltaUsr
            // 
            this.btnAltaUsr.Location = new System.Drawing.Point(174, 12);
            this.btnAltaUsr.Name = "btnAltaUsr";
            this.btnAltaUsr.Size = new System.Drawing.Size(75, 37);
            this.btnAltaUsr.TabIndex = 6;
            this.btnAltaUsr.Text = "Alta de Usuario";
            this.btnAltaUsr.UseVisualStyleBackColor = true;
            this.btnAltaUsr.Click += new System.EventHandler(this.btnAltaUsr_Click);
            // 
            // btnBajaUsr
            // 
            this.btnBajaUsr.Location = new System.Drawing.Point(245, 401);
            this.btnBajaUsr.Name = "btnBajaUsr";
            this.btnBajaUsr.Size = new System.Drawing.Size(75, 37);
            this.btnBajaUsr.TabIndex = 7;
            this.btnBajaUsr.Text = "Baja de Usuario";
            this.btnBajaUsr.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 401);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnIrMenu
            // 
            this.btnIrMenu.Location = new System.Drawing.Point(123, 401);
            this.btnIrMenu.Name = "btnIrMenu";
            this.btnIrMenu.Size = new System.Drawing.Size(75, 37);
            this.btnIrMenu.TabIndex = 9;
            this.btnIrMenu.Text = "Ir a Menu";
            this.btnIrMenu.UseVisualStyleBackColor = true;
            this.btnIrMenu.Click += new System.EventHandler(this.btnIrMenu_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToOrderColumns = true;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(12, 95);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(759, 300);
            this.dtgUsuarios.TabIndex = 10;
            // 
            // btnBuscarUsr
            // 
            this.btnBuscarUsr.Location = new System.Drawing.Point(255, 64);
            this.btnBuscarUsr.Name = "btnBuscarUsr";
            this.btnBuscarUsr.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarUsr.TabIndex = 11;
            this.btnBuscarUsr.Text = "Buscar";
            this.btnBuscarUsr.UseVisualStyleBackColor = true;
            this.btnBuscarUsr.Click += new System.EventHandler(this.btnBuscarUsr_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(61, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscarUsr);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnIrMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBajaUsr);
            this.Controls.Add(this.btnAltaUsr);
            this.Controls.Add(this.btnLustaUsr);
            this.Controls.Add(this.btnRoles);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnLustaUsr;
        private System.Windows.Forms.Button btnAltaUsr;
        private System.Windows.Forms.Button btnBajaUsr;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnIrMenu;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnBuscarUsr;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}