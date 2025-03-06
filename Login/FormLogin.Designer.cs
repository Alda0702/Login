namespace Login
{
    partial class FormLogin
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
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblL = new System.Windows.Forms.LinkLabel();
            this.lblIniciaSecion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // piclogo
            // 
            this.piclogo.Image = global::Login.Properties.Resources.Facebook_svg;
            this.piclogo.Location = new System.Drawing.Point(161, 16);
            this.piclogo.Margin = new System.Windows.Forms.Padding(2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(256, 54);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 6;
            this.piclogo.TabStop = false;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Lime;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(196, 296);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(184, 37);
            this.btnCrearCuenta.TabIndex = 27;
            this.btnCrearCuenta.Text = "CREAR CUENTA NUEVA";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(241, 273);
            this.lblL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(114, 13);
            this.lblL.TabIndex = 26;
            this.lblL.TabStop = true;
            this.lblL.Text = " ¿Olvidaste tu cuenta?";
            // 
            // lblIniciaSecion
            // 
            this.lblIniciaSecion.AutoSize = true;
            this.lblIniciaSecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciaSecion.Location = new System.Drawing.Point(202, 94);
            this.lblIniciaSecion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIniciaSecion.Name = "lblIniciaSecion";
            this.lblIniciaSecion.Size = new System.Drawing.Size(193, 20);
            this.lblIniciaSecion.TabIndex = 25;
            this.lblIniciaSecion.Text = "Iniciar seción en facebook";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 233);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(161, 233);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 37);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_2);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(247, 187);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(2);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(170, 20);
            this.txtPsw.TabIndex = 22;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(247, 126);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 20);
            this.txtUser.TabIndex = 21;
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw.Location = new System.Drawing.Point(157, 183);
            this.lblPsw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(92, 20);
            this.lblPsw.TabIndex = 20;
            this.lblPsw.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(157, 126);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 20);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "Usuario";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblIniciaSecion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.piclogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.LinkLabel lblL;
        private System.Windows.Forms.Label lblIniciaSecion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblUser;
    }
}

