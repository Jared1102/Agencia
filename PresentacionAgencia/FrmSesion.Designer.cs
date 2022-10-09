namespace PresentacionAgencia
{
    partial class FrmSesion
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lnklRegistro = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrCerrar = new PresentacionAgencia.ButtonRound();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(34, 121);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(58, 166);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 29);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Iniciar Sesión";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lnklRegistro
            // 
            this.lnklRegistro.AutoSize = true;
            this.lnklRegistro.Location = new System.Drawing.Point(78, 236);
            this.lnklRegistro.Name = "lnklRegistro";
            this.lnklRegistro.Size = new System.Drawing.Size(91, 20);
            this.lnklRegistro.TabIndex = 2;
            this.lnklRegistro.TabStop = true;
            this.lnklRegistro.Text = "Registrarse";
            this.lnklRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklRegistro_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnrCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 75);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No esta registrado aún?";
            // 
            // btnrCerrar
            // 
            this.btnrCerrar.BackgroundImage = global::PresentacionAgencia.Properties.Resources.closeRed_32;
            this.btnrCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrCerrar.FlatAppearance.BorderSize = 0;
            this.btnrCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrCerrar.Location = new System.Drawing.Point(205, 21);
            this.btnrCerrar.Name = "btnrCerrar";
            this.btnrCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnrCerrar.TabIndex = 3;
            this.btnrCerrar.UseVisualStyleBackColor = true;
            this.btnrCerrar.Click += new System.EventHandler(this.btnrCerrar_Click);
            // 
            // FrmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnklRegistro);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lnklRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ButtonRound btnrCerrar;
        private System.Windows.Forms.Label label3;
    }
}