namespace FLOPPER_ui
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flopout = new System.Windows.Forms.TextBox();
            this.list_floats = new System.Windows.Forms.ListBox();
            this.list_ops = new System.Windows.Forms.ListBox();
            this.panel_floats = new System.Windows.Forms.GroupBox();
            this.floats_pi = new System.Windows.Forms.Button();
            this.floats_rng = new System.Windows.Forms.Button();
            this.floats_rem = new System.Windows.Forms.Button();
            this.floats_add = new System.Windows.Forms.Button();
            this.panel_ops = new System.Windows.Forms.GroupBox();
            this.panel_src = new System.Windows.Forms.GroupBox();
            this.src_gpu = new System.Windows.Forms.RadioButton();
            this.src_cpu = new System.Windows.Forms.RadioButton();
            this.panel_profiles = new System.Windows.Forms.GroupBox();
            this.panel_control = new System.Windows.Forms.GroupBox();
            this.control_start = new System.Windows.Forms.Button();
            this.panel_opt = new System.Windows.Forms.GroupBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.panel_mode = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel_flopslist = new System.Windows.Forms.SplitContainer();
            this.ops_add = new System.Windows.Forms.Button();
            this.ops_rem = new System.Windows.Forms.Button();
            this.ops_rand = new System.Windows.Forms.Button();
            this.panel_floats.SuspendLayout();
            this.panel_ops.SuspendLayout();
            this.panel_src.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.panel_opt.SuspendLayout();
            this.panel_mode.SuspendLayout();
            this.panel_flopslist.Panel1.SuspendLayout();
            this.panel_flopslist.Panel2.SuspendLayout();
            this.panel_flopslist.SuspendLayout();
            this.SuspendLayout();
            // 
            // flopout
            // 
            this.flopout.BackColor = System.Drawing.SystemColors.Window;
            this.flopout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.flopout.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flopout.Location = new System.Drawing.Point(321, 64);
            this.flopout.Multiline = true;
            this.flopout.Name = "flopout";
            this.flopout.ReadOnly = true;
            this.flopout.Size = new System.Drawing.Size(297, 300);
            this.flopout.TabIndex = 0;
            this.flopout.Text = "Welcome to FLOPPER!";
            // 
            // list_floats
            // 
            this.list_floats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_floats.FormattingEnabled = true;
            this.list_floats.IntegralHeight = false;
            this.list_floats.Location = new System.Drawing.Point(6, 19);
            this.list_floats.Name = "list_floats";
            this.list_floats.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_floats.Size = new System.Drawing.Size(120, 123);
            this.list_floats.TabIndex = 1;
            // 
            // list_ops
            // 
            this.list_ops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_ops.FormattingEnabled = true;
            this.list_ops.IntegralHeight = false;
            this.list_ops.Location = new System.Drawing.Point(6, 19);
            this.list_ops.Name = "list_ops";
            this.list_ops.Size = new System.Drawing.Size(120, 123);
            this.list_ops.TabIndex = 2;
            // 
            // panel_floats
            // 
            this.panel_floats.Controls.Add(this.floats_pi);
            this.panel_floats.Controls.Add(this.floats_rng);
            this.panel_floats.Controls.Add(this.floats_rem);
            this.panel_floats.Controls.Add(this.floats_add);
            this.panel_floats.Controls.Add(this.list_floats);
            this.panel_floats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_floats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panel_floats.Location = new System.Drawing.Point(0, 0);
            this.panel_floats.Name = "panel_floats";
            this.panel_floats.Size = new System.Drawing.Size(153, 148);
            this.panel_floats.TabIndex = 3;
            this.panel_floats.TabStop = false;
            this.panel_floats.Text = "Floats";
            // 
            // floats_pi
            // 
            this.floats_pi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.floats_pi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.floats_pi.Location = new System.Drawing.Point(131, 113);
            this.floats_pi.Name = "floats_pi";
            this.floats_pi.Size = new System.Drawing.Size(15, 23);
            this.floats_pi.TabIndex = 5;
            this.floats_pi.Text = "π";
            this.floats_pi.UseVisualStyleBackColor = true;
            // 
            // floats_rng
            // 
            this.floats_rng.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.floats_rng.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.floats_rng.Location = new System.Drawing.Point(131, 84);
            this.floats_rng.Name = "floats_rng";
            this.floats_rng.Size = new System.Drawing.Size(15, 23);
            this.floats_rng.TabIndex = 4;
            this.floats_rng.Text = "R";
            this.floats_rng.UseVisualStyleBackColor = true;
            // 
            // floats_rem
            // 
            this.floats_rem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.floats_rem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.floats_rem.Location = new System.Drawing.Point(131, 54);
            this.floats_rem.Name = "floats_rem";
            this.floats_rem.Size = new System.Drawing.Size(15, 23);
            this.floats_rem.TabIndex = 3;
            this.floats_rem.Text = "-";
            this.floats_rem.UseVisualStyleBackColor = true;
            // 
            // floats_add
            // 
            this.floats_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.floats_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.floats_add.Location = new System.Drawing.Point(131, 24);
            this.floats_add.Name = "floats_add";
            this.floats_add.Size = new System.Drawing.Size(15, 23);
            this.floats_add.TabIndex = 2;
            this.floats_add.Text = "+";
            this.floats_add.UseVisualStyleBackColor = true;
            // 
            // panel_ops
            // 
            this.panel_ops.Controls.Add(this.ops_rand);
            this.panel_ops.Controls.Add(this.ops_rem);
            this.panel_ops.Controls.Add(this.ops_add);
            this.panel_ops.Controls.Add(this.list_ops);
            this.panel_ops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ops.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panel_ops.Location = new System.Drawing.Point(0, 0);
            this.panel_ops.Name = "panel_ops";
            this.panel_ops.Size = new System.Drawing.Size(153, 148);
            this.panel_ops.TabIndex = 4;
            this.panel_ops.TabStop = false;
            this.panel_ops.Text = "Operations";
            // 
            // panel_src
            // 
            this.panel_src.Controls.Add(this.src_gpu);
            this.panel_src.Controls.Add(this.src_cpu);
            this.panel_src.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panel_src.Location = new System.Drawing.Point(12, 13);
            this.panel_src.Name = "panel_src";
            this.panel_src.Size = new System.Drawing.Size(97, 43);
            this.panel_src.TabIndex = 5;
            this.panel_src.TabStop = false;
            this.panel_src.Text = "Device";
            // 
            // src_gpu
            // 
            this.src_gpu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.src_gpu.Location = new System.Drawing.Point(49, 16);
            this.src_gpu.Name = "src_gpu";
            this.src_gpu.Size = new System.Drawing.Size(44, 24);
            this.src_gpu.TabIndex = 1;
            this.src_gpu.TabStop = true;
            this.src_gpu.Text = "GPU";
            this.src_gpu.UseVisualStyleBackColor = true;
            // 
            // src_cpu
            // 
            this.src_cpu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.src_cpu.Location = new System.Drawing.Point(5, 16);
            this.src_cpu.Name = "src_cpu";
            this.src_cpu.Size = new System.Drawing.Size(44, 24);
            this.src_cpu.TabIndex = 0;
            this.src_cpu.TabStop = true;
            this.src_cpu.Text = "CPU";
            this.src_cpu.UseVisualStyleBackColor = true;
            // 
            // panel_profiles
            // 
            this.panel_profiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panel_profiles.Location = new System.Drawing.Point(115, 12);
            this.panel_profiles.Name = "panel_profiles";
            this.panel_profiles.Size = new System.Drawing.Size(503, 44);
            this.panel_profiles.TabIndex = 6;
            this.panel_profiles.TabStop = false;
            this.panel_profiles.Text = "Presets";
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.control_start);
            this.panel_control.Location = new System.Drawing.Point(171, 314);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(144, 50);
            this.panel_control.TabIndex = 7;
            this.panel_control.TabStop = false;
            this.panel_control.Text = "Control";
            // 
            // control_start
            // 
            this.control_start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.control_start.Location = new System.Drawing.Point(6, 19);
            this.control_start.Name = "control_start";
            this.control_start.Size = new System.Drawing.Size(39, 23);
            this.control_start.TabIndex = 0;
            this.control_start.Text = "Start";
            this.control_start.UseVisualStyleBackColor = true;
            // 
            // panel_opt
            // 
            this.panel_opt.Controls.Add(this.label_mode);
            this.panel_opt.Controls.Add(this.panel_mode);
            this.panel_opt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panel_opt.Location = new System.Drawing.Point(171, 63);
            this.panel_opt.Name = "panel_opt";
            this.panel_opt.Size = new System.Drawing.Size(144, 245);
            this.panel_opt.TabIndex = 8;
            this.panel_opt.TabStop = false;
            this.panel_opt.Text = "Settings";
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Location = new System.Drawing.Point(3, 16);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(37, 13);
            this.label_mode.TabIndex = 1;
            this.label_mode.Text = "Mode:";
            // 
            // panel_mode
            // 
            this.panel_mode.Controls.Add(this.radioButton2);
            this.panel_mode.Controls.Add(this.radioButton1);
            this.panel_mode.Location = new System.Drawing.Point(14, 32);
            this.panel_mode.Name = "panel_mode";
            this.panel_mode.Size = new System.Drawing.Size(124, 22);
            this.panel_mode.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(69, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Count";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Interval";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel_flopslist
            // 
            this.panel_flopslist.Location = new System.Drawing.Point(12, 64);
            this.panel_flopslist.Name = "panel_flopslist";
            this.panel_flopslist.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panel_flopslist.Panel1
            // 
            this.panel_flopslist.Panel1.Controls.Add(this.panel_floats);
            // 
            // panel_flopslist.Panel2
            // 
            this.panel_flopslist.Panel2.Controls.Add(this.panel_ops);
            this.panel_flopslist.Size = new System.Drawing.Size(153, 300);
            this.panel_flopslist.SplitterDistance = 148;
            this.panel_flopslist.TabIndex = 9;
            // 
            // ops_add
            // 
            this.ops_add.Location = new System.Drawing.Point(131, 19);
            this.ops_add.Name = "ops_add";
            this.ops_add.Size = new System.Drawing.Size(14, 23);
            this.ops_add.TabIndex = 3;
            this.ops_add.Text = "+";
            this.ops_add.UseVisualStyleBackColor = true;
            this.ops_add.Click += new System.EventHandler(this.ops_add_Click);
            // 
            // ops_rem
            // 
            this.ops_rem.Location = new System.Drawing.Point(131, 49);
            this.ops_rem.Name = "ops_rem";
            this.ops_rem.Size = new System.Drawing.Size(15, 23);
            this.ops_rem.TabIndex = 4;
            this.ops_rem.Text = "-";
            this.ops_rem.UseVisualStyleBackColor = true;
            // 
            // ops_rand
            // 
            this.ops_rand.Location = new System.Drawing.Point(131, 77);
            this.ops_rand.Name = "ops_rand";
            this.ops_rand.Size = new System.Drawing.Size(14, 23);
            this.ops_rand.TabIndex = 5;
            this.ops_rand.Text = "R";
            this.ops_rand.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.panel_flopslist);
            this.Controls.Add(this.panel_opt);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.panel_profiles);
            this.Controls.Add(this.panel_src);
            this.Controls.Add(this.flopout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLOPPER";
            this.panel_floats.ResumeLayout(false);
            this.panel_ops.ResumeLayout(false);
            this.panel_src.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_opt.ResumeLayout(false);
            this.panel_opt.PerformLayout();
            this.panel_mode.ResumeLayout(false);
            this.panel_mode.PerformLayout();
            this.panel_flopslist.Panel1.ResumeLayout(false);
            this.panel_flopslist.Panel2.ResumeLayout(false);
            this.panel_flopslist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flopout;
        private System.Windows.Forms.ListBox list_floats;
        private System.Windows.Forms.ListBox list_ops;
        private System.Windows.Forms.GroupBox panel_floats;
        private System.Windows.Forms.GroupBox panel_ops;
        private System.Windows.Forms.GroupBox panel_src;
        private System.Windows.Forms.RadioButton src_gpu;
        private System.Windows.Forms.RadioButton src_cpu;
        private System.Windows.Forms.GroupBox panel_profiles;
        private System.Windows.Forms.GroupBox panel_control;
        private System.Windows.Forms.Button control_start;
        private System.Windows.Forms.GroupBox panel_opt;
        private System.Windows.Forms.Button floats_add;
        private System.Windows.Forms.Button floats_rng;
        private System.Windows.Forms.Button floats_rem;
        private System.Windows.Forms.Button floats_pi;
        private System.Windows.Forms.SplitContainer panel_flopslist;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Panel panel_mode;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ops_rand;
        private System.Windows.Forms.Button ops_rem;
        private System.Windows.Forms.Button ops_add;
    }
}