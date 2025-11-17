namespace VistaSGI
{
    partial class FrmRoles
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUsusario = new System.Windows.Forms.Label();
            this.cmbUsusario = new System.Windows.Forms.ComboBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblRolesFamilia = new System.Windows.Forms.Label();
            this.lblRolesExtra = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIrMenu = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Roles SGI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 417);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.Location = new System.Drawing.Point(15, 77);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(43, 13);
            this.lblUsusario.TabIndex = 10;
            this.lblUsusario.Text = "Usuario";
            // 
            // cmbUsusario
            // 
            this.cmbUsusario.FormattingEnabled = true;
            this.cmbUsusario.Location = new System.Drawing.Point(18, 93);
            this.cmbUsusario.Name = "cmbUsusario";
            this.cmbUsusario.Size = new System.Drawing.Size(167, 21);
            this.cmbUsusario.TabIndex = 11;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(18, 49);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(167, 21);
            this.cmbFamilia.TabIndex = 12;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(15, 33);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(58, 13);
            this.lblFamilia.TabIndex = 13;
            this.lblFamilia.Text = "Familia Usr";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(676, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(431, 417);
            this.dataGridView2.TabIndex = 14;
            // 
            // lblRolesFamilia
            // 
            this.lblRolesFamilia.AutoSize = true;
            this.lblRolesFamilia.Location = new System.Drawing.Point(208, 49);
            this.lblRolesFamilia.Name = "lblRolesFamilia";
            this.lblRolesFamilia.Size = new System.Drawing.Size(73, 13);
            this.lblRolesFamilia.TabIndex = 15;
            this.lblRolesFamilia.Text = "Roles Usuario";
            // 
            // lblRolesExtra
            // 
            this.lblRolesExtra.AutoSize = true;
            this.lblRolesExtra.Location = new System.Drawing.Point(673, 49);
            this.lblRolesExtra.Name = "lblRolesExtra";
            this.lblRolesExtra.Size = new System.Drawing.Size(66, 13);
            this.lblRolesExtra.TabIndex = 16;
            this.lblRolesExtra.Text = "Roles Extras";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(18, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnIrMenu
            // 
            this.btnIrMenu.Location = new System.Drawing.Point(110, 519);
            this.btnIrMenu.Name = "btnIrMenu";
            this.btnIrMenu.Size = new System.Drawing.Size(75, 23);
            this.btnIrMenu.TabIndex = 18;
            this.btnIrMenu.Text = "Ir a Menu";
            this.btnIrMenu.UseVisualStyleBackColor = true;
            this.btnIrMenu.Click += new System.EventHandler(this.btnIrMenu_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(18, 519);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "lblMailUsuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Acciones Roles";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnIrMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRolesExtra);
            this.Controls.Add(this.lblRolesFamilia);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.cmbUsusario);
            this.Controls.Add(this.lblUsusario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUsusario;
        private System.Windows.Forms.ComboBox cmbUsusario;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblRolesFamilia;
        private System.Windows.Forms.Label lblRolesExtra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIrMenu;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}