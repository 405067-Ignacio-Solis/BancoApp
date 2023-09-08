namespace AppBanco.Vistas
{
    partial class frmCuentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.colCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpUltimoMovimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGenerarCbu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CBU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo Cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ultimo Movimiento";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(123, 36);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(123, 68);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 8;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(123, 100);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDniCliente.TabIndex = 9;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(133, 264);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(100, 21);
            this.cboTipoCuenta.TabIndex = 10;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(133, 167);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(100, 20);
            this.txtCbu.TabIndex = 13;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(134, 223);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 14;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCbu,
            this.colSaldo,
            this.colTipoCuenta,
            this.colUltimoMovimiento,
            this.colAcciones});
            this.dgvCuentas.Location = new System.Drawing.Point(264, 35);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(568, 371);
            this.dgvCuentas.TabIndex = 15;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // colCbu
            // 
            this.colCbu.HeaderText = "CBU";
            this.colCbu.Name = "colCbu";
            this.colCbu.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.HeaderText = "Tipo Cuenta";
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.ReadOnly = true;
            // 
            // colUltimoMovimiento
            // 
            this.colUltimoMovimiento.HeaderText = "Ultimo Movimiento";
            this.colUltimoMovimiento.Name = "colUltimoMovimiento";
            this.colUltimoMovimiento.ReadOnly = true;
            this.colUltimoMovimiento.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(75, 358);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 48);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpUltimoMovimiento
            // 
            this.dtpUltimoMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimoMovimiento.Location = new System.Drawing.Point(134, 304);
            this.dtpUltimoMovimiento.Name = "dtpUltimoMovimiento";
            this.dtpUltimoMovimiento.Size = new System.Drawing.Size(99, 20);
            this.dtpUltimoMovimiento.TabIndex = 17;
            // 
            // lblGenerarCbu
            // 
            this.lblGenerarCbu.AutoSize = true;
            this.lblGenerarCbu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGenerarCbu.Location = new System.Drawing.Point(144, 190);
            this.lblGenerarCbu.Name = "lblGenerarCbu";
            this.lblGenerarCbu.Size = new System.Drawing.Size(79, 13);
            this.lblGenerarCbu.TabIndex = 18;
            this.lblGenerarCbu.Text = "Generar CBU...";
            this.lblGenerarCbu.Click += new System.EventHandler(this.lblGenerarCbu_Click);
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 433);
            this.Controls.Add(this.lblGenerarCbu);
            this.Controls.Add(this.dtpUltimoMovimiento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpUltimoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltimoMovimiento;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.Label lblGenerarCbu;
    }
}