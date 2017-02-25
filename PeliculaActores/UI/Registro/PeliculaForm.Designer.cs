namespace PeliculaActores.UI.Registro
{
    partial class PeliculaForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label actoresLabel;
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.actoresComboBox = new System.Windows.Forms.ComboBox();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.Guadarbutton3 = new System.Windows.Forms.Button();
            this.Nuevobutton2 = new System.Windows.Forms.Button();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            actoresLabel = new System.Windows.Forms.Label();
            peliculaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(actoresLabel);
            this.groupBox1.Controls.Add(this.actoresComboBox);
            this.groupBox1.Location = new System.Drawing.Point(90, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 205);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(323, 108);
            this.dataGridView1.TabIndex = 14;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Agregarbutton.Location = new System.Drawing.Point(262, 33);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(68, 23);
            this.Agregarbutton.TabIndex = 13;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // actoresLabel
            // 
            actoresLabel.AutoSize = true;
            actoresLabel.Location = new System.Drawing.Point(10, 38);
            actoresLabel.Name = "actoresLabel";
            actoresLabel.Size = new System.Drawing.Size(46, 13);
            actoresLabel.TabIndex = 5;
            actoresLabel.Text = "Actores:";
            // 
            // actoresComboBox
            // 
            this.actoresComboBox.FormattingEnabled = true;
            this.actoresComboBox.Location = new System.Drawing.Point(62, 33);
            this.actoresComboBox.Name = "actoresComboBox";
            this.actoresComboBox.Size = new System.Drawing.Size(192, 21);
            this.actoresComboBox.TabIndex = 6;
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminarbutton4.Location = new System.Drawing.Point(352, 386);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(68, 25);
            this.Eliminarbutton4.TabIndex = 25;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // Guadarbutton3
            // 
            this.Guadarbutton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guadarbutton3.Location = new System.Drawing.Point(235, 386);
            this.Guadarbutton3.Name = "Guadarbutton3";
            this.Guadarbutton3.Size = new System.Drawing.Size(68, 25);
            this.Guadarbutton3.TabIndex = 24;
            this.Guadarbutton3.Text = "Guardar";
            this.Guadarbutton3.UseVisualStyleBackColor = true;
            this.Guadarbutton3.Click += new System.EventHandler(this.Guadarbutton3_Click);
            // 
            // Nuevobutton2
            // 
            this.Nuevobutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nuevobutton2.Location = new System.Drawing.Point(110, 386);
            this.Nuevobutton2.Name = "Nuevobutton2";
            this.Nuevobutton2.Size = new System.Drawing.Size(69, 25);
            this.Nuevobutton2.TabIndex = 23;
            this.Nuevobutton2.Text = "Nuevo";
            this.Nuevobutton2.UseVisualStyleBackColor = true;
            this.Nuevobutton2.Click += new System.EventHandler(this.Nuevobutton2_Click);
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Location = new System.Drawing.Point(206, 67);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(64, 21);
            this.Buscarbutton1.TabIndex = 22;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(87, 71);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 16;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Location = new System.Drawing.Point(152, 68);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(48, 20);
            this.peliculaIdTextBox.TabIndex = 17;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(87, 97);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.Location = new System.Drawing.Point(152, 94);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(275, 20);
            this.nombreTextBox.TabIndex = 19;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(276, 71);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 20;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaDateTimePicker.CustomFormat = "yyy/MM/dd";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(322, 68);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.fechaDateTimePicker.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guadarbutton3);
            this.Controls.Add(this.Nuevobutton2);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "PeliculaForm";
            this.Text = "PeliculaForm";
            this.Load += new System.EventHandler(this.PeliculaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox actoresComboBox;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.Button Guadarbutton3;
        private System.Windows.Forms.Button Nuevobutton2;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}