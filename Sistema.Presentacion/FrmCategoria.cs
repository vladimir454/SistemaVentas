using System;

using Sistema.Negocio;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmCategoria : Form
    {
        private string NombreAnt;
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Listar();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total Registros" + Convert.ToString(DgvListado.Rows.Count);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total Registros" + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripcion"; //converitr con tilde
            DgvListado.Columns[4].Width = 100;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtId.Clear();
            txtDescripcoin.Clear();
            btninsertar.Visible = true;
            erroricono.Clear();
            btnActualizar.Visible = false;

            DgvListado.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(txtNombre.Text== string.Empty)
                {
                    this.MensajeError("falta ingresar algunos datos , seran remarcados");
                    erroricono.SetError(txtNombre, "ingres un nombre. ");
                }
                else
                {
                    Rpta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcoin.Text.Trim());
                    if(Rpta.Equals("OK"))
                        {
                        MensajeOk("se inserto de forma correcta");
                        this.Limpiar();
                        this.Listar();
                        }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;

        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btninsertar.Visible = false;
                txtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcoin.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch(Exception )
            {
                MessageBox.Show("seleccione desde la celda nombre.");
            }
            
        }  

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtNombre.Text == string.Empty || txtId.Text ==string.Empty)
                {
                    this.MensajeError("falta ingresar algunos datos , seran remarcados");
                    erroricono.SetError(txtNombre, "ingres un nombre. ");
                }
                else
                {
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(txtId.Text), this.NombreAnt,txtNombre.Text.Trim(), txtDescripcoin.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        MensajeOk("se actualiza de forma correcta");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach(DataGridViewRow row in DgvListado.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Codigo);

                            if(Rpta.Equals("OK"))
                            {
                                this.MensajeOk("se elimino el registro" + Convert.ToString(row.Cells[2].Value));

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("se activo el registro" + Convert.ToString(row.Cells[2].Value));

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("se desactivo el registro" + Convert.ToString(row.Cells[2].Value));

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
