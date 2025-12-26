namespace EmptyProject.Application_Layer
{
    partial class FeedbackForm
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtfeedback = new System.Windows.Forms.TextBox();
            this.lblfeedbackheading = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancel.Location = new System.Drawing.Point(934, 690);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(181, 79);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Black;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(709, 690);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(181, 79);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfeedback
            // 
            this.txtfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeedback.Location = new System.Drawing.Point(893, 392);
            this.txtfeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfeedback.Multiline = true;
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(345, 183);
            this.txtfeedback.TabIndex = 2;
            // 
            // lblfeedbackheading
            // 
            this.lblfeedbackheading.AutoSize = true;
            this.lblfeedbackheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedbackheading.ForeColor = System.Drawing.Color.Red;
            this.lblfeedbackheading.Location = new System.Drawing.Point(768, 107);
            this.lblfeedbackheading.Name = "lblfeedbackheading";
            this.lblfeedbackheading.Size = new System.Drawing.Size(359, 82);
            this.lblfeedbackheading.TabIndex = 85;
            this.lblfeedbackheading.Text = "Feedback";
            this.lblfeedbackheading.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtcustname
            // 
            this.txtcustname.CausesValidation = false;
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(893, 265);
            this.txtcustname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(345, 39);
            this.txtcustname.TabIndex = 1;
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.BackColor = System.Drawing.Color.Transparent;
            this.lblcustname.CausesValidation = false;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Black;
            this.lblcustname.Location = new System.Drawing.Point(589, 265);
            this.lblcustname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(231, 32);
            this.lblcustname.TabIndex = 86;
            this.lblcustname.Text = "Customer Name";
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblfeedback.CausesValidation = false;
            this.lblfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.ForeColor = System.Drawing.Color.Black;
            this.lblfeedback.Location = new System.Drawing.Point(589, 392);
            this.lblfeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(147, 32);
            this.lblfeedback.TabIndex = 88;
            this.lblfeedback.Text = "Feedback";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.lblfeedback);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblfeedbackheading);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtfeedback);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FeedbackForm";
            this.Text = "FeddbackForm";
            this.Load += new System.EventHandler(this.FeddbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtfeedback;
        private System.Windows.Forms.Label lblfeedbackheading;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblfeedback;
    }
}