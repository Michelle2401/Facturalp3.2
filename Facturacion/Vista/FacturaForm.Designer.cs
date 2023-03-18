namespace Vista
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoProductotextBox = new System.Windows.Forms.TextBox();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.ISVtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuariotextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.BackColor = System.Drawing.Color.White;
            this.UsuariotextBox.Location = new System.Drawing.Point(78, 11);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(245, 25);
            this.UsuariotextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(770, 12);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(113, 25);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClientetextBox);
            this.groupBox2.Controls.Add(this.BuscarClientebutton);
            this.groupBox2.Controls.Add(this.IdentidadtextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad:";
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.BackColor = System.Drawing.Color.White;
            this.IdentidadtextBox.Location = new System.Drawing.Point(78, 22);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(245, 25);
            this.IdentidadtextBox.TabIndex = 2;
            this.IdentidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadtextBox_KeyPress);
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.BackColor = System.Drawing.Color.White;
            this.BuscarClientebutton.Location = new System.Drawing.Point(330, 20);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(29, 27);
            this.BuscarClientebutton.TabIndex = 3;
            this.BuscarClientebutton.Text = "__";
            this.BuscarClientebutton.UseVisualStyleBackColor = false;
            this.BuscarClientebutton.Click += new System.EventHandler(this.BuscarClientebutton_Click);
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.BackColor = System.Drawing.Color.White;
            this.NombreClientetextBox.Location = new System.Drawing.Point(365, 22);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.ReadOnly = true;
            this.NombreClientetextBox.Size = new System.Drawing.Size(528, 25);
            this.NombreClientetextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CantidadtextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExistenciatextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripcionProductotextBox);
            this.groupBox3.Controls.Add(this.BuscarProductobutton);
            this.groupBox3.Controls.Add(this.CodigoProductotextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo:";
            // 
            // CodigoProductotextBox
            // 
            this.CodigoProductotextBox.BackColor = System.Drawing.Color.White;
            this.CodigoProductotextBox.Location = new System.Drawing.Point(69, 25);
            this.CodigoProductotextBox.Name = "CodigoProductotextBox";
            this.CodigoProductotextBox.ReadOnly = true;
            this.CodigoProductotextBox.Size = new System.Drawing.Size(245, 25);
            this.CodigoProductotextBox.TabIndex = 4;
            this.CodigoProductotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigotextBox_KeyPress);
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.BackColor = System.Drawing.Color.White;
            this.BuscarProductobutton.Location = new System.Drawing.Point(330, 25);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(29, 27);
            this.BuscarProductobutton.TabIndex = 5;
            this.BuscarProductobutton.Text = "__";
            this.BuscarProductobutton.UseVisualStyleBackColor = false;
            this.BuscarProductobutton.Click += new System.EventHandler(this.BuscarProductobutton_Click);
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.BackColor = System.Drawing.Color.White;
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(365, 27);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(528, 25);
            this.DescripcionProductotextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Existencia:";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.BackColor = System.Drawing.Color.White;
            this.ExistenciatextBox.Location = new System.Drawing.Point(69, 60);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.ReadOnly = true;
            this.ExistenciatextBox.Size = new System.Drawing.Size(245, 25);
            this.ExistenciatextBox.TabIndex = 8;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.BackColor = System.Drawing.Color.White;
            this.CantidadtextBox.Location = new System.Drawing.Point(770, 63);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(108, 25);
            this.CantidadtextBox.TabIndex = 10;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(697, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(1, 243);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(906, 134);
            this.DetalledataGridView.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(679, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "SubTotal:";
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.BackColor = System.Drawing.Color.White;
            this.SubTotaltextBox.Location = new System.Drawing.Point(751, 384);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(149, 25);
            this.SubTotaltextBox.TabIndex = 11;
            // 
            // ISVtextBox
            // 
            this.ISVtextBox.BackColor = System.Drawing.Color.White;
            this.ISVtextBox.Location = new System.Drawing.Point(751, 420);
            this.ISVtextBox.Name = "ISVtextBox";
            this.ISVtextBox.ReadOnly = true;
            this.ISVtextBox.Size = new System.Drawing.Size(149, 25);
            this.ISVtextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(715, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "ISV:";
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.BackColor = System.Drawing.Color.White;
            this.DescuentotextBox.Location = new System.Drawing.Point(751, 451);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(149, 25);
            this.DescuentotextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(670, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Descuento:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.BackColor = System.Drawing.Color.White;
            this.TotaltextBox.Location = new System.Drawing.Point(751, 482);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(149, 25);
            this.TotaltextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total:";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.Color.BlueViolet;
            this.Guardarbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Location = new System.Drawing.Point(165, 447);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(82, 46);
            this.Guardarbutton.TabIndex = 18;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.BlueViolet;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.Location = new System.Drawing.Point(261, 447);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(82, 46);
            this.Cancelarbutton.TabIndex = 19;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(904, 505);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ISVtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubTotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacturaForm";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox CodigoProductotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.TextBox ISVtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
    }
}