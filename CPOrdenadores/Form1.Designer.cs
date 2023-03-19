
namespace OrdenadorPresentacion
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
            this.lbOrdenadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEncendido = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTamanioGB = new System.Windows.Forms.TextBox();
            this.txtTamanioMax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCrearNuevo = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.tvFiltro = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrdenadores
            // 
            this.lbOrdenadores.FormattingEnabled = true;
            this.lbOrdenadores.ItemHeight = 16;
            this.lbOrdenadores.Location = new System.Drawing.Point(41, 82);
            this.lbOrdenadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbOrdenadores.Name = "lbOrdenadores";
            this.lbOrdenadores.Size = new System.Drawing.Size(255, 356);
            this.lbOrdenadores.TabIndex = 0;
            this.lbOrdenadores.SelectedIndexChanged += new System.EventHandler(this.lbOrdenadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Ordenadores:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 335);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(413, 180);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanio GB:";
            // 
            // chkEncendido
            // 
            this.chkEncendido.AutoSize = true;
            this.chkEncendido.Location = new System.Drawing.Point(417, 294);
            this.chkEncendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEncendido.Name = "chkEncendido";
            this.chkEncendido.Size = new System.Drawing.Size(105, 21);
            this.chkEncendido.TabIndex = 5;
            this.chkEncendido.Text = "Encendido?";
            this.chkEncendido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamanio Max GB:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(461, 180);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 22);
            this.txtId.TabIndex = 7;
            // 
            // txtTamanioGB
            // 
            this.txtTamanioGB.Location = new System.Drawing.Point(461, 213);
            this.txtTamanioGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTamanioGB.Name = "txtTamanioGB";
            this.txtTamanioGB.Size = new System.Drawing.Size(164, 22);
            this.txtTamanioGB.TabIndex = 8;
            // 
            // txtTamanioMax
            // 
            this.txtTamanioMax.Location = new System.Drawing.Point(461, 249);
            this.txtTamanioMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTamanioMax.Name = "txtTamanioMax";
            this.txtTamanioMax.Size = new System.Drawing.Size(164, 22);
            this.txtTamanioMax.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCrearNuevo);
            this.groupBox1.Controls.Add(this.rbEliminar);
            this.groupBox1.Location = new System.Drawing.Point(332, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(312, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // rbCrearNuevo
            // 
            this.rbCrearNuevo.AutoSize = true;
            this.rbCrearNuevo.Location = new System.Drawing.Point(167, 25);
            this.rbCrearNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCrearNuevo.Name = "rbCrearNuevo";
            this.rbCrearNuevo.Size = new System.Drawing.Size(109, 21);
            this.rbCrearNuevo.TabIndex = 1;
            this.rbCrearNuevo.TabStop = true;
            this.rbCrearNuevo.Text = "Crear Nuevo";
            this.rbCrearNuevo.UseVisualStyleBackColor = true;
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(16, 25);
            this.rbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(79, 21);
            this.rbEliminar.TabIndex = 0;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            // 
            // tvFiltro
            // 
            this.tvFiltro.Location = new System.Drawing.Point(735, 213);
            this.tvFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvFiltro.Name = "tvFiltro";
            this.tvFiltro.Size = new System.Drawing.Size(295, 230);
            this.tvFiltro.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filtro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ordenadores de Tamaño Máximo",
            "Encender Ordenadores Tamanio GB",
            "Apagar Todos los Ordenadores"});
            this.comboBox1.Location = new System.Drawing.Point(735, 127);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(839, 160);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(132, 22);
            this.txtFiltro.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tamanio GB:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tvFiltro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTamanioMax);
            this.Controls.Add(this.txtTamanioGB);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEncendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrdenadores);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Laboratorio de Informática";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrdenadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEncendido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTamanioGB;
        private System.Windows.Forms.TextBox txtTamanioMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCrearNuevo;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.TreeView tvFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label5;
    }
}

