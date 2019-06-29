namespace Parcial2_LindonCastillo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaturaToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.inscripcionToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "&Registro";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaturaToolStripMenuItem1,
            this.estudianteToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.Image = global::Parcial2_LindonCastillo.Properties.Resources.documents_books_6914;
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.asignaturaToolStripMenuItem.Text = "&Asignatura";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.AsignaturaToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Image = global::Parcial2_LindonCastillo.Properties.Resources.Student_id512_44205;
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.estudianteToolStripMenuItem.Text = "&Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.EstudianteToolStripMenuItem_Click);
            // 
            // inscripcionToolStripMenuItem
            // 
            this.inscripcionToolStripMenuItem.Image = global::Parcial2_LindonCastillo.Properties.Resources.business_ordering_pencil_table_2333;
            this.inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            this.inscripcionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.inscripcionToolStripMenuItem.Text = "&Inscripcion";
            this.inscripcionToolStripMenuItem.Click += new System.EventHandler(this.InscripcionToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem1
            // 
            this.asignaturaToolStripMenuItem1.Image = global::Parcial2_LindonCastillo.Properties.Resources.documents_books_6914;
            this.asignaturaToolStripMenuItem1.Name = "asignaturaToolStripMenuItem1";
            this.asignaturaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.asignaturaToolStripMenuItem1.Text = "&Asignatura";
            this.asignaturaToolStripMenuItem1.Click += new System.EventHandler(this.AsignaturaToolStripMenuItem1_Click);
            // 
            // estudianteToolStripMenuItem1
            // 
            this.estudianteToolStripMenuItem1.Image = global::Parcial2_LindonCastillo.Properties.Resources.Student_id512_44205;
            this.estudianteToolStripMenuItem1.Name = "estudianteToolStripMenuItem1";
            this.estudianteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.estudianteToolStripMenuItem1.Text = "&Estudiante";
            this.estudianteToolStripMenuItem1.Click += new System.EventHandler(this.EstudianteToolStripMenuItem1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 254);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem1;
    }
}

