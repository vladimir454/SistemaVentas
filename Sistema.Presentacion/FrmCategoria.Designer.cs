
namespace Sistema.Presentacion
{
    partial class FrmCategoria
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
            this.components = new System.ComponentModel.Container();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.Estado = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionaar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mantenimiento = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtmostrarm = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcoin = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.Estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.mantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.Estado);
            this.TabGeneral.Controls.Add(this.mantenimiento);
            this.TabGeneral.Location = new System.Drawing.Point(13, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(784, 443);
            this.TabGeneral.TabIndex = 0;
            // 
            // Estado
            // 
            this.Estado.Controls.Add(this.btnEliminar);
            this.Estado.Controls.Add(this.btnDesactivar);
            this.Estado.Controls.Add(this.btnActivar);
            this.Estado.Controls.Add(this.ChkSeleccionar);
            this.Estado.Controls.Add(this.btnBuscar);
            this.Estado.Controls.Add(this.txtBuscar);
            this.Estado.Controls.Add(this.lblTotal);
            this.Estado.Controls.Add(this.DgvListado);
            this.Estado.Location = new System.Drawing.Point(4, 22);
            this.Estado.Name = "Estado";
            this.Estado.Padding = new System.Windows.Forms.Padding(3);
            this.Estado.Size = new System.Drawing.Size(776, 417);
            this.Estado.TabIndex = 0;
            this.Estado.Text = "estado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(348, 379);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 21);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(234, 379);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(108, 21);
            this.btnDesactivar.TabIndex = 6;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(120, 378);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(108, 21);
            this.btnActivar.TabIndex = 5;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(7, 379);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(450, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(19, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(370, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(494, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionaar});
            this.DgvListado.Location = new System.Drawing.Point(7, 86);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(752, 277);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.TabStop = false;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionaar
            // 
            this.Seleccionaar.HeaderText = "Seleccionar";
            this.Seleccionaar.Name = "Seleccionaar";
            this.Seleccionaar.ReadOnly = true;
            // 
            // mantenimiento
            // 
            this.mantenimiento.Controls.Add(this.btnActualizar);
            this.mantenimiento.Controls.Add(this.txtmostrarm);
            this.mantenimiento.Controls.Add(this.btnCancelar);
            this.mantenimiento.Controls.Add(this.btninsertar);
            this.mantenimiento.Controls.Add(this.txtId);
            this.mantenimiento.Controls.Add(this.txtDescripcoin);
            this.mantenimiento.Controls.Add(this.txtNombre);
            this.mantenimiento.Controls.Add(this.Descripcion);
            this.mantenimiento.Controls.Add(this.Nombre);
            this.mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.mantenimiento.Name = "mantenimiento";
            this.mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.mantenimiento.Size = new System.Drawing.Size(776, 417);
            this.mantenimiento.TabIndex = 1;
            this.mantenimiento.Text = "Mantenimiento";
            this.mantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(142, 239);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtmostrarm
            // 
            this.txtmostrarm.AutoSize = true;
            this.txtmostrarm.Location = new System.Drawing.Point(133, 196);
            this.txtmostrarm.Name = "txtmostrarm";
            this.txtmostrarm.Size = new System.Drawing.Size(84, 13);
            this.txtmostrarm.TabIndex = 7;
            this.txtmostrarm.Text = "(*) es obligatiorio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(142, 239);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(260, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // txtDescripcoin
            // 
            this.txtDescripcoin.Location = new System.Drawing.Point(133, 74);
            this.txtDescripcoin.Multiline = true;
            this.txtDescripcoin.Name = "txtDescripcoin";
            this.txtDescripcoin.Size = new System.Drawing.Size(277, 88);
            this.txtDescripcoin.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(26, 77);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripcion";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(26, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(54, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre(*)";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 506);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.TabGeneral.ResumeLayout(false);
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.mantenimiento.ResumeLayout(false);
            this.mantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage Estado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionaar;
        private System.Windows.Forms.TabPage mantenimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label txtmostrarm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcoin;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
    }
}