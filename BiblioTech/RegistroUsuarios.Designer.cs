
namespace BiblioTech
{
    partial class RegistroUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDatosusuarioRegistro = new System.Windows.Forms.Panel();
            this.txtTelefonoRegistro = new System.Windows.Forms.TextBox();
            this.lblTelefonoRegistro = new System.Windows.Forms.Label();
            this.txtDireccionRegistro = new System.Windows.Forms.TextBox();
            this.lblDireccionRegistro = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtDuiRegistro = new System.Windows.Forms.TextBox();
            this.lblDuiRegistro = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.grdUserData = new System.Windows.Forms.DataGridView();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDatosusuarioRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlDatosusuarioRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 450);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datos del Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 94);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Acciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(11, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 55);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(203, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(101, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlDatosusuarioRegistro
            // 
            this.pnlDatosusuarioRegistro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDatosusuarioRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosusuarioRegistro.Controls.Add(this.txtTelefonoRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.lblTelefonoRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.txtDireccionRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.lblDireccionRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.txtFechaRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.lblFechaRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.txtDuiRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.lblDuiRegistro);
            this.pnlDatosusuarioRegistro.Controls.Add(this.lblNombreUser);
            this.pnlDatosusuarioRegistro.Controls.Add(this.txtNombreRegistro);
            this.pnlDatosusuarioRegistro.Location = new System.Drawing.Point(12, 77);
            this.pnlDatosusuarioRegistro.Name = "pnlDatosusuarioRegistro";
            this.pnlDatosusuarioRegistro.Size = new System.Drawing.Size(300, 224);
            this.pnlDatosusuarioRegistro.TabIndex = 1;
            // 
            // txtTelefonoRegistro
            // 
            this.txtTelefonoRegistro.Location = new System.Drawing.Point(78, 164);
            this.txtTelefonoRegistro.Name = "txtTelefonoRegistro";
            this.txtTelefonoRegistro.Size = new System.Drawing.Size(144, 20);
            this.txtTelefonoRegistro.TabIndex = 10;
            // 
            // lblTelefonoRegistro
            // 
            this.lblTelefonoRegistro.AutoSize = true;
            this.lblTelefonoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRegistro.Location = new System.Drawing.Point(12, 164);
            this.lblTelefonoRegistro.Name = "lblTelefonoRegistro";
            this.lblTelefonoRegistro.Size = new System.Drawing.Size(65, 16);
            this.lblTelefonoRegistro.TabIndex = 9;
            this.lblTelefonoRegistro.Text = "Telefono:";
            // 
            // txtDireccionRegistro
            // 
            this.txtDireccionRegistro.Location = new System.Drawing.Point(78, 123);
            this.txtDireccionRegistro.Name = "txtDireccionRegistro";
            this.txtDireccionRegistro.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionRegistro.TabIndex = 8;
            // 
            // lblDireccionRegistro
            // 
            this.lblDireccionRegistro.AutoSize = true;
            this.lblDireccionRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionRegistro.Location = new System.Drawing.Point(12, 123);
            this.lblDireccionRegistro.Name = "lblDireccionRegistro";
            this.lblDireccionRegistro.Size = new System.Drawing.Size(68, 16);
            this.lblDireccionRegistro.TabIndex = 7;
            this.lblDireccionRegistro.Text = "Dirección:";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Location = new System.Drawing.Point(153, 83);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(132, 20);
            this.txtFechaRegistro.TabIndex = 6;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(13, 83);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(136, 16);
            this.lblFechaRegistro.TabIndex = 5;
            this.lblFechaRegistro.Text = "Fecha de nacimiento:";
            // 
            // txtDuiRegistro
            // 
            this.txtDuiRegistro.Location = new System.Drawing.Point(52, 47);
            this.txtDuiRegistro.Name = "txtDuiRegistro";
            this.txtDuiRegistro.Size = new System.Drawing.Size(234, 20);
            this.txtDuiRegistro.TabIndex = 4;
            // 
            // lblDuiRegistro
            // 
            this.lblDuiRegistro.AutoSize = true;
            this.lblDuiRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiRegistro.Location = new System.Drawing.Point(13, 47);
            this.lblDuiRegistro.Name = "lblDuiRegistro";
            this.lblDuiRegistro.Size = new System.Drawing.Size(34, 16);
            this.lblDuiRegistro.TabIndex = 3;
            this.lblDuiRegistro.Text = "DUI:";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.Location = new System.Drawing.Point(12, 18);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(60, 16);
            this.lblNombreUser.TabIndex = 2;
            this.lblNombreUser.Text = "Nombre:";
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Location = new System.Drawing.Point(77, 17);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(208, 20);
            this.txtNombreRegistro.TabIndex = 1;
            // 
            // grdUserData
            // 
            this.grdUserData.AllowUserToAddRows = false;
            this.grdUserData.AllowUserToDeleteRows = false;
            this.grdUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUsuario,
            this.Nombre,
            this.DUI,
            this.FechaDeNacimiento,
            this.Direccion,
            this.Telefono});
            this.grdUserData.Location = new System.Drawing.Point(341, 25);
            this.grdUserData.Name = "grdUserData";
            this.grdUserData.ReadOnly = true;
            this.grdUserData.Size = new System.Drawing.Size(447, 348);
            this.grdUserData.TabIndex = 23;
            // 
            // IDUsuario
            // 
            this.IDUsuario.DataPropertyName = "id";
            this.IDUsuario.HeaderText = "ID";
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DUI
            // 
            this.DUI.DataPropertyName = "dui";
            this.DUI.HeaderText = "DUI";
            this.DUI.Name = "DUI";
            this.DUI.ReadOnly = true;
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.DataPropertyName = "fechadenacimiento";
            this.FechaDeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direcion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUserData);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDatosusuarioRegistro.ResumeLayout(false);
            this.pnlDatosusuarioRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDatosusuarioRegistro;
        private System.Windows.Forms.TextBox txtTelefonoRegistro;
        private System.Windows.Forms.Label lblTelefonoRegistro;
        private System.Windows.Forms.TextBox txtDireccionRegistro;
        private System.Windows.Forms.Label lblDireccionRegistro;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtDuiRegistro;
        private System.Windows.Forms.Label lblDuiRegistro;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.DataGridView grdUserData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}