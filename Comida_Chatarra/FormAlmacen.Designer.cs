namespace Comida_Chatarra
{
    partial class FormAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton3 = new Comida_Chatarra.RJButton();
            this.rjButton2 = new Comida_Chatarra.RJButton();
            this.rjButton1 = new Comida_Chatarra.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BTN_CERRAR = new System.Windows.Forms.PictureBox();
            this.dtGridViewProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxNOM_PRODUCTO = new System.Windows.Forms.TextBox();
            this.txtBoxPRECIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSTOCK = new System.Windows.Forms.TextBox();
            this.button_AGREGAR = new System.Windows.Forms.Button();
            this.buttonELIMINAR = new System.Windows.Forms.Button();
            this.txtBoxEliminar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.rjButton3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(328, 1088);
            this.panel1.TabIndex = 40;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(43, 607);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(376, 81);
            this.rjButton3.TabIndex = 49;
            this.rjButton3.Text = "      ALMACEN";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(43, 476);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(376, 81);
            this.rjButton2.TabIndex = 48;
            this.rjButton2.Text = "      PLATOS";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(43, 359);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(376, 81);
            this.rjButton1.TabIndex = 47;
            this.rjButton1.Text = "      INICIO";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(264, 12);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-27, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(355, 268);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            // 
            // BTN_CERRAR
            // 
            this.BTN_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR.Image")));
            this.BTN_CERRAR.Location = new System.Drawing.Point(2000, 14);
            this.BTN_CERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_CERRAR.Name = "BTN_CERRAR";
            this.BTN_CERRAR.Size = new System.Drawing.Size(43, 39);
            this.BTN_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CERRAR.TabIndex = 41;
            this.BTN_CERRAR.TabStop = false;
            this.BTN_CERRAR.Click += new System.EventHandler(this.BTN_CERRAR_Click);
            // 
            // dtGridViewProductos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridViewProductos.Location = new System.Drawing.Point(549, 392);
            this.dtGridViewProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridViewProductos.Name = "dtGridViewProductos";
            this.dtGridViewProductos.RowHeadersWidth = 51;
            this.dtGridViewProductos.Size = new System.Drawing.Size(925, 350);
            this.dtGridViewProductos.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(839, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 70);
            this.label2.TabIndex = 44;
            this.label2.Text = "Almacen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(746, 110);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(245, 48);
            this.txtBoxID.TabIndex = 45;
            // 
            // txtBoxNOM_PRODUCTO
            // 
            this.txtBoxNOM_PRODUCTO.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNOM_PRODUCTO.Location = new System.Drawing.Point(746, 202);
            this.txtBoxNOM_PRODUCTO.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNOM_PRODUCTO.Name = "txtBoxNOM_PRODUCTO";
            this.txtBoxNOM_PRODUCTO.Size = new System.Drawing.Size(245, 48);
            this.txtBoxNOM_PRODUCTO.TabIndex = 46;
            // 
            // txtBoxPRECIO
            // 
            this.txtBoxPRECIO.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPRECIO.Location = new System.Drawing.Point(1244, 112);
            this.txtBoxPRECIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPRECIO.Name = "txtBoxPRECIO";
            this.txtBoxPRECIO.Size = new System.Drawing.Size(245, 48);
            this.txtBoxPRECIO.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(487, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 44);
            this.label3.TabIndex = 48;
            this.label3.Text = "Id Producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(375, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 44);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nombre Producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1080, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 44);
            this.label5.TabIndex = 50;
            this.label5.Text = "Precio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(1095, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 44);
            this.label6.TabIndex = 52;
            this.label6.Text = "Stock:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxSTOCK
            // 
            this.txtBoxSTOCK.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSTOCK.Location = new System.Drawing.Point(1244, 202);
            this.txtBoxSTOCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSTOCK.Name = "txtBoxSTOCK";
            this.txtBoxSTOCK.Size = new System.Drawing.Size(245, 48);
            this.txtBoxSTOCK.TabIndex = 51;
            // 
            // button_AGREGAR
            // 
            this.button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AGREGAR.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AGREGAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_AGREGAR.Location = new System.Drawing.Point(1514, 392);
            this.button_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AGREGAR.Name = "button_AGREGAR";
            this.button_AGREGAR.Size = new System.Drawing.Size(282, 79);
            this.button_AGREGAR.TabIndex = 53;
            this.button_AGREGAR.Text = "AGREGAR";
            this.button_AGREGAR.UseVisualStyleBackColor = false;
            this.button_AGREGAR.Click += new System.EventHandler(this.button_AGREGAR_Click);
            // 
            // buttonELIMINAR
            // 
            this.buttonELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonELIMINAR.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonELIMINAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonELIMINAR.Location = new System.Drawing.Point(1514, 507);
            this.buttonELIMINAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonELIMINAR.Name = "buttonELIMINAR";
            this.buttonELIMINAR.Size = new System.Drawing.Size(282, 79);
            this.buttonELIMINAR.TabIndex = 54;
            this.buttonELIMINAR.Text = "ELIMINAR";
            this.buttonELIMINAR.UseVisualStyleBackColor = false;
            this.buttonELIMINAR.Click += new System.EventHandler(this.buttonELIMINAR_Click);
            // 
            // txtBoxEliminar
            // 
            this.txtBoxEliminar.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEliminar.Location = new System.Drawing.Point(1514, 607);
            this.txtBoxEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEliminar.Name = "txtBoxEliminar";
            this.txtBoxEliminar.Size = new System.Drawing.Size(282, 48);
            this.txtBoxEliminar.TabIndex = 55;
            // 
            // FormAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1942, 1088);
            this.Controls.Add(this.txtBoxEliminar);
            this.Controls.Add(this.buttonELIMINAR);
            this.Controls.Add(this.button_AGREGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSTOCK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPRECIO);
            this.Controls.Add(this.txtBoxNOM_PRODUCTO);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGridViewProductos);
            this.Controls.Add(this.BTN_CERRAR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAlmacen";
            this.Text = "FormAlmacen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAlmacen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox BTN_CERRAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private RJButton rjButton3;
        private RJButton rjButton2;
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridView dtGridViewProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxNOM_PRODUCTO;
        private System.Windows.Forms.TextBox txtBoxPRECIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxSTOCK;
        private System.Windows.Forms.Button button_AGREGAR;
        private System.Windows.Forms.Button buttonELIMINAR;
        private System.Windows.Forms.TextBox txtBoxEliminar;
    }
}