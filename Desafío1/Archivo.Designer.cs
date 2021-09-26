
namespace Desafío1
{
    partial class Archivo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npresion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sangre = new System.Windows.Forms.ComboBox();
            this.tSangre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nPaciente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.npresion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sangre);
            this.groupBox1.Controls.Add(this.tSangre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pGenero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nPaciente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(1429, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(347, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // npresion
            // 
            this.npresion.FormattingEnabled = true;
            this.npresion.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.npresion.Location = new System.Drawing.Point(92, 309);
            this.npresion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npresion.Name = "npresion";
            this.npresion.Size = new System.Drawing.Size(160, 24);
            this.npresion.TabIndex = 7;
            this.npresion.SelectedIndexChanged += new System.EventHandler(this.npresion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nivel de Presión";
            // 
            // Sangre
            // 
            this.Sangre.FormattingEnabled = true;
            this.Sangre.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.Sangre.Location = new System.Drawing.Point(92, 235);
            this.Sangre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(160, 24);
            this.Sangre.TabIndex = 5;
            this.Sangre.SelectedIndexChanged += new System.EventHandler(this.Sangre_SelectedIndexChanged);
            // 
            // tSangre
            // 
            this.tSangre.AutoSize = true;
            this.tSangre.Location = new System.Drawing.Point(119, 215);
            this.tSangre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSangre.Name = "tSangre";
            this.tSangre.Size = new System.Drawing.Size(106, 17);
            this.tSangre.TabIndex = 4;
            this.tSangre.Text = "Tipo de Sangre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genero";
            // 
            // pGenero
            // 
            this.pGenero.FormattingEnabled = true;
            this.pGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.pGenero.Location = new System.Drawing.Point(92, 158);
            this.pGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pGenero.Name = "pGenero";
            this.pGenero.Size = new System.Drawing.Size(160, 24);
            this.pGenero.TabIndex = 2;
            this.pGenero.SelectedIndexChanged += new System.EventHandler(this.pGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Nombre y Apellido";
            // 
            // nPaciente
            // 
            this.nPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPaciente.Location = new System.Drawing.Point(47, 79);
            this.nPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nPaciente.Name = "nPaciente";
            this.nPaciente.Size = new System.Drawing.Size(257, 22);
            this.nPaciente.TabIndex = 0;
            this.nPaciente.TextChanged += new System.EventHandler(this.nPaciente_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.btnDraw);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(1429, 449);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(347, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Maroon;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDraw.Location = new System.Drawing.Point(95, 121);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(167, 28);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Mostrar Archivo";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Maroon;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(95, 85);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(167, 28);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar Archivo";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(95, 49);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 28);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(53, 704);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1827, 762);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Archivo";
            this.Text = "Control de Pacientes";
            this.Load += new System.EventHandler(this.archivo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.archivo_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Sangre;
        private System.Windows.Forms.Label tSangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nPaciente;
        private System.Windows.Forms.ComboBox npresion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

