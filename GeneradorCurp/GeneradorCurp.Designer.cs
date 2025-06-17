namespace GeneradorCurp
{
    partial class GeneradorCurp
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            txtCurp = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            lblEstado = new Label();
            cbEstado = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblApellidos = new Label();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblGenero = new Label();
            rbtGenMasculino = new RadioButton();
            rbtGenFemenino = new RadioButton();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblFechaNacimiento = new Label();
            dtpNacimiento = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel6, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(468, 278);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(txtCurp);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(238, 197);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(224, 75);
            flowLayoutPanel6.TabIndex = 8;
            // 
            // txtCurp
            // 
            txtCurp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurp.Location = new Point(3, 3);
            txtCurp.Name = "txtCurp";
            txtCurp.PlaceholderText = "CURP";
            txtCurp.ReadOnly = true;
            txtCurp.Size = new Size(221, 29);
            txtCurp.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.White;
            flowLayoutPanel5.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel5.Controls.Add(lblEstado);
            flowLayoutPanel5.Controls.Add(cbEstado);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(6, 197);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(223, 75);
            flowLayoutPanel5.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(3, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(147, 16);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado De Nacimiento";
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Coahuila de Zaragoza", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" });
            cbEstado.Location = new Point(3, 19);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(180, 24);
            cbEstado.TabIndex = 0;
            cbEstado.Text = "Seleccione...";
            cbEstado.SelectedIndexChanged += cbEstado_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(lblApellidos);
            flowLayoutPanel2.Controls.Add(txtApellidoPaterno);
            flowLayoutPanel2.Controls.Add(txtApellidoMaterno);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(6, 88);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(223, 100);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(3, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(70, 16);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.ForeColor = SystemColors.WindowFrame;
            txtApellidoPaterno.Location = new Point(3, 19);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.PlaceholderText = "Apellido Paterno";
            txtApellidoPaterno.Size = new Size(180, 21);
            txtApellidoPaterno.TabIndex = 0;
            txtApellidoPaterno.TextChanged += txtApellidoPaterno_TextChanged;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.ForeColor = SystemColors.WindowFrame;
            txtApellidoMaterno.Location = new Point(3, 46);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.PlaceholderText = "Apellido Materno";
            txtApellidoMaterno.Size = new Size(180, 21);
            txtApellidoMaterno.TabIndex = 2;
            txtApellidoMaterno.TextChanged += txtApellidoMaterno_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Controls.Add(txtNombre);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 73);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 16);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(3, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel3.Controls.Add(lblGenero);
            flowLayoutPanel3.Controls.Add(rbtGenMasculino);
            flowLayoutPanel3.Controls.Add(rbtGenFemenino);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(238, 6);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(224, 73);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(3, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(49, 16);
            lblGenero.TabIndex = 6;
            lblGenero.Text = "Genero";
            // 
            // rbtGenMasculino
            // 
            rbtGenMasculino.AutoSize = true;
            rbtGenMasculino.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtGenMasculino.Location = new Point(3, 19);
            rbtGenMasculino.Name = "rbtGenMasculino";
            rbtGenMasculino.Size = new Size(67, 20);
            rbtGenMasculino.TabIndex = 5;
            rbtGenMasculino.TabStop = true;
            rbtGenMasculino.Text = "Hombre";
            rbtGenMasculino.UseVisualStyleBackColor = true;
            rbtGenMasculino.CheckedChanged += rbtGenMasculino_CheckedChanged;
            // 
            // rbtGenFemenino
            // 
            rbtGenFemenino.AutoSize = true;
            rbtGenFemenino.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtGenFemenino.Location = new Point(3, 45);
            rbtGenFemenino.Name = "rbtGenFemenino";
            rbtGenFemenino.Size = new Size(60, 20);
            rbtGenFemenino.TabIndex = 4;
            rbtGenFemenino.TabStop = true;
            rbtGenFemenino.Text = "Mujer";
            rbtGenFemenino.UseVisualStyleBackColor = true;
            rbtGenFemenino.CheckedChanged += rbtGenFemenino_CheckedChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.White;
            flowLayoutPanel4.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel4.Controls.Add(lblFechaNacimiento);
            flowLayoutPanel4.Controls.Add(dtpNacimiento);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(238, 88);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(224, 100);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(3, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(140, 16);
            lblFechaNacimiento.TabIndex = 1;
            lblFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNacimiento.Location = new Point(3, 19);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 21);
            dtpNacimiento.TabIndex = 0;
            dtpNacimiento.ValueChanged += dtpNacimiento_ValueChanged;
            // 
            // GeneradorCurp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "GeneradorCurp";
            Size = new Size(468, 278);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblApellidos;
        private TextBox txtApellidoPaterno;
        private Label lblNombre;
        private TextBox txtNombre;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblGenero;
        private RadioButton rbtGenMasculino;
        private RadioButton rbtGenFemenino;
        private FlowLayoutPanel flowLayoutPanel4;
        private DateTimePicker dtpNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtApellidoMaterno;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label lblEstado;
        private ComboBox cbEstado;
        private TextBox txtCurp;
    }
}
