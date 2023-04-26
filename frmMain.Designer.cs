namespace pryArmanini_ManejoDeCadenas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCantA = new System.Windows.Forms.Label();
            this.dtpTiempo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRemplazar = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblTextoA = new System.Windows.Forms.Label();
            this.lblCantB = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(531, 176);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(175, 202);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblCantA
            // 
            this.lblCantA.AutoSize = true;
            this.lblCantA.Location = new System.Drawing.Point(275, 32);
            this.lblCantA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantA.Name = "lblCantA";
            this.lblCantA.Size = new System.Drawing.Size(14, 16);
            this.lblCantA.TabIndex = 24;
            this.lblCantA.Text = "0";
            // 
            // dtpTiempo
            // 
            this.dtpTiempo.Location = new System.Drawing.Point(118, 96);
            this.dtpTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTiempo.Name = "dtpTiempo";
            this.dtpTiempo.Size = new System.Drawing.Size(268, 22);
            this.dtpTiempo.TabIndex = 23;
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Location = new System.Drawing.Point(18, 103);
            this.lblFecha1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(48, 16);
            this.lblFecha1.TabIndex = 22;
            this.lblFecha1.Text = "Fecha ";
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(18, 66);
            this.lblTextoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(53, 16);
            this.lblTextoB.TabIndex = 21;
            this.lblTextoB.Text = "Texto B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(118, 66);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(132, 22);
            this.txtB.TabIndex = 20;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(505, 134);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 28);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(30, 198);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRemplazar
            // 
            this.btnRemplazar.Location = new System.Drawing.Point(505, 91);
            this.btnRemplazar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemplazar.Name = "btnRemplazar";
            this.btnRemplazar.Size = new System.Drawing.Size(100, 28);
            this.btnRemplazar.TabIndex = 17;
            this.btnRemplazar.Text = "Reemplazar";
            this.btnRemplazar.UseVisualStyleBackColor = true;
            this.btnRemplazar.Click += new System.EventHandler(this.btnRemplazar_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(505, 47);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(100, 28);
            this.btnComparar.TabIndex = 16;
            this.btnComparar.Text = "Comparar ";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(118, 26);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(132, 22);
            this.txtA.TabIndex = 15;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(18, 28);
            this.lblTextoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(53, 16);
            this.lblTextoA.TabIndex = 14;
            this.lblTextoA.Text = "Texto A";
            // 
            // lblCantB
            // 
            this.lblCantB.AutoSize = true;
            this.lblCantB.Location = new System.Drawing.Point(275, 72);
            this.lblCantB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantB.Name = "lblCantB";
            this.lblCantB.Size = new System.Drawing.Size(14, 16);
            this.lblCantB.TabIndex = 27;
            this.lblCantB.Text = "0";
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblCantB);
            this.mrcDatos.Controls.Add(this.lblCantA);
            this.mrcDatos.Controls.Add(this.lblTextoB);
            this.mrcDatos.Controls.Add(this.dtpTiempo);
            this.mrcDatos.Controls.Add(this.lblFecha1);
            this.mrcDatos.Controls.Add(this.txtB);
            this.mrcDatos.Controls.Add(this.txtA);
            this.mrcDatos.Controls.Add(this.lblTextoA);
            this.mrcDatos.Location = new System.Drawing.Point(35, 31);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(425, 140);
            this.mrcDatos.TabIndex = 28;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(505, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 45);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(197)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(641, 279);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRemplazar);
            this.Controls.Add(this.btnComparar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Manejo de Cadenas";
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCantA;
        private System.Windows.Forms.DateTimePicker dtpTiempo;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRemplazar;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.Label lblCantB;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

