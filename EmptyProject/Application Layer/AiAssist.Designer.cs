namespace EmptyProject.Application_Layer
{
    partial class AiAssist
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
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.lblprompt = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblresponse = new System.Windows.Forms.Label();
            this.btnclearprompt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrompt
            // 
            this.txtPrompt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrompt.Location = new System.Drawing.Point(528, 176);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(582, 88);
            this.txtPrompt.TabIndex = 1;
            this.txtPrompt.TextChanged += new System.EventHandler(this.txtPrompt_TextChanged);
            // 
            // lblprompt
            // 
            this.lblprompt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblprompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprompt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblprompt.Location = new System.Drawing.Point(523, 86);
            this.lblprompt.Name = "lblprompt";
            this.lblprompt.Size = new System.Drawing.Size(208, 45);
            this.lblprompt.TabIndex = 1;
            this.lblprompt.Text = "Ask Your Query:";
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(1002, 290);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(108, 52);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblresponse
            // 
            this.lblresponse.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresponse.Location = new System.Drawing.Point(523, 378);
            this.lblresponse.Name = "lblresponse";
            this.lblresponse.Size = new System.Drawing.Size(587, 292);
            this.lblresponse.TabIndex = 3;
            this.lblresponse.Click += new System.EventHandler(this.lblresponse_Click);
            // 
            // btnclearprompt
            // 
            this.btnclearprompt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnclearprompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearprompt.Location = new System.Drawing.Point(860, 290);
            this.btnclearprompt.Name = "btnclearprompt";
            this.btnclearprompt.Size = new System.Drawing.Size(90, 52);
            this.btnclearprompt.TabIndex = 4;
            this.btnclearprompt.Text = "Clear";
            this.btnclearprompt.UseVisualStyleBackColor = false;
            this.btnclearprompt.Click += new System.EventHandler(this.btnclearprompt_Click);
            // 
            // AiAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1562, 749);
            this.Controls.Add(this.btnclearprompt);
            this.Controls.Add(this.lblresponse);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblprompt);
            this.Controls.Add(this.txtPrompt);
            this.Name = "AiAssist";
            this.Text = "aiAssist";
            this.Load += new System.EventHandler(this.AiAssist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label lblprompt;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblresponse;
        private System.Windows.Forms.Button btnclearprompt;
    }
}