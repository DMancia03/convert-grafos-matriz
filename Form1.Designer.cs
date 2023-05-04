namespace Grafoos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbarco = new System.Windows.Forms.ComboBox();
            this.cbvertice = new System.Windows.Forms.ComboBox();
            this.btnelimiarco = new System.Windows.Forms.Button();
            this.btnelimiver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtvert = new System.Windows.Forms.TextBox();
            this.LBLVER = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRecorrido = new System.Windows.Forms.TextBox();
            this.btnanchura = new System.Windows.Forms.Button();
            this.btnprofundida = new System.Windows.Forms.Button();
            this.cbnodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndistancia = new System.Windows.Forms.Button();
            this.cbInicio = new System.Windows.Forms.ComboBox();
            this.cbFinal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvMatrizAdyacencia = new System.Windows.Forms.DataGridView();
            this.lbMatrizAdyacencia = new System.Windows.Forms.Label();
            this.CMSCrearVertice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatrizAdyacencia)).BeginInit();
            this.SuspendLayout();
            // 
            // Pizarra
            // 
            this.Pizarra.BackColor = System.Drawing.Color.DimGray;
            this.Pizarra.Location = new System.Drawing.Point(407, 91);
            this.Pizarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(589, 448);
            this.Pizarra.TabIndex = 0;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulador de Grafos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVerticeToolStripMenuItem,
            this.eliminarNodoToolStripMenuItem,
            this.eliminarArcoToolStripMenuItem});
            this.CMSCrearVertice.Name = "CmS";
            this.CMSCrearVertice.Size = new System.Drawing.Size(172, 76);
            // 
            // nuevoVerticeToolStripMenuItem
            // 
            this.nuevoVerticeToolStripMenuItem.Name = "nuevoVerticeToolStripMenuItem";
            this.nuevoVerticeToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.nuevoVerticeToolStripMenuItem.Text = "Nuevo Vertice";
            this.nuevoVerticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVerticeToolStripMenuItem_Click);
            // 
            // eliminarNodoToolStripMenuItem
            // 
            this.eliminarNodoToolStripMenuItem.Name = "eliminarNodoToolStripMenuItem";
            this.eliminarNodoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.eliminarNodoToolStripMenuItem.Text = "Eliminar nodo";
            this.eliminarNodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarNodoToolStripMenuItem_Click);
            // 
            // eliminarArcoToolStripMenuItem
            // 
            this.eliminarArcoToolStripMenuItem.Name = "eliminarArcoToolStripMenuItem";
            this.eliminarArcoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.eliminarArcoToolStripMenuItem.Text = "Eliminar arco";
            this.eliminarArcoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArcoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbarco);
            this.groupBox1.Controls.Add(this.cbvertice);
            this.groupBox1.Controls.Add(this.btnelimiarco);
            this.groupBox1.Controls.Add(this.btnelimiver);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(348, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbarco
            // 
            this.cbarco.FormattingEnabled = true;
            this.cbarco.Location = new System.Drawing.Point(71, 69);
            this.cbarco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbarco.Name = "cbarco";
            this.cbarco.Size = new System.Drawing.Size(97, 24);
            this.cbarco.TabIndex = 6;
            // 
            // cbvertice
            // 
            this.cbvertice.FormattingEnabled = true;
            this.cbvertice.Location = new System.Drawing.Point(73, 31);
            this.cbvertice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbvertice.Name = "cbvertice";
            this.cbvertice.Size = new System.Drawing.Size(97, 24);
            this.cbvertice.TabIndex = 1;
            // 
            // btnelimiarco
            // 
            this.btnelimiarco.Location = new System.Drawing.Point(177, 66);
            this.btnelimiarco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnelimiarco.Name = "btnelimiarco";
            this.btnelimiarco.Size = new System.Drawing.Size(116, 28);
            this.btnelimiarco.TabIndex = 5;
            this.btnelimiarco.Text = "Eliminar";
            this.btnelimiarco.UseVisualStyleBackColor = true;
            this.btnelimiarco.Click += new System.EventHandler(this.btnelimiarco_Click);
            // 
            // btnelimiver
            // 
            this.btnelimiver.Location = new System.Drawing.Point(177, 31);
            this.btnelimiver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnelimiver.Name = "btnelimiver";
            this.btnelimiver.Size = new System.Drawing.Size(116, 28);
            this.btnelimiver.TabIndex = 4;
            this.btnelimiver.Text = "Eliminar";
            this.btnelimiver.UseVisualStyleBackColor = true;
            this.btnelimiver.Click += new System.EventHandler(this.btnelimiver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vertice:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.txtvert);
            this.groupBox2.Controls.Add(this.LBLVER);
            this.groupBox2.Location = new System.Drawing.Point(32, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(348, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(217, 44);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(131, 33);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtvert
            // 
            this.txtvert.Location = new System.Drawing.Point(232, 12);
            this.txtvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvert.Name = "txtvert";
            this.txtvert.Size = new System.Drawing.Size(93, 22);
            this.txtvert.TabIndex = 2;
            // 
            // LBLVER
            // 
            this.LBLVER.AutoSize = true;
            this.LBLVER.Location = new System.Drawing.Point(8, 21);
            this.LBLVER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLVER.Name = "LBLVER";
            this.LBLVER.Size = new System.Drawing.Size(52, 16);
            this.LBLVER.TabIndex = 1;
            this.LBLVER.Text = "Vértice:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRecorrido);
            this.groupBox3.Controls.Add(this.btnanchura);
            this.groupBox3.Controls.Add(this.btnprofundida);
            this.groupBox3.Controls.Add(this.cbnodo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(32, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(348, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorridos";
            // 
            // textBoxRecorrido
            // 
            this.textBoxRecorrido.Location = new System.Drawing.Point(144, 116);
            this.textBoxRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRecorrido.Name = "textBoxRecorrido";
            this.textBoxRecorrido.Size = new System.Drawing.Size(132, 22);
            this.textBoxRecorrido.TabIndex = 10;
            // 
            // btnanchura
            // 
            this.btnanchura.Location = new System.Drawing.Point(200, 57);
            this.btnanchura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnanchura.Name = "btnanchura";
            this.btnanchura.Size = new System.Drawing.Size(140, 38);
            this.btnanchura.TabIndex = 9;
            this.btnanchura.Text = "Anchura";
            this.btnanchura.UseVisualStyleBackColor = true;
            this.btnanchura.Click += new System.EventHandler(this.btnanchura_Click);
            // 
            // btnprofundida
            // 
            this.btnprofundida.Location = new System.Drawing.Point(28, 54);
            this.btnprofundida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprofundida.Name = "btnprofundida";
            this.btnprofundida.Size = new System.Drawing.Size(140, 38);
            this.btnprofundida.TabIndex = 8;
            this.btnprofundida.Text = "Profundidad";
            this.btnprofundida.UseVisualStyleBackColor = true;
            this.btnprofundida.Click += new System.EventHandler(this.btnprofundida_Click);
            // 
            // cbnodo
            // 
            this.cbnodo.FormattingEnabled = true;
            this.cbnodo.Location = new System.Drawing.Point(144, 23);
            this.cbnodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbnodo.Name = "cbnodo";
            this.cbnodo.Size = new System.Drawing.Size(181, 24);
            this.cbnodo.TabIndex = 7;
            this.cbnodo.SelectedIndexChanged += new System.EventHandler(this.cbnodo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nodo de Partida:";
            // 
            // btndistancia
            // 
            this.btndistancia.Location = new System.Drawing.Point(103, 607);
            this.btndistancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndistancia.Name = "btndistancia";
            this.btndistancia.Size = new System.Drawing.Size(131, 33);
            this.btndistancia.TabIndex = 4;
            this.btndistancia.Text = "Distancia";
            this.btndistancia.UseVisualStyleBackColor = true;
            this.btndistancia.Click += new System.EventHandler(this.btndistancia_Click);
            // 
            // cbInicio
            // 
            this.cbInicio.FormattingEnabled = true;
            this.cbInicio.Location = new System.Drawing.Point(16, 513);
            this.cbInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(160, 24);
            this.cbInicio.TabIndex = 5;
            // 
            // cbFinal
            // 
            this.cbFinal.FormattingEnabled = true;
            this.cbFinal.Location = new System.Drawing.Point(209, 513);
            this.cbFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(160, 24);
            this.cbFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "nodo de inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "nodo final";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(105, 575);
            this.txtRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(132, 22);
            this.txtRecorrido.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recorrido";
            // 
            // DgvMatrizAdyacencia
            // 
            this.DgvMatrizAdyacencia.AllowUserToAddRows = false;
            this.DgvMatrizAdyacencia.AllowUserToDeleteRows = false;
            this.DgvMatrizAdyacencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMatrizAdyacencia.Location = new System.Drawing.Point(1012, 122);
            this.DgvMatrizAdyacencia.Name = "DgvMatrizAdyacencia";
            this.DgvMatrizAdyacencia.ReadOnly = true;
            this.DgvMatrizAdyacencia.RowHeadersWidth = 51;
            this.DgvMatrizAdyacencia.RowTemplate.Height = 24;
            this.DgvMatrizAdyacencia.Size = new System.Drawing.Size(588, 417);
            this.DgvMatrizAdyacencia.TabIndex = 10;
            this.DgvMatrizAdyacencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbMatrizAdyacencia
            // 
            this.lbMatrizAdyacencia.AutoSize = true;
            this.lbMatrizAdyacencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatrizAdyacencia.Location = new System.Drawing.Point(1022, 91);
            this.lbMatrizAdyacencia.Name = "lbMatrizAdyacencia";
            this.lbMatrizAdyacencia.Size = new System.Drawing.Size(165, 24);
            this.lbMatrizAdyacencia.TabIndex = 11;
            this.lbMatrizAdyacencia.Text = "Matriz de adyacencia";
            this.lbMatrizAdyacencia.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1627, 655);
            this.Controls.Add(this.lbMatrizAdyacencia);
            this.Controls.Add(this.DgvMatrizAdyacencia);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFinal);
            this.Controls.Add(this.cbInicio);
            this.Controls.Add(this.btndistancia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pizarra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMSCrearVertice.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatrizAdyacencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVerticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArcoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbarco;
        private System.Windows.Forms.ComboBox cbvertice;
        private System.Windows.Forms.Button btnelimiarco;
        private System.Windows.Forms.Button btnelimiver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtvert;
        private System.Windows.Forms.Label LBLVER;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnanchura;
        private System.Windows.Forms.Button btnprofundida;
        private System.Windows.Forms.ComboBox cbnodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndistancia;
        private System.Windows.Forms.ComboBox cbInicio;
        private System.Windows.Forms.ComboBox cbFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRecorrido;
        private System.Windows.Forms.DataGridView DgvMatrizAdyacencia;
        private System.Windows.Forms.Label lbMatrizAdyacencia;
    }
}

