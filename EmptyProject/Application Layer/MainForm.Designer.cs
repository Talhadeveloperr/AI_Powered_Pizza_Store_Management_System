namespace EmptyProject.Application_Layer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPizzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderpizzaMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.getbillMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedetailMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.aIAssistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPizzaToolStripMenuItem1,
            this.orderpizzaMenuItem1,
            this.paymentMenuItem2,
            this.feedbackMenuItem3,
            this.customerMenuItem4,
            this.getbillMenuItem5,
            this.deletedetailMenuItem6,
            this.aIAssistanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1878, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPizzaToolStripMenuItem1
            // 
            this.addPizzaToolStripMenuItem1.Name = "addPizzaToolStripMenuItem1";
            this.addPizzaToolStripMenuItem1.Size = new System.Drawing.Size(121, 34);
            this.addPizzaToolStripMenuItem1.Text = "Add Pizza";
            this.addPizzaToolStripMenuItem1.Click += new System.EventHandler(this.addPizzaToolStripMenuItem1_Click);
            // 
            // orderpizzaMenuItem1
            // 
            this.orderpizzaMenuItem1.Name = "orderpizzaMenuItem1";
            this.orderpizzaMenuItem1.Size = new System.Drawing.Size(136, 34);
            this.orderpizzaMenuItem1.Text = "Order Pizza";
            this.orderpizzaMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // paymentMenuItem2
            // 
            this.paymentMenuItem2.Name = "paymentMenuItem2";
            this.paymentMenuItem2.Size = new System.Drawing.Size(109, 34);
            this.paymentMenuItem2.Text = "Payment";
            this.paymentMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // feedbackMenuItem3
            // 
            this.feedbackMenuItem3.Name = "feedbackMenuItem3";
            this.feedbackMenuItem3.Size = new System.Drawing.Size(116, 34);
            this.feedbackMenuItem3.Text = "Feedback";
            this.feedbackMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // customerMenuItem4
            // 
            this.customerMenuItem4.Name = "customerMenuItem4";
            this.customerMenuItem4.Size = new System.Drawing.Size(118, 34);
            this.customerMenuItem4.Text = "Customer";
            this.customerMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // getbillMenuItem5
            // 
            this.getbillMenuItem5.Name = "getbillMenuItem5";
            this.getbillMenuItem5.Size = new System.Drawing.Size(94, 34);
            this.getbillMenuItem5.Text = "Get Bill";
            this.getbillMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // deletedetailMenuItem6
            // 
            this.deletedetailMenuItem6.Name = "deletedetailMenuItem6";
            this.deletedetailMenuItem6.Size = new System.Drawing.Size(149, 34);
            this.deletedetailMenuItem6.Text = "Delete Detail";
            this.deletedetailMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // aIAssistanceToolStripMenuItem
            // 
            this.aIAssistanceToolStripMenuItem.Name = "aIAssistanceToolStripMenuItem";
            this.aIAssistanceToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
            this.aIAssistanceToolStripMenuItem.Text = "AI Assistance";
            this.aIAssistanceToolStripMenuItem.Click += new System.EventHandler(this.aIAssistanceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1878, 1044);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPizzaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderpizzaMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paymentMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem feedbackMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem getbillMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deletedetailMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem aIAssistanceToolStripMenuItem;
    }
}