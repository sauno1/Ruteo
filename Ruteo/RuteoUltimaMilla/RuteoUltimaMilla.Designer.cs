namespace Ruteo.RuteoUltimaMilla
{
    partial class RuteoUltimaMilla
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
            groupBox1 = new GroupBox();
            RBtnRetiro = new RadioButton();
            RBtnEntrega = new RadioButton();
            LvGuiasDisponibles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox2 = new GroupBox();
            BtnAgregar = new Button();
            BtnSubir = new Button();
            BtnQuitar = new Button();
            this.BtnBajar = new Button();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBtnRetiro);
            groupBox1.Controls.Add(RBtnEntrega);
            groupBox1.Location = new Point(39, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de ruteo";
            // 
            // RBtnRetiro
            // 
            RBtnRetiro.AutoSize = true;
            RBtnRetiro.Location = new Point(198, 32);
            RBtnRetiro.Name = "RBtnRetiro";
            RBtnRetiro.RightToLeft = RightToLeft.Yes;
            RBtnRetiro.Size = new Size(146, 19);
            RBtnRetiro.TabIndex = 3;
            RBtnRetiro.TabStop = true;
            RBtnRetiro.Text = "Retiro de encomiendas";
            RBtnRetiro.UseVisualStyleBackColor = true;
            RBtnRetiro.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // RBtnEntrega
            // 
            RBtnEntrega.AutoSize = true;
            RBtnEntrega.Location = new Point(17, 32);
            RBtnEntrega.Name = "RBtnEntrega";
            RBtnEntrega.RightToLeft = RightToLeft.Yes;
            RBtnEntrega.Size = new Size(155, 19);
            RBtnEntrega.TabIndex = 2;
            RBtnEntrega.TabStop = true;
            RBtnEntrega.Text = "Entrega de encomiendas";
            RBtnEntrega.UseVisualStyleBackColor = true;
            RBtnEntrega.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            LvGuiasDisponibles.Location = new Point(17, 32);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(678, 130);
            LvGuiasDisponibles.TabIndex = 5;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Guía";
            columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo";
            columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Peso";
            columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha admisión";
            columnHeader5.Width = 135;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView1.Location = new Point(16, 196);
            listView1.Name = "listView1";
            listView1.Size = new Size(678, 130);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nro Guía";
            columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Dirección";
            columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Peso";
            columnHeader9.Width = 135;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha admisión";
            columnHeader10.Width = 135;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Orden";
            columnHeader11.Width = 135;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.BtnBajar);
            groupBox2.Controls.Add(BtnQuitar);
            groupBox2.Controls.Add(BtnSubir);
            groupBox2.Controls.Add(BtnAgregar);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(LvGuiasDisponibles);
            groupBox2.Location = new Point(39, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(714, 410);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(17, 161);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(679, 23);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnSubir
            // 
            BtnSubir.Location = new Point(15, 326);
            BtnSubir.Name = "BtnSubir";
            BtnSubir.Size = new Size(679, 23);
            BtnSubir.TabIndex = 9;
            BtnSubir.Text = "Subir";
            BtnSubir.UseVisualStyleBackColor = true;
            BtnSubir.Click += BtnQuitar_Click;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(15, 367);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(679, 23);
            BtnQuitar.TabIndex = 10;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // BtnBajar
            // 
            this.BtnBajar.Location = new Point(15, 346);
            this.BtnBajar.Name = "BtnBajar";
            this.BtnBajar.Size = new Size(679, 23);
            this.BtnBajar.TabIndex = 11;
            this.BtnBajar.Text = "Bajar";
            this.BtnBajar.UseVisualStyleBackColor = true;
            this.BtnBajar.Click += this.button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(39, 515);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(714, 60);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Asignación de fletero";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(677, 23);
            comboBox1.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(597, 590);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(678, 590);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 11;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // RuteoUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 635);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "RuteoUltimaMilla";
            Text = "RuteoUltimaMilla";
            Load += RuteoUltimaMilla_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RBtnEntrega;
        private RadioButton RBtnRetiro;
        private ListView LvGuiasDisponibles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private GroupBox groupBox2;
        private Button BtnAgregar;
        private Button BtnSubir;
        private Button button2;
        private Button BtnQuitar;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button BtnCancelar;
        private Button BtnConfirmar;
    }
}