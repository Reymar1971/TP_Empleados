namespace UI
{
    partial class FrmPrincipal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtApellidoNombre = new TextBox();
            TxtDni = new TextBox();
            TxtSueldoBruto = new TextBox();
            groupBox1 = new GroupBox();
            BtnListar = new Button();
            BtnConfirmar = new Button();
            BtnAgregar = new Button();
            groupBox2 = new GroupBox();
            DgvListado = new DataGridView();
            BtnPruebaBD = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 48);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido, Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 97);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 149);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Sueldo bruto:";
            // 
            // TxtApellidoNombre
            // 
            TxtApellidoNombre.Location = new Point(119, 40);
            TxtApellidoNombre.Name = "TxtApellidoNombre";
            TxtApellidoNombre.Size = new Size(146, 23);
            TxtApellidoNombre.TabIndex = 3;
            // 
            // TxtDni
            // 
            TxtDni.Location = new Point(62, 89);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(203, 23);
            TxtDni.TabIndex = 4;
            // 
            // TxtSueldoBruto
            // 
            TxtSueldoBruto.Location = new Point(108, 141);
            TxtSueldoBruto.Name = "TxtSueldoBruto";
            TxtSueldoBruto.Size = new Size(157, 23);
            TxtSueldoBruto.TabIndex = 5;
            TxtSueldoBruto.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtDni);
            groupBox1.Controls.Add(BtnListar);
            groupBox1.Controls.Add(TxtSueldoBruto);
            groupBox1.Controls.Add(BtnConfirmar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtApellidoNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 361);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // BtnListar
            // 
            BtnListar.Location = new Point(9, 309);
            BtnListar.Name = "BtnListar";
            BtnListar.Size = new Size(121, 23);
            BtnListar.TabIndex = 10;
            BtnListar.Text = "Listar";
            BtnListar.UseVisualStyleBackColor = true;
            BtnListar.Click += BtnListar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(9, 261);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(123, 23);
            BtnConfirmar.TabIndex = 9;
            BtnConfirmar.Text = "Confirmar Cambios";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(11, 215);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(121, 23);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar Empleado";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvListado);
            groupBox2.Location = new Point(310, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 361);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado";
            // 
            // DgvListado
            // 
            DgvListado.AllowUserToAddRows = false;
            DgvListado.AllowUserToDeleteRows = false;
            DgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListado.Location = new Point(6, 19);
            DgvListado.Name = "DgvListado";
            DgvListado.ReadOnly = true;
            DgvListado.Size = new Size(472, 324);
            DgvListado.TabIndex = 0;
            // 
            // BtnPruebaBD
            // 
            BtnPruebaBD.Location = new Point(677, 394);
            BtnPruebaBD.Name = "BtnPruebaBD";
            BtnPruebaBD.Size = new Size(106, 38);
            BtnPruebaBD.TabIndex = 11;
            BtnPruebaBD.Text = "Probar Conexion";
            BtnPruebaBD.UseVisualStyleBackColor = true;
            BtnPruebaBD.Click += BtnPruebaBD_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 438);
            Controls.Add(BtnPruebaBD);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPrincipal";
            Text = "Empleados";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtApellidoNombre;
        private TextBox TxtDni;
        private TextBox TxtSueldoBruto;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView DgvListado;
        private Button BtnAgregar;
        private Button BtnConfirmar;
        private Button BtnListar;
        private Button BtnPruebaBD;
    }
}