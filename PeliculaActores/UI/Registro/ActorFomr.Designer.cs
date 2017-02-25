namespace PeliculaActores.UI.Registro
{
    partial class ActorFomr
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
            System.Windows.Forms.Label actorIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.actorIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            actorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(219, 175);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton4.TabIndex = 16;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Location = new System.Drawing.Point(127, 175);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton3.TabIndex = 15;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click_1);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(28, 175);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 14;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscarbutton1.FlatAppearance.BorderSize = 0;
            this.Buscarbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Buscarbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Buscarbutton1.Location = new System.Drawing.Point(219, 63);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton1.TabIndex = 13;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click_1);
            // 
            // actorIdLabel
            // 
            actorIdLabel.AutoSize = true;
            actorIdLabel.Location = new System.Drawing.Point(60, 66);
            actorIdLabel.Name = "actorIdLabel";
            actorIdLabel.Size = new System.Drawing.Size(47, 13);
            actorIdLabel.TabIndex = 9;
            actorIdLabel.Text = "Actor Id:";
            // 
            // actorIdTextBox
            // 
            this.actorIdTextBox.Location = new System.Drawing.Point(113, 63);
            this.actorIdTextBox.Name = "actorIdTextBox";
            this.actorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.actorIdTextBox.TabIndex = 10;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(60, 92);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(113, 89);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(181, 20);
            this.nombreTextBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ActorFomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(actorIdLabel);
            this.Controls.Add(this.actorIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "ActorFomr";
            this.Text = "ActorFomr";
            this.Load += new System.EventHandler(this.ActorFomr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.TextBox actorIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}