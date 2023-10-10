
namespace BiblioTech
{
    partial class RegistroLibros
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
            this.lblCodigoRL = new System.Windows.Forms.Label();
            this.txtCodigoRL = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblNombreRL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRL = new System.Windows.Forms.TextBox();
            this.txtAutorRL = new System.Windows.Forms.TextBox();
            this.txtCategoriaRL = new System.Windows.Forms.TextBox();
            this.txtCantidadesRL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.grdBiblioDatos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Autor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBiblioDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoRL
            // 
            this.lblCodigoRL.AutoSize = true;
            this.lblCodigoRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoRL.Location = new System.Drawing.Point(35, 33);
            this.lblCodigoRL.Name = "lblCodigoRL";
            this.lblCodigoRL.Size = new System.Drawing.Size(58, 16);
            this.lblCodigoRL.TabIndex = 0;
            this.lblCodigoRL.Text = "Codigo";
            this.lblCodigoRL.Click += new System.EventHandler(this.lblCodigoRL_Click);
            // 
            // txtCodigoRL
            // 
            this.txtCodigoRL.Location = new System.Drawing.Point(105, 32);
            this.txtCodigoRL.Name = "txtCodigoRL";
            this.txtCodigoRL.Size = new System.Drawing.Size(173, 20);
            this.txtCodigoRL.TabIndex = 1;
            this.txtCodigoRL.TextChanged += new System.EventHandler(this.txtCodigoRL_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(11, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblNombreRL
            // 
            this.lblNombreRL.AutoSize = true;
            this.lblNombreRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRL.Location = new System.Drawing.Point(35, 87);
            this.lblNombreRL.Name = "lblNombreRL";
            this.lblNombreRL.Size = new System.Drawing.Size(63, 16);
            this.lblNombreRL.TabIndex = 3;
            this.lblNombreRL.Text = "Nombre";
            this.lblNombreRL.Click += new System.EventHandler(this.lblNombreRL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidades";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreRL
            // 
            this.txtNombreRL.Location = new System.Drawing.Point(105, 83);
            this.txtNombreRL.Name = "txtNombreRL";
            this.txtNombreRL.Size = new System.Drawing.Size(173, 20);
            this.txtNombreRL.TabIndex = 7;
            this.txtNombreRL.TextChanged += new System.EventHandler(this.txtNombreRL_TextChanged);
            // 
            // txtAutorRL
            // 
            this.txtAutorRL.Location = new System.Drawing.Point(105, 131);
            this.txtAutorRL.Name = "txtAutorRL";
            this.txtAutorRL.Size = new System.Drawing.Size(173, 20);
            this.txtAutorRL.TabIndex = 8;
            this.txtAutorRL.TextChanged += new System.EventHandler(this.txtAutorRL_TextChanged);
            // 
            // txtCategoriaRL
            // 
            this.txtCategoriaRL.Location = new System.Drawing.Point(105, 179);
            this.txtCategoriaRL.Name = "txtCategoriaRL";
            this.txtCategoriaRL.Size = new System.Drawing.Size(173, 20);
            this.txtCategoriaRL.TabIndex = 9;
            this.txtCategoriaRL.TextChanged += new System.EventHandler(this.txtCategoriaRL_TextChanged);
            // 
            // txtCantidadesRL
            // 
            this.txtCantidadesRL.Location = new System.Drawing.Point(105, 225);
            this.txtCantidadesRL.Name = "txtCantidadesRL";
            this.txtCantidadesRL.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadesRL.TabIndex = 10;
            this.txtCantidadesRL.TextChanged += new System.EventHandler(this.txtCantidadesRL_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(203, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 94);
            this.panel1.TabIndex = 14;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblCodigoRL);
            this.panel2.Controls.Add(this.txtNombreRL);
            this.panel2.Controls.Add(this.lblNombreRL);
            this.panel2.Controls.Add(this.txtCodigoRL);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCantidadesRL);
            this.panel2.Controls.Add(this.txtAutorRL);
            this.panel2.Controls.Add(this.txtCategoriaRL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 260);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Registro de Libros";
            // 
            // grdBiblioDatos
            // 
            this.grdBiblioDatos.AllowUserToAddRows = false;
            this.grdBiblioDatos.AllowUserToDeleteRows = false;
            this.grdBiblioDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBiblioDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Codigo,
            this.Nombre,
            this.Autor,
            this.Categoria,
            this.Cantidades});
            this.grdBiblioDatos.Location = new System.Drawing.Point(342, 53);
            this.grdBiblioDatos.Name = "grdBiblioDatos";
            this.grdBiblioDatos.ReadOnly = true;
            this.grdBiblioDatos.Size = new System.Drawing.Size(432, 349);
            this.grdBiblioDatos.TabIndex = 16;
            this.grdBiblioDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "IDLibros";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Cantidades
            // 
            this.Cantidades.DataPropertyName = "Cantidades";
            this.Cantidades.HeaderText = "Cantidades";
            this.Cantidades.Name = "Cantidades";
            this.Cantidades.ReadOnly = true;
            // 
            // RegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.grdBiblioDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegistroLibros";
            this.Text = "RegistroLibros";
            this.Load += new System.EventHandler(this.RegistroLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBiblioDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoRL;
        private System.Windows.Forms.TextBox txtCodigoRL;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblNombreRL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRL;
        private System.Windows.Forms.TextBox txtAutorRL;
        private System.Windows.Forms.TextBox txtCategoriaRL;
        private System.Windows.Forms.TextBox txtCantidadesRL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdBiblioDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewLinkColumn Codigo;
        private System.Windows.Forms.DataGridViewLinkColumn Nombre;
        private System.Windows.Forms.DataGridViewLinkColumn Autor;
        private System.Windows.Forms.DataGridViewLinkColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidades;
    }
}