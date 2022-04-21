
namespace BracoProyectos
{
    partial class BracoProyectos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlProyecto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelProduc = new System.Windows.Forms.Label();
            this.comboBoxProduc = new System.Windows.Forms.ComboBox();
            this.textBoxOT = new System.Windows.Forms.TextBox();
            this.OT = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelCantFabricar = new System.Windows.Forms.Label();
            this.textBoxCantFabricar = new System.Windows.Forms.TextBox();
            this.textBoxOrdenCompra = new System.Windows.Forms.TextBox();
            this.textBoxDescripProyec = new System.Windows.Forms.TextBox();
            this.labelOrdenCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tabControlProyecto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProyecto
            // 
            this.tabControlProyecto.Controls.Add(this.tabPage1);
            this.tabControlProyecto.Controls.Add(this.tabPage2);
            this.tabControlProyecto.Controls.Add(this.tabPage3);
            this.tabControlProyecto.Controls.Add(this.tabPage4);
            this.tabControlProyecto.Location = new System.Drawing.Point(7, 5);
            this.tabControlProyecto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlProyecto.Name = "tabControlProyecto";
            this.tabControlProyecto.SelectedIndex = 0;
            this.tabControlProyecto.Size = new System.Drawing.Size(880, 542);
            this.tabControlProyecto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.buttonActualizar);
            this.tabPage1.Controls.Add(this.buttonBuscar);
            this.tabPage1.Controls.Add(this.buttonCrear);
            this.tabPage1.Controls.Add(this.comboBoxCliente);
            this.tabPage1.Controls.Add(this.labelCliente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelOrdenCompra);
            this.tabPage1.Controls.Add(this.textBoxDescripProyec);
            this.tabPage1.Controls.Add(this.textBoxOrdenCompra);
            this.tabPage1.Controls.Add(this.textBoxCantFabricar);
            this.tabPage1.Controls.Add(this.labelCantFabricar);
            this.tabPage1.Controls.Add(this.labelFechaInicio);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.labelProduc);
            this.tabPage1.Controls.Add(this.comboBoxProduc);
            this.tabPage1.Controls.Add(this.textBoxOT);
            this.tabPage1.Controls.Add(this.OT);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(872, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyecto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelProduc
            // 
            this.labelProduc.AutoSize = true;
            this.labelProduc.Location = new System.Drawing.Point(21, 106);
            this.labelProduc.Name = "labelProduc";
            this.labelProduc.Size = new System.Drawing.Size(73, 20);
            this.labelProduc.TabIndex = 3;
            this.labelProduc.Text = "Producto";
            // 
            // comboBoxProduc
            // 
            this.comboBoxProduc.FormattingEnabled = true;
            this.comboBoxProduc.Items.AddRange(new object[] {
            "Shelter",
            "Skid",
            "Otro"});
            this.comboBoxProduc.Location = new System.Drawing.Point(100, 98);
            this.comboBoxProduc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxProduc.Name = "comboBoxProduc";
            this.comboBoxProduc.Size = new System.Drawing.Size(136, 28);
            this.comboBoxProduc.TabIndex = 2;
            // 
            // textBoxOT
            // 
            this.textBoxOT.Location = new System.Drawing.Point(60, 30);
            this.textBoxOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOT.Name = "textBoxOT";
            this.textBoxOT.Size = new System.Drawing.Size(126, 26);
            this.textBoxOT.TabIndex = 1;
            // 
            // OT
            // 
            this.OT.AutoSize = true;
            this.OT.Location = new System.Drawing.Point(21, 34);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(30, 20);
            this.OT.TabIndex = 0;
            this.OT.Text = "OT";
            this.OT.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(872, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IngresoInsumos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(872, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IngresoEPP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(872, 509);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(230, 177);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(95, 20);
            this.labelFechaInicio.TabIndex = 5;
            this.labelFechaInicio.Text = "Fecha Inicio";
            // 
            // labelCantFabricar
            // 
            this.labelCantFabricar.AutoSize = true;
            this.labelCantFabricar.Location = new System.Drawing.Point(21, 177);
            this.labelCantFabricar.Name = "labelCantFabricar";
            this.labelCantFabricar.Size = new System.Drawing.Size(73, 20);
            this.labelCantFabricar.TabIndex = 6;
            this.labelCantFabricar.Text = "Cantidad";
            // 
            // textBoxCantFabricar
            // 
            this.textBoxCantFabricar.Location = new System.Drawing.Point(100, 171);
            this.textBoxCantFabricar.Name = "textBoxCantFabricar";
            this.textBoxCantFabricar.Size = new System.Drawing.Size(86, 26);
            this.textBoxCantFabricar.TabIndex = 7;
            // 
            // textBoxOrdenCompra
            // 
            this.textBoxOrdenCompra.Location = new System.Drawing.Point(244, 30);
            this.textBoxOrdenCompra.Name = "textBoxOrdenCompra";
            this.textBoxOrdenCompra.Size = new System.Drawing.Size(185, 26);
            this.textBoxOrdenCompra.TabIndex = 8;
            // 
            // textBoxDescripProyec
            // 
            this.textBoxDescripProyec.Location = new System.Drawing.Point(383, 100);
            this.textBoxDescripProyec.Name = "textBoxDescripProyec";
            this.textBoxDescripProyec.Size = new System.Drawing.Size(440, 26);
            this.textBoxDescripProyec.TabIndex = 9;
            // 
            // labelOrdenCompra
            // 
            this.labelOrdenCompra.AutoSize = true;
            this.labelOrdenCompra.Location = new System.Drawing.Point(201, 36);
            this.labelOrdenCompra.Name = "labelOrdenCompra";
            this.labelOrdenCompra.Size = new System.Drawing.Size(32, 20);
            this.labelOrdenCompra.TabIndex = 10;
            this.labelOrdenCompra.Text = "OC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripción";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(488, 34);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(58, 20);
            this.labelCliente.TabIndex = 12;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Items.AddRange(new object[] {
            "Ectricol",
            "Melexa"});
            this.comboBoxCliente.Location = new System.Drawing.Point(552, 28);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCliente.TabIndex = 13;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(25, 245);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(125, 54);
            this.buttonCrear.TabIndex = 14;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(176, 245);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(125, 54);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(327, 245);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(125, 54);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(478, 245);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(125, 54);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // BracoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tabControlProyecto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BracoProyectos";
            this.Text = "Braco Proyectos";
            this.Load += new System.EventHandler(this.BracoProyectos_Load);
            this.tabControlProyecto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProyecto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label OT;
        private System.Windows.Forms.TextBox textBoxOT;
        private System.Windows.Forms.ComboBox comboBoxProduc;
        private System.Windows.Forms.Label labelProduc;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxCantFabricar;
        private System.Windows.Forms.Label labelCantFabricar;
        private System.Windows.Forms.TextBox textBoxOrdenCompra;
        private System.Windows.Forms.Label labelOrdenCompra;
        private System.Windows.Forms.TextBox textBoxDescripProyec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

