namespace PeliculaActores.UI.Consultas
{
    partial class CPelicula
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.hastadateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.desdedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(30, 62);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 11;
            this.Desde.Text = "Desde";
            // 
            // hastadateTimePicker2
            // 
            this.hastadateTimePicker2.CustomFormat = "yyy/MM/dd";
            this.hastadateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hastadateTimePicker2.Location = new System.Drawing.Point(325, 55);
            this.hastadateTimePicker2.Name = "hastadateTimePicker2";
            this.hastadateTimePicker2.Size = new System.Drawing.Size(115, 20);
            this.hastadateTimePicker2.TabIndex = 10;
            // 
            // desdedateTimePicker1
            // 
            this.desdedateTimePicker1.CustomFormat = "yyy/MM/dd";
            this.desdedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdedateTimePicker1.Location = new System.Drawing.Point(74, 55);
            this.desdedateTimePicker1.Name = "desdedateTimePicker1";
            this.desdedateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.desdedateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 195);
            this.dataGridView1.TabIndex = 7;
            // 
            // CPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 305);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.hastadateTimePicker2);
            this.Controls.Add(this.desdedateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CPelicula";
            this.Text = "CPelicula";
            this.Load += new System.EventHandler(this.CPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker hastadateTimePicker2;
        private System.Windows.Forms.DateTimePicker desdedateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}