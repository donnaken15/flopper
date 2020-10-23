namespace FLOPPER_ui
{
    partial class selectOp
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
            this.list_ops = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_ops
            // 
            this.list_ops.FormattingEnabled = true;
            this.list_ops.Items.AddRange(new object[] {
            "Nothing",
            "Addition",
            "Subtraction",
            "Multiply",
            "Divide",
            "Power",
            "Print",
            "Round",
            "Floor",
            "√",
            "Sin",
            "Cos",
            "Tan",
            "Ln",
            "Log"});
            this.list_ops.Location = new System.Drawing.Point(12, 12);
            this.list_ops.Name = "list_ops";
            this.list_ops.Size = new System.Drawing.Size(205, 108);
            this.list_ops.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.choose);
            // 
            // selectOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_ops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "selectOp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Operation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cancel);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_ops;
        private System.Windows.Forms.Button button1;
    }
}