namespace EmptyProject.Application_Layer
{
    partial class CustomerForm
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtcustaddress = new System.Windows.Forms.TextBox();
            this.txtcustmobile = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.lblcustaddress = new System.Windows.Forms.Label();
            this.lblmobilecust = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblcustheading = new System.Windows.Forms.Label();
            this.dataGridViewcustform = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet3 = new EmptyProject.MyDb9DataSet3();
            this.customerTableAdapter = new EmptyProject.MyDb9DataSet3TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancel.Location = new System.Drawing.Point(800, 722);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(138, 65);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Black;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(594, 722);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(138, 65);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcustaddress
            // 
            this.txtcustaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustaddress.Location = new System.Drawing.Point(759, 595);
            this.txtcustaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustaddress.Name = "txtcustaddress";
            this.txtcustaddress.Size = new System.Drawing.Size(211, 31);
            this.txtcustaddress.TabIndex = 3;
            // 
            // txtcustmobile
            // 
            this.txtcustmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustmobile.Location = new System.Drawing.Point(759, 489);
            this.txtcustmobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustmobile.Name = "txtcustmobile";
            this.txtcustmobile.Size = new System.Drawing.Size(211, 31);
            this.txtcustmobile.TabIndex = 2;
            // 
            // txtcustname
            // 
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(759, 388);
            this.txtcustname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(211, 31);
            this.txtcustname.TabIndex = 1;
            // 
            // lblcustaddress
            // 
            this.lblcustaddress.AutoSize = true;
            this.lblcustaddress.BackColor = System.Drawing.Color.Transparent;
            this.lblcustaddress.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustaddress.ForeColor = System.Drawing.Color.Black;
            this.lblcustaddress.Location = new System.Drawing.Point(554, 592);
            this.lblcustaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustaddress.Name = "lblcustaddress";
            this.lblcustaddress.Size = new System.Drawing.Size(125, 33);
            this.lblcustaddress.TabIndex = 51;
            this.lblcustaddress.Text = "Address";
            // 
            // lblmobilecust
            // 
            this.lblmobilecust.AutoSize = true;
            this.lblmobilecust.BackColor = System.Drawing.Color.Transparent;
            this.lblmobilecust.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobilecust.ForeColor = System.Drawing.Color.Black;
            this.lblmobilecust.Location = new System.Drawing.Point(554, 489);
            this.lblmobilecust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmobilecust.Name = "lblmobilecust";
            this.lblmobilecust.Size = new System.Drawing.Size(106, 33);
            this.lblmobilecust.TabIndex = 50;
            this.lblmobilecust.Text = "Mobile";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.BackColor = System.Drawing.Color.Transparent;
            this.lblcustname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Black;
            this.lblcustname.Location = new System.Drawing.Point(554, 383);
            this.lblcustname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(93, 33);
            this.lblcustname.TabIndex = 49;
            this.lblcustname.Text = "Name";
            // 
            // txtcustid
            // 
            this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(759, 289);
            this.txtcustid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(211, 31);
            this.txtcustid.TabIndex = 6;
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.BackColor = System.Drawing.Color.Transparent;
            this.lblcustid.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Black;
            this.lblcustid.Location = new System.Drawing.Point(554, 286);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(179, 33);
            this.lblcustid.TabIndex = 46;
            this.lblcustid.Text = "Customer Id";
            // 
            // lblcustheading
            // 
            this.lblcustheading.AutoSize = true;
            this.lblcustheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustheading.ForeColor = System.Drawing.Color.Red;
            this.lblcustheading.Location = new System.Drawing.Point(616, 126);
            this.lblcustheading.Name = "lblcustheading";
            this.lblcustheading.Size = new System.Drawing.Size(355, 82);
            this.lblcustheading.TabIndex = 59;
            this.lblcustheading.Text = "Customer";
            this.lblcustheading.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridViewcustform
            // 
            this.dataGridViewcustform.AutoGenerateColumns = false;
            this.dataGridViewcustform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcustform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.mobiDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn});
            this.dataGridViewcustform.DataSource = this.customerBindingSource;
            this.dataGridViewcustform.Location = new System.Drawing.Point(1076, 289);
            this.dataGridViewcustform.Name = "dataGridViewcustform";
            this.dataGridViewcustform.RowHeadersWidth = 62;
            this.dataGridViewcustform.RowTemplate.Height = 28;
            this.dataGridViewcustform.Size = new System.Drawing.Size(612, 385);
            this.dataGridViewcustform.TabIndex = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobiDataGridViewTextBoxColumn
            // 
            this.mobiDataGridViewTextBoxColumn.DataPropertyName = "mobi";
            this.mobiDataGridViewTextBoxColumn.HeaderText = "mobi";
            this.mobiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobiDataGridViewTextBoxColumn.Name = "mobiDataGridViewTextBoxColumn";
            this.mobiDataGridViewTextBoxColumn.Width = 150;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.Width = 150;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.myDb9DataSet3;
            // 
            // myDb9DataSet3
            // 
            this.myDb9DataSet3.DataSetName = "MyDb9DataSet3";
            this.myDb9DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1924, 823);
            this.Controls.Add(this.dataGridViewcustform);
            this.Controls.Add(this.lblcustheading);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcustaddress);
            this.Controls.Add(this.txtcustmobile);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.lblcustaddress);
            this.Controls.Add(this.lblmobilecust);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.lblcustid);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtcustaddress;
        private System.Windows.Forms.TextBox txtcustmobile;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label lblcustaddress;
        private System.Windows.Forms.Label lblmobilecust;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblcustheading;
        private System.Windows.Forms.DataGridView dataGridViewcustform;
        private MyDb9DataSet3 myDb9DataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MyDb9DataSet3TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
    }
}