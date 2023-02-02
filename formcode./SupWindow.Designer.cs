namespace Mr.PoolSalePoint
{
    partial class SupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContraseñaCaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuarioCaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreCaj = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddSup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContraseñaSup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsuarioSup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreSup = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDelUser = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.BoxProductPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxProductISBM = new System.Windows.Forms.TextBox();
            this.BoxProductName = new System.Windows.Forms.TextBox();
            this.ProductUpdateTable = new System.Windows.Forms.Button();
            this.BoxViewTable = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewPast = new System.Windows.Forms.DataGridView();
            this.textBoxUserPast = new System.Windows.Forms.TextBox();
            this.buttonUpdatePast = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSupervisorUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxViewTable)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPast)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxContraseñaCaj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxUsuarioCaj);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNombreCaj);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Cajero";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Cajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // textBoxContraseñaCaj
            // 
            this.textBoxContraseñaCaj.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaCaj.Location = new System.Drawing.Point(26, 202);
            this.textBoxContraseñaCaj.Name = "textBoxContraseñaCaj";
            this.textBoxContraseñaCaj.PasswordChar = '*';
            this.textBoxContraseñaCaj.Size = new System.Drawing.Size(638, 29);
            this.textBoxContraseñaCaj.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // textBoxUsuarioCaj
            // 
            this.textBoxUsuarioCaj.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioCaj.Location = new System.Drawing.Point(26, 129);
            this.textBoxUsuarioCaj.Name = "textBoxUsuarioCaj";
            this.textBoxUsuarioCaj.Size = new System.Drawing.Size(638, 29);
            this.textBoxUsuarioCaj.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombreCaj
            // 
            this.textBoxNombreCaj.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCaj.Location = new System.Drawing.Point(26, 57);
            this.textBoxNombreCaj.Name = "textBoxNombreCaj";
            this.textBoxNombreCaj.Size = new System.Drawing.Size(638, 29);
            this.textBoxNombreCaj.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.buttonAddSup);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxContraseñaSup);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxUsuarioSup);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxNombreSup);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Supervisor";
            // 
            // buttonAddSup
            // 
            this.buttonAddSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSup.Location = new System.Drawing.Point(218, 261);
            this.buttonAddSup.Name = "buttonAddSup";
            this.buttonAddSup.Size = new System.Drawing.Size(229, 47);
            this.buttonAddSup.TabIndex = 13;
            this.buttonAddSup.Text = "Agregar Supervisor";
            this.buttonAddSup.UseVisualStyleBackColor = true;
            this.buttonAddSup.Click += new System.EventHandler(this.buttonAddSup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña:";
            // 
            // textBoxContraseñaSup
            // 
            this.textBoxContraseñaSup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaSup.Location = new System.Drawing.Point(26, 202);
            this.textBoxContraseñaSup.Name = "textBoxContraseñaSup";
            this.textBoxContraseñaSup.PasswordChar = '*';
            this.textBoxContraseñaSup.Size = new System.Drawing.Size(638, 29);
            this.textBoxContraseñaSup.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario:";
            // 
            // textBoxUsuarioSup
            // 
            this.textBoxUsuarioSup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioSup.Location = new System.Drawing.Point(26, 129);
            this.textBoxUsuarioSup.Name = "textBoxUsuarioSup";
            this.textBoxUsuarioSup.Size = new System.Drawing.Size(638, 29);
            this.textBoxUsuarioSup.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre:";
            // 
            // textBoxNombreSup
            // 
            this.textBoxNombreSup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreSup.Location = new System.Drawing.Point(26, 57);
            this.textBoxNombreSup.Name = "textBoxNombreSup";
            this.textBoxNombreSup.Size = new System.Drawing.Size(638, 29);
            this.textBoxNombreSup.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridViewUsers);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxDelUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(670, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Usuario";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(532, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 61);
            this.button3.TabIndex = 22;
            this.button3.Text = "Actualizar lista usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(9, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(500, 164);
            this.dataGridViewUsers.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "Eliminar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Usuario:";
            // 
            // textBoxDelUser
            // 
            this.textBoxDelUser.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDelUser.Location = new System.Drawing.Point(9, 222);
            this.textBoxDelUser.Name = "textBoxDelUser";
            this.textBoxDelUser.Size = new System.Drawing.Size(655, 29);
            this.textBoxDelUser.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.ProductAddButton);
            this.tabPage4.Controls.Add(this.BoxProductPrice);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.BoxProductISBM);
            this.tabPage4.Controls.Add(this.BoxProductName);
            this.tabPage4.Controls.Add(this.ProductUpdateTable);
            this.tabPage4.Controls.Add(this.BoxViewTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(670, 320);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agregar Productos";
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Location = new System.Drawing.Point(485, 237);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(178, 23);
            this.ProductAddButton.TabIndex = 8;
            this.ProductAddButton.Text = "Agregar Producto";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            this.ProductAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // BoxProductPrice
            // 
            this.BoxProductPrice.Location = new System.Drawing.Point(485, 186);
            this.BoxProductPrice.Name = "BoxProductPrice";
            this.BoxProductPrice.Size = new System.Drawing.Size(178, 28);
            this.BoxProductPrice.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(486, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(486, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "ISBM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(486, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Producto";
            // 
            // BoxProductISBM
            // 
            this.BoxProductISBM.Location = new System.Drawing.Point(485, 117);
            this.BoxProductISBM.Name = "BoxProductISBM";
            this.BoxProductISBM.Size = new System.Drawing.Size(178, 28);
            this.BoxProductISBM.TabIndex = 3;
            // 
            // BoxProductName
            // 
            this.BoxProductName.Location = new System.Drawing.Point(485, 54);
            this.BoxProductName.Name = "BoxProductName";
            this.BoxProductName.Size = new System.Drawing.Size(178, 28);
            this.BoxProductName.TabIndex = 2;
            // 
            // ProductUpdateTable
            // 
            this.ProductUpdateTable.Location = new System.Drawing.Point(485, 281);
            this.ProductUpdateTable.Name = "ProductUpdateTable";
            this.ProductUpdateTable.Size = new System.Drawing.Size(178, 23);
            this.ProductUpdateTable.TabIndex = 1;
            this.ProductUpdateTable.Text = "Actualizar Productos";
            this.ProductUpdateTable.UseVisualStyleBackColor = true;
            this.ProductUpdateTable.Click += new System.EventHandler(this.ProductUpdateTable_Click);
            // 
            // BoxViewTable
            // 
            this.BoxViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoxViewTable.Location = new System.Drawing.Point(15, 15);
            this.BoxViewTable.Name = "BoxViewTable";
            this.BoxViewTable.Size = new System.Drawing.Size(464, 289);
            this.BoxViewTable.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DimGray;
            this.tabPage6.Controls.Add(this.dataGridViewPast);
            this.tabPage6.Controls.Add(this.textBoxUserPast);
            this.tabPage6.Controls.Add(this.buttonUpdatePast);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(670, 320);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Historial";
            // 
            // dataGridViewPast
            // 
            this.dataGridViewPast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPast.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridViewPast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPast.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewPast.Name = "dataGridViewPast";
            this.dataGridViewPast.ReadOnly = true;
            this.dataGridViewPast.Size = new System.Drawing.Size(658, 255);
            this.dataGridViewPast.TabIndex = 16;
            // 
            // textBoxUserPast
            // 
            this.textBoxUserPast.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPast.Location = new System.Drawing.Point(160, 15);
            this.textBoxUserPast.Name = "textBoxUserPast";
            this.textBoxUserPast.Size = new System.Drawing.Size(471, 29);
            this.textBoxUserPast.TabIndex = 15;
            // 
            // buttonUpdatePast
            // 
            this.buttonUpdatePast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePast.Location = new System.Drawing.Point(6, 6);
            this.buttonUpdatePast.Name = "buttonUpdatePast";
            this.buttonUpdatePast.Size = new System.Drawing.Size(132, 47);
            this.buttonUpdatePast.TabIndex = 14;
            this.buttonUpdatePast.Text = "Actualizar Historial";
            this.buttonUpdatePast.UseVisualStyleBackColor = true;
            this.buttonUpdatePast.Click += new System.EventHandler(this.buttonUpdatePast_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(580, 373);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Regresar";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSupervisorUser
            // 
            this.labelSupervisorUser.AutoSize = true;
            this.labelSupervisorUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupervisorUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSupervisorUser.Location = new System.Drawing.Point(3, 0);
            this.labelSupervisorUser.Name = "labelSupervisorUser";
            this.labelSupervisorUser.Size = new System.Drawing.Size(162, 20);
            this.labelSupervisorUser.TabIndex = 4;
            this.labelSupervisorUser.Text = "Usuario de supervisor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelSupervisorUser, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 373);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // SupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxViewTable)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPast)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContraseñaCaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuarioCaj;
        private System.Windows.Forms.Button buttonAddSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContraseñaSup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsuarioSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreSup;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDelUser;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonUpdatePast;
        private System.Windows.Forms.TextBox textBoxUserPast;
        private System.Windows.Forms.DataGridView dataGridViewPast;
        public System.Windows.Forms.Label labelSupervisorUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button ProductUpdateTable;
        private System.Windows.Forms.DataGridView BoxViewTable;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.TextBox BoxProductPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxProductISBM;
        private System.Windows.Forms.TextBox BoxProductName;
    }
}