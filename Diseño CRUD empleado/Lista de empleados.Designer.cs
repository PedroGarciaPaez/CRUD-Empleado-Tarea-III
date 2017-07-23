namespace Diseño_CRUD_empleado
{
    partial class Lista_de_empleados
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.radioid = new System.Windows.Forms.RadioButton();
            this.radionombre = new System.Windows.Forms.RadioButton();
            this.radioapellido = new System.Windows.Forms.RadioButton();
            this.radiocedula = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(440, 20);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(56, 19);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(514, 20);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(56, 19);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(581, 20);
            this.btncrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(56, 19);
            this.btncrear.TabIndex = 7;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(9, 69);
            this.dgvEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(894, 402);
            this.dgvEmpleado.TabIndex = 8;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            this.dgvEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleado_CellMouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(238, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(171, 23);
            this.txtBuscar.TabIndex = 9;
            // 
            // radioid
            // 
            this.radioid.AutoSize = true;
            this.radioid.Location = new System.Drawing.Point(9, 22);
            this.radioid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioid.Name = "radioid";
            this.radioid.Size = new System.Drawing.Size(36, 17);
            this.radioid.TabIndex = 10;
            this.radioid.TabStop = true;
            this.radioid.Text = "ID";
            this.radioid.UseVisualStyleBackColor = true;
            // 
            // radionombre
            // 
            this.radionombre.AutoSize = true;
            this.radionombre.Location = new System.Drawing.Point(45, 22);
            this.radionombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radionombre.Name = "radionombre";
            this.radionombre.Size = new System.Drawing.Size(62, 17);
            this.radionombre.TabIndex = 11;
            this.radionombre.TabStop = true;
            this.radionombre.Text = "Nombre";
            this.radionombre.UseVisualStyleBackColor = true;
            // 
            // radioapellido
            // 
            this.radioapellido.AutoSize = true;
            this.radioapellido.Location = new System.Drawing.Point(109, 22);
            this.radioapellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioapellido.Name = "radioapellido";
            this.radioapellido.Size = new System.Drawing.Size(62, 17);
            this.radioapellido.TabIndex = 12;
            this.radioapellido.TabStop = true;
            this.radioapellido.Text = "Apellido";
            this.radioapellido.UseVisualStyleBackColor = true;
            // 
            // radiocedula
            // 
            this.radiocedula.AutoSize = true;
            this.radiocedula.Location = new System.Drawing.Point(179, 22);
            this.radiocedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiocedula.Name = "radiocedula";
            this.radiocedula.Size = new System.Drawing.Size(58, 17);
            this.radiocedula.TabIndex = 13;
            this.radiocedula.TabStop = true;
            this.radiocedula.Text = "Cedula";
            this.radiocedula.UseVisualStyleBackColor = true;
            // 
            // Lista_de_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 481);
            this.Controls.Add(this.radiocedula);
            this.Controls.Add(this.radioapellido);
            this.Controls.Add(this.radionombre);
            this.Controls.Add(this.radioid);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnbuscar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lista_de_empleados";
            this.Text = "Lista_de_empleados";
            this.Load += new System.EventHandler(this.Lista_de_empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton radioid;
        private System.Windows.Forms.RadioButton radionombre;
        private System.Windows.Forms.RadioButton radioapellido;
        private System.Windows.Forms.RadioButton radiocedula;
    }
}