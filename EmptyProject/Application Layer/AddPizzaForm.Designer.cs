namespace EmptyProject.Application_Layer
{
    partial class AddPizzaForm
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
            this.dataGridViewaddpizza = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addpizaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet5 = new EmptyProject.MyDb9DataSet5();
            this.addpizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet = new EmptyProject.MyDb9DataSet();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnupdatepizza = new System.Windows.Forms.Button();
            this.btnaddpizza = new System.Windows.Forms.Button();
            this.txtpizzadescription = new System.Windows.Forms.TextBox();
            this.txtpizzaprice = new System.Windows.Forms.TextBox();
            this.cmbselect = new System.Windows.Forms.ComboBox();
            this.txtpizzaname = new System.Windows.Forms.TextBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.lblpricepizza = new System.Windows.Forms.Label();
            this.lblpizzadesc = new System.Windows.Forms.Label();
            this.lblnamepizza = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpizzaid = new System.Windows.Forms.TextBox();
            this.lblpizzaid = new System.Windows.Forms.Label();
            this.addpizaTableAdapter = new EmptyProject.MyDb9DataSetTableAdapters.addpizaTableAdapter();
            this.myDb9DataSet4 = new EmptyProject.MyDb9DataSet4();
            this.addpizaTableAdapter1 = new EmptyProject.MyDb9DataSet5TableAdapters.addpizaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaddpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpizaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewaddpizza
            // 
            this.dataGridViewaddpizza.AutoGenerateColumns = false;
            this.dataGridViewaddpizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewaddpizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewaddpizza.DataSource = this.addpizaBindingSource1;
            this.dataGridViewaddpizza.Location = new System.Drawing.Point(758, 240);
            this.dataGridViewaddpizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewaddpizza.Name = "dataGridViewaddpizza";
            this.dataGridViewaddpizza.RowHeadersWidth = 62;
            this.dataGridViewaddpizza.RowTemplate.Height = 28;
            this.dataGridViewaddpizza.Size = new System.Drawing.Size(1124, 572);
            this.dataGridViewaddpizza.TabIndex = 68;
            this.dataGridViewaddpizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // addpizaBindingSource1
            // 
            this.addpizaBindingSource1.DataMember = "addpiza";
            this.addpizaBindingSource1.DataSource = this.myDb9DataSet5;
            // 
            // myDb9DataSet5
            // 
            this.myDb9DataSet5.DataSetName = "MyDb9DataSet5";
            this.myDb9DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addpizaBindingSource
            // 
            this.addpizaBindingSource.DataMember = "addpiza";
            this.addpizaBindingSource.DataSource = this.myDb9DataSet;
            // 
            // myDb9DataSet
            // 
            this.myDb9DataSet.DataSetName = "MyDb9DataSet";
            this.myDb9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Black;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(560, 765);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(140, 60);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnupdatepizza
            // 
            this.btnupdatepizza.BackColor = System.Drawing.Color.Black;
            this.btnupdatepizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepizza.ForeColor = System.Drawing.Color.White;
            this.btnupdatepizza.Location = new System.Drawing.Point(370, 765);
            this.btnupdatepizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdatepizza.Name = "btnupdatepizza";
            this.btnupdatepizza.Size = new System.Drawing.Size(140, 60);
            this.btnupdatepizza.TabIndex = 6;
            this.btnupdatepizza.Text = "Update";
            this.btnupdatepizza.UseVisualStyleBackColor = false;
            this.btnupdatepizza.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnaddpizza
            // 
            this.btnaddpizza.BackColor = System.Drawing.Color.Black;
            this.btnaddpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpizza.ForeColor = System.Drawing.Color.White;
            this.btnaddpizza.Location = new System.Drawing.Point(182, 765);
            this.btnaddpizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddpizza.Name = "btnaddpizza";
            this.btnaddpizza.Size = new System.Drawing.Size(142, 60);
            this.btnaddpizza.TabIndex = 5;
            this.btnaddpizza.Text = "Add";
            this.btnaddpizza.UseVisualStyleBackColor = false;
            this.btnaddpizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpizzadescription
            // 
            this.txtpizzadescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzadescription.Location = new System.Drawing.Point(424, 625);
            this.txtpizzadescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzadescription.Multiline = true;
            this.txtpizzadescription.Name = "txtpizzadescription";
            this.txtpizzadescription.Size = new System.Drawing.Size(274, 89);
            this.txtpizzadescription.TabIndex = 4;
            // 
            // txtpizzaprice
            // 
            this.txtpizzaprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaprice.Location = new System.Drawing.Point(424, 543);
            this.txtpizzaprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaprice.Multiline = true;
            this.txtpizzaprice.Name = "txtpizzaprice";
            this.txtpizzaprice.Size = new System.Drawing.Size(230, 39);
            this.txtpizzaprice.TabIndex = 3;
            // 
            // cmbselect
            // 
            this.cmbselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselect.FormattingEnabled = true;
            this.cmbselect.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.cmbselect.Location = new System.Drawing.Point(424, 462);
            this.cmbselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbselect.Name = "cmbselect";
            this.cmbselect.Size = new System.Drawing.Size(230, 33);
            this.cmbselect.TabIndex = 2;
            this.cmbselect.Text = "--Select--";
            // 
            // txtpizzaname
            // 
            this.txtpizzaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaname.Location = new System.Drawing.Point(424, 368);
            this.txtpizzaname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaname.Multiline = true;
            this.txtpizzaname.Name = "txtpizzaname";
            this.txtpizzaname.Size = new System.Drawing.Size(230, 38);
            this.txtpizzaname.TabIndex = 1;
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.BackColor = System.Drawing.Color.Transparent;
            this.lblselect.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.ForeColor = System.Drawing.Color.Black;
            this.lblselect.Location = new System.Drawing.Point(207, 462);
            this.lblselect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(99, 33);
            this.lblselect.TabIndex = 60;
            this.lblselect.Text = "Select";
            // 
            // lblpricepizza
            // 
            this.lblpricepizza.AutoSize = true;
            this.lblpricepizza.BackColor = System.Drawing.Color.Transparent;
            this.lblpricepizza.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpricepizza.ForeColor = System.Drawing.Color.Black;
            this.lblpricepizza.Location = new System.Drawing.Point(207, 543);
            this.lblpricepizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpricepizza.Name = "lblpricepizza";
            this.lblpricepizza.Size = new System.Drawing.Size(84, 33);
            this.lblpricepizza.TabIndex = 59;
            this.lblpricepizza.Text = "Price";
            // 
            // lblpizzadesc
            // 
            this.lblpizzadesc.AutoSize = true;
            this.lblpizzadesc.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzadesc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzadesc.ForeColor = System.Drawing.Color.Black;
            this.lblpizzadesc.Location = new System.Drawing.Point(207, 625);
            this.lblpizzadesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzadesc.Name = "lblpizzadesc";
            this.lblpizzadesc.Size = new System.Drawing.Size(169, 33);
            this.lblpizzadesc.TabIndex = 58;
            this.lblpizzadesc.Text = "Description";
            // 
            // lblnamepizza
            // 
            this.lblnamepizza.AutoSize = true;
            this.lblnamepizza.BackColor = System.Drawing.Color.Transparent;
            this.lblnamepizza.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamepizza.ForeColor = System.Drawing.Color.Black;
            this.lblnamepizza.Location = new System.Drawing.Point(207, 365);
            this.lblnamepizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnamepizza.Name = "lblnamepizza";
            this.lblnamepizza.Size = new System.Drawing.Size(93, 33);
            this.lblnamepizza.TabIndex = 57;
            this.lblnamepizza.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(158, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 82);
            this.label3.TabIndex = 56;
            this.label3.Text = "Add New Pizza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtpizzaid
            // 
            this.txtpizzaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizzaid.Location = new System.Drawing.Point(424, 275);
            this.txtpizzaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpizzaid.Multiline = true;
            this.txtpizzaid.Name = "txtpizzaid";
            this.txtpizzaid.Size = new System.Drawing.Size(230, 42);
            this.txtpizzaid.TabIndex = 8;
            // 
            // lblpizzaid
            // 
            this.lblpizzaid.AutoSize = true;
            this.lblpizzaid.BackColor = System.Drawing.Color.Transparent;
            this.lblpizzaid.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaid.ForeColor = System.Drawing.Color.Black;
            this.lblpizzaid.Location = new System.Drawing.Point(207, 275);
            this.lblpizzaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpizzaid.Name = "lblpizzaid";
            this.lblpizzaid.Size = new System.Drawing.Size(118, 33);
            this.lblpizzaid.TabIndex = 54;
            this.lblpizzaid.Text = "Pizza Id";
            // 
            // addpizaTableAdapter
            // 
            this.addpizaTableAdapter.ClearBeforeFill = true;
            // 
            // myDb9DataSet4
            // 
            this.myDb9DataSet4.DataSetName = "MyDb9DataSet4";
            this.myDb9DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addpizaTableAdapter1
            // 
            this.addpizaTableAdapter1.ClearBeforeFill = true;
            // 
            // AddPizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1807, 999);
            this.Controls.Add(this.dataGridViewaddpizza);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnupdatepizza);
            this.Controls.Add(this.btnaddpizza);
            this.Controls.Add(this.txtpizzadescription);
            this.Controls.Add(this.txtpizzaprice);
            this.Controls.Add(this.cmbselect);
            this.Controls.Add(this.txtpizzaname);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.lblpricepizza);
            this.Controls.Add(this.lblpizzadesc);
            this.Controls.Add(this.lblnamepizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpizzaid);
            this.Controls.Add(this.lblpizzaid);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddPizzaForm";
            this.Text = "AddPizzaForm";
            this.Load += new System.EventHandler(this.AddPizzaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaddpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpizaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewaddpizza;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnupdatepizza;
        private System.Windows.Forms.Button btnaddpizza;
        private System.Windows.Forms.TextBox txtpizzadescription;
        private System.Windows.Forms.TextBox txtpizzaprice;
        private System.Windows.Forms.ComboBox cmbselect;
        private System.Windows.Forms.TextBox txtpizzaname;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Label lblpricepizza;
        private System.Windows.Forms.Label lblpizzadesc;
        private System.Windows.Forms.Label lblnamepizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpizzaid;
        private System.Windows.Forms.Label lblpizzaid;
        private MyDb9DataSet myDb9DataSet;
        private System.Windows.Forms.BindingSource addpizaBindingSource;
        private MyDb9DataSetTableAdapters.addpizaTableAdapter addpizaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private MyDb9DataSet4 myDb9DataSet4;
        private MyDb9DataSet5 myDb9DataSet5;
        private System.Windows.Forms.BindingSource addpizaBindingSource1;
        private MyDb9DataSet5TableAdapters.addpizaTableAdapter addpizaTableAdapter1;
    }
}