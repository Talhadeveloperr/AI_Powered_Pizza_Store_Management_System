namespace EmptyProject.Application_Layer
{
    partial class OrderPizzaForm
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
            this.components = new System.ComponentModel.Container();
            this.btngetbill = new System.Windows.Forms.Button();
            this.dataGridVieworderpizzaform = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordpizaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet6 = new EmptyProject.MyDb9DataSet6();
            this.ordpizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet1 = new EmptyProject.MyDb9DataSet1();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.txtcustaddress = new System.Windows.Forms.TextBox();
            this.txtcustmobile = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.txtpizzedesc = new System.Windows.Forms.TextBox();
            this.txtpizzaprice = new System.Windows.Forms.TextBox();
            this.txtpizzaquant = new System.Windows.Forms.TextBox();
            this.txtpizzaname = new System.Windows.Forms.TextBox();
            this.lbladdresscust = new System.Windows.Forms.Label();
            this.lblcustmobile = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblpizzadesc = new System.Windows.Forms.Label();
            this.lblpizzaquant = new System.Windows.Forms.Label();
            this.lblpizzaprice = new System.Windows.Forms.Label();
            this.lblpizzaname = new System.Windows.Forms.Label();
            this.txtpizzaid = new System.Windows.Forms.TextBox();
            this.lblpizzaid = new System.Windows.Forms.Label();
            this.lblorderpizzaheading = new System.Windows.Forms.Label();
            this.ordpizaTableAdapter = new EmptyProject.MyDb9DataSet1TableAdapters.ordpizaTableAdapter();
            this.ordpizaTableAdapter1 = new EmptyProject.MyDb9DataSet6TableAdapters.ordpizaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderpizzaform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordpizaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordpizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetbill
            // 
            this.btngetbill.BackColor = System.Drawing.Color.Black;
            this.btngetbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngetbill.Location = new System.Drawing.Point(1401, 572);
            this.btngetbill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngetbill.Name = "btngetbill";
            this.btngetbill.Size = new System.Drawing.Size(152, 52);
            this.btngetbill.TabIndex = 6;
            this.btngetbill.Text = "Get Bill";
            this.btngetbill.UseVisualStyleBackColor = false;
            this.btngetbill.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridVieworderpizzaform
            // 
            this.dataGridVieworderpizzaform.AutoGenerateColumns = false;
            this.dataGridVieworderpizzaform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieworderpizzaform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.qntDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn});
            this.dataGridVieworderpizzaform.DataSource = this.ordpizaBindingSource1;
            this.dataGridVieworderpizzaform.Location = new System.Drawing.Point(533, 659);
            this.dataGridVieworderpizzaform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridVieworderpizzaform.Name = "dataGridVieworderpizzaform";
            this.dataGridVieworderpizzaform.RowHeadersWidth = 62;
            this.dataGridVieworderpizzaform.RowTemplate.Height = 28;
            this.dataGridVieworderpizzaform.Size = new System.Drawing.Size(1107, 343);
            this.dataGridVieworderpizzaform.TabIndex = 76;
            this.dataGridVieworderpizzaform.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "p_id";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "descr";
            this.descrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.Width = 150;
            // 
            // qntDataGridViewTextBoxColumn
            // 
            this.qntDataGridViewTextBoxColumn.DataPropertyName = "qnt";
            this.qntDataGridViewTextBoxColumn.HeaderText = "qnt";
            this.qntDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qntDataGridViewTextBoxColumn.Name = "qntDataGridViewTextBoxColumn";
            this.qntDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "c_name";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordpizaBindingSource1
            // 
            this.ordpizaBindingSource1.DataMember = "ordpiza";
            this.ordpizaBindingSource1.DataSource = this.myDb9DataSet6;
            // 
            // myDb9DataSet6
            // 
            this.myDb9DataSet6.DataSetName = "MyDb9DataSet6";
            this.myDb9DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordpizaBindingSource
            // 
            this.ordpizaBindingSource.DataMember = "ordpiza";
            this.ordpizaBindingSource.DataSource = this.myDb9DataSet1;
            // 
            // myDb9DataSet1
            // 
            this.myDb9DataSet1.DataSetName = "MyDb9DataSet1";
            this.myDb9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancel.Location = new System.Drawing.Point(1216, 572);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(152, 52);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Black;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnorder.Location = new System.Drawing.Point(1034, 572);
            this.btnorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(152, 52);
            this.btnorder.TabIndex = 4;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcustaddress
            // 
            this.txtcustaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustaddress.Location = new System.Drawing.Point(1306, 452);
            this.txtcustaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustaddress.Multiline = true;
            this.txtcustaddress.Name = "txtcustaddress";
            this.txtcustaddress.Size = new System.Drawing.Size(247, 75);
            this.txtcustaddress.TabIndex = 73;
            // 
            // txtcustmobile
            // 
            this.txtcustmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustmobile.Location = new System.Drawing.Point(1306, 369);
            this.txtcustmobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustmobile.Name = "txtcustmobile";
            this.txtcustmobile.Size = new System.Drawing.Size(247, 30);
            this.txtcustmobile.TabIndex = 72;
            // 
            // txtcustname
            // 
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(1306, 280);
            this.txtcustname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(247, 30);
            this.txtcustname.TabIndex = 71;
            // 
            // txtcustid
            // 
            this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(1306, 189);
            this.txtcustid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(247, 30);
            this.txtcustid.TabIndex = 2;
            this.txtcustid.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtpizzedesc
            // 
            this.txtpizzedesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzedesc.Location = new System.Drawing.Point(626, 535);
            this.txtpizzedesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzedesc.Multiline = true;
            this.txtpizzedesc.Name = "txtpizzedesc";
            this.txtpizzedesc.Size = new System.Drawing.Size(236, 70);
            this.txtpizzedesc.TabIndex = 69;
            // 
            // txtpizzaprice
            // 
            this.txtpizzaprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaprice.Location = new System.Drawing.Point(626, 452);
            this.txtpizzaprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaprice.Name = "txtpizzaprice";
            this.txtpizzaprice.Size = new System.Drawing.Size(236, 30);
            this.txtpizzaprice.TabIndex = 68;
            // 
            // txtpizzaquant
            // 
            this.txtpizzaquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaquant.Location = new System.Drawing.Point(626, 369);
            this.txtpizzaquant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaquant.Name = "txtpizzaquant";
            this.txtpizzaquant.Size = new System.Drawing.Size(236, 30);
            this.txtpizzaquant.TabIndex = 3;
            // 
            // txtpizzaname
            // 
            this.txtpizzaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaname.Location = new System.Drawing.Point(626, 282);
            this.txtpizzaname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaname.Name = "txtpizzaname";
            this.txtpizzaname.Size = new System.Drawing.Size(236, 30);
            this.txtpizzaname.TabIndex = 66;
            // 
            // lbladdresscust
            // 
            this.lbladdresscust.AutoSize = true;
            this.lbladdresscust.BackColor = System.Drawing.Color.Transparent;
            this.lbladdresscust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdresscust.ForeColor = System.Drawing.Color.Black;
            this.lbladdresscust.Location = new System.Drawing.Point(1028, 452);
            this.lbladdresscust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdresscust.Name = "lbladdresscust";
            this.lbladdresscust.Size = new System.Drawing.Size(125, 32);
            this.lbladdresscust.TabIndex = 65;
            this.lbladdresscust.Text = "Address";
            // 
            // lblcustmobile
            // 
            this.lblcustmobile.AutoSize = true;
            this.lblcustmobile.BackColor = System.Drawing.Color.Transparent;
            this.lblcustmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustmobile.ForeColor = System.Drawing.Color.Black;
            this.lblcustmobile.Location = new System.Drawing.Point(1028, 369);
            this.lblcustmobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustmobile.Name = "lblcustmobile";
            this.lblcustmobile.Size = new System.Drawing.Size(105, 32);
            this.lblcustmobile.TabIndex = 64;
            this.lblcustmobile.Text = "Mobile";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.BackColor = System.Drawing.Color.Transparent;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Black;
            this.lblcustname.Location = new System.Drawing.Point(1028, 282);
            this.lblcustname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(231, 32);
            this.lblcustname.TabIndex = 63;
            this.lblcustname.Text = "Customer Name";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.BackColor = System.Drawing.Color.Transparent;
            this.lblcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Black;
            this.lblcustid.Location = new System.Drawing.Point(1028, 192);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(177, 32);
            this.lblcustid.TabIndex = 62;
            this.lblcustid.Text = "Customer Id";
            // 
            // lblpizzadesc
            // 
            this.lblpizzadesc.AutoSize = true;
            this.lblpizzadesc.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzadesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzadesc.ForeColor = System.Drawing.Color.Black;
            this.lblpizzadesc.Location = new System.Drawing.Point(440, 529);
            this.lblpizzadesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzadesc.Name = "lblpizzadesc";
            this.lblpizzadesc.Size = new System.Drawing.Size(168, 32);
            this.lblpizzadesc.TabIndex = 61;
            this.lblpizzadesc.Text = "Description";
            // 
            // lblpizzaquant
            // 
            this.lblpizzaquant.AutoSize = true;
            this.lblpizzaquant.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzaquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaquant.ForeColor = System.Drawing.Color.Black;
            this.lblpizzaquant.Location = new System.Drawing.Point(440, 362);
            this.lblpizzaquant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzaquant.Name = "lblpizzaquant";
            this.lblpizzaquant.Size = new System.Drawing.Size(129, 32);
            this.lblpizzaquant.TabIndex = 60;
            this.lblpizzaquant.Text = "Quantity";
            // 
            // lblpizzaprice
            // 
            this.lblpizzaprice.AutoSize = true;
            this.lblpizzaprice.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzaprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaprice.ForeColor = System.Drawing.Color.Black;
            this.lblpizzaprice.Location = new System.Drawing.Point(440, 449);
            this.lblpizzaprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzaprice.Name = "lblpizzaprice";
            this.lblpizzaprice.Size = new System.Drawing.Size(84, 32);
            this.lblpizzaprice.TabIndex = 59;
            this.lblpizzaprice.Text = "Price";
            // 
            // lblpizzaname
            // 
            this.lblpizzaname.AutoSize = true;
            this.lblpizzaname.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaname.ForeColor = System.Drawing.Color.Black;
            this.lblpizzaname.Location = new System.Drawing.Point(440, 274);
            this.lblpizzaname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzaname.Name = "lblpizzaname";
            this.lblpizzaname.Size = new System.Drawing.Size(93, 32);
            this.lblpizzaname.TabIndex = 58;
            this.lblpizzaname.Text = "Name";
            // 
            // txtpizzaid
            // 
            this.txtpizzaid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpizzaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaid.Location = new System.Drawing.Point(626, 192);
            this.txtpizzaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaid.Name = "txtpizzaid";
            this.txtpizzaid.Size = new System.Drawing.Size(236, 30);
            this.txtpizzaid.TabIndex = 1;
            this.txtpizzaid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblpizzaid
            // 
            this.lblpizzaid.AutoSize = true;
            this.lblpizzaid.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaid.ForeColor = System.Drawing.Color.Black;
            this.lblpizzaid.Location = new System.Drawing.Point(440, 189);
            this.lblpizzaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzaid.Name = "lblpizzaid";
            this.lblpizzaid.Size = new System.Drawing.Size(122, 32);
            this.lblpizzaid.TabIndex = 55;
            this.lblpizzaid.Text = "Pizza Id";
            // 
            // lblorderpizzaheading
            // 
            this.lblorderpizzaheading.AutoSize = true;
            this.lblorderpizzaheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderpizzaheading.ForeColor = System.Drawing.Color.Red;
            this.lblorderpizzaheading.Location = new System.Drawing.Point(764, 48);
            this.lblorderpizzaheading.Name = "lblorderpizzaheading";
            this.lblorderpizzaheading.Size = new System.Drawing.Size(675, 82);
            this.lblorderpizzaheading.TabIndex = 85;
            this.lblorderpizzaheading.Text = "Order Pizza Details";
            // 
            // ordpizaTableAdapter
            // 
            this.ordpizaTableAdapter.ClearBeforeFill = true;
            // 
            // ordpizaTableAdapter1
            // 
            this.ordpizaTableAdapter1.ClearBeforeFill = true;
            // 
            // OrderPizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1705, 1050);
            this.Controls.Add(this.lblorderpizzaheading);
            this.Controls.Add(this.btngetbill);
            this.Controls.Add(this.dataGridVieworderpizzaform);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.txtcustaddress);
            this.Controls.Add(this.txtcustmobile);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.txtpizzedesc);
            this.Controls.Add(this.txtpizzaprice);
            this.Controls.Add(this.txtpizzaquant);
            this.Controls.Add(this.txtpizzaname);
            this.Controls.Add(this.lbladdresscust);
            this.Controls.Add(this.lblcustmobile);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.lblpizzadesc);
            this.Controls.Add(this.lblpizzaquant);
            this.Controls.Add(this.lblpizzaprice);
            this.Controls.Add(this.lblpizzaname);
            this.Controls.Add(this.txtpizzaid);
            this.Controls.Add(this.lblpizzaid);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderPizzaForm";
            this.Text = "OrderPizzaForm";
            this.Load += new System.EventHandler(this.OrderPizzaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderpizzaform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordpizaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordpizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngetbill;
        private System.Windows.Forms.DataGridView dataGridVieworderpizzaform;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.TextBox txtcustaddress;
        private System.Windows.Forms.TextBox txtcustmobile;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox txtpizzedesc;
        private System.Windows.Forms.TextBox txtpizzaprice;
        private System.Windows.Forms.TextBox txtpizzaquant;
        private System.Windows.Forms.TextBox txtpizzaname;
        private System.Windows.Forms.Label lbladdresscust;
        private System.Windows.Forms.Label lblcustmobile;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblpizzadesc;
        private System.Windows.Forms.Label lblpizzaquant;
        private System.Windows.Forms.Label lblpizzaprice;
        private System.Windows.Forms.Label lblpizzaname;
        private System.Windows.Forms.TextBox txtpizzaid;
        private System.Windows.Forms.Label lblpizzaid;
        private System.Windows.Forms.Label lblorderpizzaheading;
        private MyDb9DataSet1 myDb9DataSet1;
        private System.Windows.Forms.BindingSource ordpizaBindingSource;
        private MyDb9DataSet1TableAdapters.ordpizaTableAdapter ordpizaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private MyDb9DataSet6 myDb9DataSet6;
        private System.Windows.Forms.BindingSource ordpizaBindingSource1;
        private MyDb9DataSet6TableAdapters.ordpizaTableAdapter ordpizaTableAdapter1;
    }
}