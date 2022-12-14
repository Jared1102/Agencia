namespace PresentacionAgencia
{
    partial class FrmRegistro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbCrearProductos = new System.Windows.Forms.CheckBox();
            this.ckbModificarProductos = new System.Windows.Forms.CheckBox();
            this.ckbEliminarProductos = new System.Windows.Forms.CheckBox();
            this.ckbEliminarHerramientas = new System.Windows.Forms.CheckBox();
            this.ckbModificarHerramientas = new System.Windows.Forms.CheckBox();
            this.ckbCrearHerramientas = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnrCerrar = new PresentacionAgencia.ButtonRound();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnrCerrar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 75);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nuevo Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(363, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(153, 141);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(160, 26);
            this.txtApellidoP.TabIndex = 2;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(450, 141);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(160, 26);
            this.txtApellidoM.TabIndex = 3;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(187, 181);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(126, 26);
            this.dtpNacimiento.TabIndex = 4;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(395, 183);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(215, 26);
            this.txtRFC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "RFC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Productos";
            // 
            // ckbCrearProductos
            // 
            this.ckbCrearProductos.AutoSize = true;
            this.ckbCrearProductos.Location = new System.Drawing.Point(153, 263);
            this.ckbCrearProductos.Name = "ckbCrearProductos";
            this.ckbCrearProductos.Size = new System.Drawing.Size(67, 24);
            this.ckbCrearProductos.TabIndex = 21;
            this.ckbCrearProductos.Text = "Crear";
            this.ckbCrearProductos.UseVisualStyleBackColor = true;
            // 
            // ckbModificarProductos
            // 
            this.ckbModificarProductos.AutoSize = true;
            this.ckbModificarProductos.Location = new System.Drawing.Point(153, 306);
            this.ckbModificarProductos.Name = "ckbModificarProductos";
            this.ckbModificarProductos.Size = new System.Drawing.Size(92, 24);
            this.ckbModificarProductos.TabIndex = 22;
            this.ckbModificarProductos.Text = "Modificar";
            this.ckbModificarProductos.UseVisualStyleBackColor = true;
            // 
            // ckbEliminarProductos
            // 
            this.ckbEliminarProductos.AutoSize = true;
            this.ckbEliminarProductos.Location = new System.Drawing.Point(153, 347);
            this.ckbEliminarProductos.Name = "ckbEliminarProductos";
            this.ckbEliminarProductos.Size = new System.Drawing.Size(84, 24);
            this.ckbEliminarProductos.TabIndex = 23;
            this.ckbEliminarProductos.Text = "Eliminar";
            this.ckbEliminarProductos.UseVisualStyleBackColor = true;
            // 
            // ckbEliminarHerramientas
            // 
            this.ckbEliminarHerramientas.AutoSize = true;
            this.ckbEliminarHerramientas.Location = new System.Drawing.Point(351, 347);
            this.ckbEliminarHerramientas.Name = "ckbEliminarHerramientas";
            this.ckbEliminarHerramientas.Size = new System.Drawing.Size(84, 24);
            this.ckbEliminarHerramientas.TabIndex = 27;
            this.ckbEliminarHerramientas.Text = "Eliminar";
            this.ckbEliminarHerramientas.UseVisualStyleBackColor = true;
            // 
            // ckbModificarHerramientas
            // 
            this.ckbModificarHerramientas.AutoSize = true;
            this.ckbModificarHerramientas.Location = new System.Drawing.Point(351, 306);
            this.ckbModificarHerramientas.Name = "ckbModificarHerramientas";
            this.ckbModificarHerramientas.Size = new System.Drawing.Size(92, 24);
            this.ckbModificarHerramientas.TabIndex = 26;
            this.ckbModificarHerramientas.Text = "Modificar";
            this.ckbModificarHerramientas.UseVisualStyleBackColor = true;
            // 
            // ckbCrearHerramientas
            // 
            this.ckbCrearHerramientas.AutoSize = true;
            this.ckbCrearHerramientas.Location = new System.Drawing.Point(351, 263);
            this.ckbCrearHerramientas.Name = "ckbCrearHerramientas";
            this.ckbCrearHerramientas.Size = new System.Drawing.Size(67, 24);
            this.ckbCrearHerramientas.TabIndex = 25;
            this.ckbCrearHerramientas.Text = "Crear";
            this.ckbCrearHerramientas.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Herramientas";
            // 
            // btnrCerrar
            // 
            this.btnrCerrar.BackgroundImage = global::PresentacionAgencia.Properties.Resources.backBlue_32;
            this.btnrCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrCerrar.FlatAppearance.BorderSize = 0;
            this.btnrCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrCerrar.Location = new System.Drawing.Point(576, 21);
            this.btnrCerrar.Name = "btnrCerrar";
            this.btnrCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnrCerrar.TabIndex = 7;
            this.btnrCerrar.UseVisualStyleBackColor = true;
            this.btnrCerrar.Click += new System.EventHandler(this.btnrCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(92, 96);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(238, 398);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(145, 40);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 465);
            this.Controls.Add(this.ckbEliminarHerramientas);
            this.Controls.Add(this.ckbModificarHerramientas);
            this.Controls.Add(this.ckbCrearHerramientas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckbEliminarProductos);
            this.Controls.Add(this.ckbModificarProductos);
            this.Controls.Add(this.ckbCrearProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbCrearProductos;
        private System.Windows.Forms.CheckBox ckbModificarProductos;
        private System.Windows.Forms.CheckBox ckbEliminarProductos;
        private System.Windows.Forms.CheckBox ckbEliminarHerramientas;
        private System.Windows.Forms.CheckBox ckbModificarHerramientas;
        private System.Windows.Forms.CheckBox ckbCrearHerramientas;
        private System.Windows.Forms.Label label9;
        private ButtonRound btnrCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnRegistro;
    }
}