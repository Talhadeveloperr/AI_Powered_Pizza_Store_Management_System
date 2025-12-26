namespace EmptyProject.Application_Layer
{
    partial class PaymentForm
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
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb9DataSet2 = new EmptyProject.MyDb9DataSet2();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.cmbselect = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.lblorderid = new System.Windows.Forms.Label();
            this.lblpaymentheading = new System.Windows.Forms.Label();
            this.payTableAdapter = new EmptyProject.MyDb9DataSet2TableAdapters.payTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // payBindingSource
            // 
            this.payBindingSource.DataMember = "pay";
            this.payBindingSource.DataSource = this.myDb9DataSet2;
            // 
            // myDb9DataSet2
            // 
            this.myDb9DataSet2.DataSetName = "MyDb9DataSet2";
            this.myDb9DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancel.Location = new System.Drawing.Point(921, 705);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(150, 64);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.Black;
            this.btnpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpay.Location = new System.Drawing.Point(652, 705);
            this.btnpay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(150, 64);
            this.btnpay.TabIndex = 3;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbselect
            // 
            this.cmbselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselect.FormattingEnabled = true;
            this.cmbselect.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbselect.Location = new System.Drawing.Point(856, 545);
            this.cmbselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbselect.Name = "cmbselect";
            this.cmbselect.Size = new System.Drawing.Size(308, 40);
            this.cmbselect.TabIndex = 2;
            this.cmbselect.Text = "--Select--";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(840, 436);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(308, 39);
            this.txtamount.TabIndex = 48;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.Black;
            this.lbltype.Location = new System.Drawing.Point(614, 545);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(81, 32);
            this.lbltype.TabIndex = 47;
            this.lbltype.Text = "Type";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.Color.Transparent;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.Color.Black;
            this.lblamount.Location = new System.Drawing.Point(614, 440);
            this.lblamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(118, 32);
            this.lblamount.TabIndex = 46;
            this.lblamount.Text = "Amount";
            // 
            // txtorderid
            // 
            this.txtorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderid.Location = new System.Drawing.Point(840, 327);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(308, 39);
            this.txtorderid.TabIndex = 1;
            this.txtorderid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.BackColor = System.Drawing.Color.Transparent;
            this.lblorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderid.ForeColor = System.Drawing.Color.Black;
            this.lblorderid.Location = new System.Drawing.Point(614, 330);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(124, 32);
            this.lblorderid.TabIndex = 43;
            this.lblorderid.Text = "Order Id";
            // 
            // lblpaymentheading
            // 
            this.lblpaymentheading.AutoSize = true;
            this.lblpaymentheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymentheading.ForeColor = System.Drawing.Color.Red;
            this.lblpaymentheading.Location = new System.Drawing.Point(737, 142);
            this.lblpaymentheading.Name = "lblpaymentheading";
            this.lblpaymentheading.Size = new System.Drawing.Size(326, 82);
            this.lblpaymentheading.TabIndex = 85;
            this.lblpaymentheading.Text = "Payment";
            // 
            // payTableAdapter
            // 
            this.payTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.lblpaymentheading);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.cmbselect);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.lblorderid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb9DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.ComboBox cmbselect;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.Label lblpaymentheading;
        private MyDb9DataSet2 myDb9DataSet2;
        private System.Windows.Forms.BindingSource payBindingSource;
        private MyDb9DataSet2TableAdapters.payTableAdapter payTableAdapter;
    }
}