namespace EmptyProject.Application_Layer
{
    partial class bill_Form
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
            this.lblshowbill = new System.Windows.Forms.Label();
            this.lblorderid = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.btngetbill = new System.Windows.Forms.Button();
            this.lblbillheading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblshowbill
            // 
            this.lblshowbill.AutoSize = true;
            this.lblshowbill.Font = new System.Drawing.Font("Cambria", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowbill.ForeColor = System.Drawing.Color.Black;
            this.lblshowbill.Location = new System.Drawing.Point(37, 73);
            this.lblshowbill.Name = "lblshowbill";
            this.lblshowbill.Size = new System.Drawing.Size(204, 52);
            this.lblshowbill.TabIndex = 62;
            this.lblshowbill.Text = "Show Bill";
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderid.Location = new System.Drawing.Point(1071, 280);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(144, 38);
            this.lblorderid.TabIndex = 66;
            this.lblorderid.Text = "Order Id";
            // 
            // txtorderid
            // 
            this.txtorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderid.Location = new System.Drawing.Point(1266, 273);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(354, 44);
            this.txtorderid.TabIndex = 1;
            // 
            // btngetbill
            // 
            this.btngetbill.BackColor = System.Drawing.Color.Black;
            this.btngetbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngetbill.Location = new System.Drawing.Point(1266, 374);
            this.btngetbill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngetbill.Name = "btngetbill";
            this.btngetbill.Size = new System.Drawing.Size(188, 70);
            this.btngetbill.TabIndex = 2;
            this.btngetbill.Text = "Get Bill";
            this.btngetbill.UseVisualStyleBackColor = false;
            this.btngetbill.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // lblbillheading
            // 
            this.lblbillheading.AutoSize = true;
            this.lblbillheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillheading.ForeColor = System.Drawing.Color.Red;
            this.lblbillheading.Location = new System.Drawing.Point(1186, 98);
            this.lblbillheading.Name = "lblbillheading";
            this.lblbillheading.Size = new System.Drawing.Size(342, 82);
            this.lblbillheading.TabIndex = 63;
            this.lblbillheading.Text = "Show Bill";
            // 
            // bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.lblorderid);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.btngetbill);
            this.Controls.Add(this.lblbillheading);
            this.Controls.Add(this.lblshowbill);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bill_Form";
            this.Text = "bill_Form";
            this.Load += new System.EventHandler(this.bill_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblshowbill;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Button btngetbill;
        private System.Windows.Forms.Label lblbillheading;
    }
}