namespace PresentacionAgencia
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbProductos = new System.Windows.Forms.ToolStripButton();
            this.tsbHerramientas = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuario,
            this.tsbProductos,
            this.tsbHerramientas,
            this.tsbCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(110, 692);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuario.Image")));
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(105, 25);
            this.tsbUsuario.Text = "Usuario";
            this.tsbUsuario.Click += new System.EventHandler(this.tsbUsuario_Click);
            // 
            // tsbProductos
            // 
            this.tsbProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsbProductos.Image")));
            this.tsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductos.Name = "tsbProductos";
            this.tsbProductos.Size = new System.Drawing.Size(105, 25);
            this.tsbProductos.Text = "Productos";
            this.tsbProductos.Click += new System.EventHandler(this.tsbProductos_Click);
            // 
            // tsbHerramientas
            // 
            this.tsbHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbHerramientas.Image = ((System.Drawing.Image)(resources.GetObject("tsbHerramientas.Image")));
            this.tsbHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHerramientas.Name = "tsbHerramientas";
            this.tsbHerramientas.Size = new System.Drawing.Size(105, 25);
            this.tsbHerramientas.Text = "Herramientas";
            this.tsbHerramientas.Click += new System.EventHandler(this.tsbHerramientas_Click);
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrarSesion.Image")));
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(105, 25);
            this.tsbCerrarSesion.Text = "Cerrar Sesión";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Agencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbProductos;
        private System.Windows.Forms.ToolStripButton tsbUsuario;
        private System.Windows.Forms.ToolStripButton tsbHerramientas;
        private System.Windows.Forms.ToolStripButton tsbCerrarSesion;
    }
}