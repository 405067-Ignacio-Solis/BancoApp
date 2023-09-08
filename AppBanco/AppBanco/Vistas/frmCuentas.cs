using AppBanco.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco.Vistas
{
    public partial class frmCuentas : Form
    {
        DBHelper DB = new DBHelper();
        public frmCuentas()
        {
            InitializeComponent();
            
        }

       
                private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validar datos cliente

            if (string.IsNullOrEmpty(txtNombreCliente.Text)) {
                MessageBox.Show("Debe ingresar un nombre primero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Debe ingresar un apellido primero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(txtDniCliente.Text))
            {
                MessageBox.Show("Debe ingresar un DNI primero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // validar datos cuenta

            if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show("Debe ingresar un saldo primero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (cboTipoCuenta.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un tipo de cuenta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // crear objetos cliente y cuenta


            //obtener datos cuenta cuenta
            int cbuCuenta = Convert.ToInt32(txtCbu.Text);
            double saldoCuenta = Convert.ToDouble(txtSaldo.Text);
            int tipoCuenta = cboTipoCuenta.SelectedIndex + 1;
            DateTime ultimoMovmientoCuenta = dtpUltimoMovimiento.Value;

            
            //


            // cliente ya existe?


            int dniCliente = Convert.ToInt32(txtDniCliente.Text);


            Cliente cliente = DB.clienteExiste(dniCliente);

            bool clienteExiste = false;

            //crear cliente y cuenta
            Cliente nuevoCliente = null;
            Cuenta nuevaCuenta = new Cuenta(cbuCuenta, saldoCuenta, tipoCuenta, ultimoMovmientoCuenta, nuevoCliente);



            if (cliente == null)
            {
                string nombreNuevoCliente = txtNombreCliente.Text;
                string apellidoNuevoCliente = txtApellidoCliente.Text;

                nuevoCliente = new Cliente(nombreNuevoCliente, apellidoNuevoCliente, dniCliente);



            }
            else {
                clienteExiste = true;
            }

            if (clienteExiste)
            {
                DB.cargarSinCliente(cliente.Dni, nuevaCuenta);
                
            }
            else {
                DB.cargarConClienteNuevo(nuevoCliente, nuevaCuenta);

            }
            
            string itemTipoCuenta = cboTipoCuenta.GetItemText(cboTipoCuenta.SelectedItem);

            dgvCuentas.Rows.Add(cbuCuenta, saldoCuenta, itemTipoCuenta, ultimoMovmientoCuenta, "Quitar");

            //proximo cbu
            txtCbu.Text = Convert.ToString(DB.proximoCBU() + 1);



        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            
            dtpUltimoMovimiento.Value = DateTime.Now;
            
            cargarComboTipoCuenta();
            
        }

        private void cargarComboTipoCuenta() {
            DataTable tabla = DB.consultar("SP_CONSULTAR_TIPO_CUENTA");
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.ValueMember = "id_tipo_cuenta";
            cboTipoCuenta.DisplayMember = "nombre";
        }

        private void lblGenerarCbu_Click(object sender, EventArgs e)
        {
            int proximo = DB.proximoCBU();
            txtCbu.Text = (proximo + 1).ToString();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvCuentas.Rows[e.RowIndex];
                int cbu = Convert.ToInt32(row.Cells[0].Value);
                DB.borrarCuenta(cbu);

                dgvCuentas.Rows.RemoveAt(e.RowIndex);
            }

        }

    }
}
