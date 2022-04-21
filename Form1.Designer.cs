
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.OT = new System.Windows.Forms.Label();
            this.textBoxOT = new System.Windows.Forms.TextBox();
            this.comboBoxProduc = new System.Windows.Forms.ComboBox();
            this.labelProduc = new System.Windows.Forms.Label();
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
            this.tabControlProyecto.Location = new System.Drawing.Point(6, 4);
            this.tabControlProyecto.Name = "tabControlProyecto";
            this.tabControlProyecto.SelectedIndex = 0;
            this.tabControlProyecto.Size = new System.Drawing.Size(782, 434);
            this.tabControlProyecto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelProduc);
            this.tabPage1.Controls.Add(this.comboBoxProduc);
            this.tabPage1.Controls.Add(this.textBoxOT);
            this.tabPage1.Controls.Add(this.OT);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyecto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IngresoInsumos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IngresoEPP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(774, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personal";
            // 
            // OT
            // 
            this.OT.AutoSize = true;
            this.OT.Location = new System.Drawing.Point(19, 19);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(28, 17);
            this.OT.TabIndex = 0;
            this.OT.Text = "OT";
            this.OT.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxOT
            // 
            this.textBoxOT.Location = new System.Drawing.Point(53, 16);
            this.textBoxOT.Name = "textBoxOT";
            this.textBoxOT.Size = new System.Drawing.Size(112, 22);
            this.textBoxOT.TabIndex = 1;
            // 
            // comboBoxProduc
            // 
            this.comboBoxProduc.FormattingEnabled = true;
            this.comboBoxProduc.Items.AddRange(new object[] {
            "Shelter",
            "Skid",
            "Otro"});
            this.comboBoxProduc.Location = new System.Drawing.Point(251, 15);
            this.comboBoxProduc.Name = "comboBoxProduc";
            this.comboBoxProduc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProduc.TabIndex = 2;
            // 
            // labelProduc
            // 
            this.labelProduc.AutoSize = true;
            this.labelProduc.Location = new System.Drawing.Point(181, 19);
            this.labelProduc.Name = "labelProduc";
            this.labelProduc.Size = new System.Drawing.Size(65, 17);
            this.labelProduc.TabIndex = 3;
            this.labelProduc.Text = "Producto";
            // 
            // BracoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProyecto);
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
    }
}

