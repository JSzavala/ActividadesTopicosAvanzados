namespace ctlClocklib
{
    partial class ctlAlarmClock
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlarm = new Label();
            btnAlarmOff = new Button();
            SuspendLayout();
            // 
            // lblAlarm
            // 
            lblAlarm.AutoSize = true;
            lblAlarm.Location = new Point(0, 25);
            lblAlarm.Name = "lblAlarm";
            lblAlarm.Size = new Size(55, 15);
            lblAlarm.TabIndex = 1;
            lblAlarm.Text = "ALARMA";
            lblAlarm.TextAlign = ContentAlignment.MiddleCenter;
            lblAlarm.Visible = false;
            // 
            // btnAlarmOff
            // 
            btnAlarmOff.Location = new Point(3, 58);
            btnAlarmOff.Name = "btnAlarmOff";
            btnAlarmOff.Size = new Size(122, 23);
            btnAlarmOff.TabIndex = 2;
            btnAlarmOff.Text = "Deshabilitar Alarma";
            btnAlarmOff.UseVisualStyleBackColor = true;
            btnAlarmOff.Click += btnAlarmOff_Click;
            // 
            // ctlAlarmClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAlarmOff);
            Controls.Add(lblAlarm);
            Name = "ctlAlarmClock";
            Size = new Size(165, 97);
            Controls.SetChildIndex(lblAlarm, 0);
            Controls.SetChildIndex(btnAlarmOff, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlarm;
        private Button btnAlarmOff;
    }
}
