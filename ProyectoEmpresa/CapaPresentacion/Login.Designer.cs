
namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Salir = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txxCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.BtnSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.White;
            this.Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salir.BackgroundImage")));
            this.Salir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Salir.ErrorImage")));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(284, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(38, 41);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(43, 57);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(242, 38);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "GRUPO ALESE";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbemail.Location = new System.Drawing.Point(3, 205);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(67, 21);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Correo:";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbContraseña.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContraseña.Location = new System.Drawing.Point(3, 295);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(98, 21);
            this.lbContraseña.TabIndex = 3;
            this.lbContraseña.Text = "Contraseña:";
            // 
            // txxCorreo
            // 
            this.txxCorreo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txxCorreo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txxCorreo.Location = new System.Drawing.Point(127, 205);
            this.txxCorreo.Name = "txxCorreo";
            this.txxCorreo.Size = new System.Drawing.Size(195, 25);
            this.txxCorreo.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(127, 291);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(195, 25);
            this.txtContraseña.TabIndex = 5;
            // 
            // BtnSesion
            // 
            this.BtnSesion.BackColor = System.Drawing.Color.Transparent;
            this.BtnSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSesion.BackgroundImage")));
            this.BtnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSesion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSesion.Location = new System.Drawing.Point(105, 385);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(148, 33);
            this.BtnSesion.TabIndex = 6;
            this.BtnSesion.Text = "Iniciar Sesión";
            this.BtnSesion.UseVisualStyleBackColor = false;
            this.BtnSesion.Click += new System.EventHandler(this.BtnSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.lbContraseña);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.lbemail);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.txxCorreo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 453);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 477);
            this.Controls.Add(this.BtnSesion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txxCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button BtnSesion;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel panel1;
    }
}

