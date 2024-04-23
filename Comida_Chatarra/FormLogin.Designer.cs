namespace Comida_Chatarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ACCEDER = new System.Windows.Forms.Button();
            this.text_USUARIO = new System.Windows.Forms.TextBox();
            this.BTN_CERRAR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 292);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // text_CONTRASEÑA
            // 
            this.text_CONTRASEÑA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text_CONTRASEÑA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_CONTRASEÑA.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CONTRASEÑA.ForeColor = System.Drawing.Color.DimGray;
            this.text_CONTRASEÑA.Location = new System.Drawing.Point(218, 141);
            this.text_CONTRASEÑA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_CONTRASEÑA.Name = "text_CONTRASEÑA";
            this.text_CONTRASEÑA.Size = new System.Drawing.Size(371, 27);
            this.text_CONTRASEÑA.TabIndex = 2;
            this.text_CONTRASEÑA.Text = "CONTRASEÑA";
            this.text_CONTRASEÑA.Enter += new System.EventHandler(this.text_CONTRASEÑA_Enter);
            this.text_CONTRASEÑA.Leave += new System.EventHandler(this.text_CONTRASEÑA_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // button_ACCEDER
            // 
            this.button_ACCEDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_ACCEDER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_ACCEDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_ACCEDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ACCEDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ACCEDER.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ACCEDER.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ACCEDER.Location = new System.Drawing.Point(262, 202);
            this.button_ACCEDER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ACCEDER.Name = "button_ACCEDER";
            this.button_ACCEDER.Size = new System.Drawing.Size(327, 40);
            this.button_ACCEDER.TabIndex = 4;
            this.button_ACCEDER.Text = "ACCEDER";
            this.button_ACCEDER.UseVisualStyleBackColor = false;
            this.button_ACCEDER.Click += new System.EventHandler(this.button_ACCEDER_Click);
            // 
            // text_USUARIO
            // 
            this.text_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_USUARIO.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_USUARIO.ForeColor = System.Drawing.Color.DimGray;
            this.text_USUARIO.Location = new System.Drawing.Point(218, 98);
            this.text_USUARIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_USUARIO.Name = "text_USUARIO";
            this.text_USUARIO.Size = new System.Drawing.Size(371, 27);
            this.text_USUARIO.TabIndex = 1;
            this.text_USUARIO.Text = "USUARIO";
            this.text_USUARIO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text_USUARIO.Enter += new System.EventHandler(this.text_USUARIO_Enter);
            this.text_USUARIO.Leave += new System.EventHandler(this.text_USUARIO_Leave);
            // 
            // BTN_CERRAR
            // 
            this.BTN_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR.Image")));
            this.BTN_CERRAR.Location = new System.Drawing.Point(614, 10);
            this.BTN_CERRAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CERRAR.Name = "BTN_CERRAR";
            this.BTN_CERRAR.Size = new System.Drawing.Size(27, 28);
            this.BTN_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CERRAR.TabIndex = 5;
            this.BTN_CERRAR.TabStop = false;
            this.BTN_CERRAR.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(650, 292);
            this.Controls.Add(this.BTN_CERRAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_CONTRASEÑA);
            this.Controls.Add(this.text_USUARIO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ACCEDER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_CONTRASEÑA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ACCEDER;
        private System.Windows.Forms.TextBox text_USUARIO;
        private System.Windows.Forms.PictureBox BTN_CERRAR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

