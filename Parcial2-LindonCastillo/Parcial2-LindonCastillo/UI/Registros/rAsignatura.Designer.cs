namespace Parcial2_LindonCastillo.UI.Registros
{
    partial class rAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsignatura));
            this.label1 = new System.Windows.Forms.Label();
            this.AsignaturaId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Creditos_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "AsignaturaId";
            // 
            // AsignaturaId_numericUpDown
            // 
            this.AsignaturaId_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaId_numericUpDown.Location = new System.Drawing.Point(127, 21);
            this.AsignaturaId_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.AsignaturaId_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AsignaturaId_numericUpDown.Name = "AsignaturaId_numericUpDown";
            this.AsignaturaId_numericUpDown.Size = new System.Drawing.Size(133, 21);
            this.AsignaturaId_numericUpDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Créditos";
            // 
            // Creditos_numericUpDown
            // 
            this.Creditos_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditos_numericUpDown.Location = new System.Drawing.Point(127, 104);
            this.Creditos_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Creditos_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Creditos_numericUpDown.Name = "Creditos_numericUpDown";
            this.Creditos_numericUpDown.Size = new System.Drawing.Size(226, 21);
            this.Creditos_numericUpDown.TabIndex = 8;
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_textBox.Location = new System.Drawing.Point(127, 63);
            this.Descripcion_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(226, 21);
            this.Descripcion_textBox.TabIndex = 9;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::Parcial2_LindonCastillo.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(268, 16);
            this.Buscar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(85, 28);
            this.Buscar_button.TabIndex = 3;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::Parcial2_LindonCastillo.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(254, 154);
            this.Eliminar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(94, 28);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Image = global::Parcial2_LindonCastillo.Properties.Resources.seo_social_web_network_internet_273_icon_icons_com_61489;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_button.Location = new System.Drawing.Point(143, 154);
            this.Guardar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(94, 28);
            this.Guardar_button.TabIndex = 1;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Image = global::Parcial2_LindonCastillo.Properties.Resources.seo_social_web_network_internet_83_icon_icons_com_61502;
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo_button.Location = new System.Drawing.Point(30, 154);
            this.Nuevo_button.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(94, 28);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // rAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 193);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.Creditos_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AsignaturaId_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rAsignatura";
            this.Text = "Registro de Asignatura";
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AsignaturaId_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Creditos_numericUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}