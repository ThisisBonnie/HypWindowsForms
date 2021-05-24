namespace Hypno_Codes_Stuffs
{
    partial class Form1
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
            this.LByourheadspace = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBthoughts = new System.Windows.Forms.TextBox();
            this.RBcountdown = new System.Windows.Forms.RadioButton();
            this.RBcountup = new System.Windows.Forms.RadioButton();
            this.GBcountType = new System.Windows.Forms.GroupBox();
            this.Numsecondscount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumSecondsAwake = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBawakendown = new System.Windows.Forms.RadioButton();
            this.RBawakenup = new System.Windows.Forms.RadioButton();
            this.RBcount10 = new System.Windows.Forms.RadioButton();
            this.GBcountType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsecondscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecondsAwake)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LByourheadspace
            // 
            this.LByourheadspace.FormattingEnabled = true;
            this.LByourheadspace.Location = new System.Drawing.Point(12, 12);
            this.LByourheadspace.Name = "LByourheadspace";
            this.LByourheadspace.ScrollAlwaysVisible = true;
            this.LByourheadspace.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LByourheadspace.Size = new System.Drawing.Size(346, 511);
            this.LByourheadspace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thoughts to count away";
            // 
            // BTStart
            // 
            this.BTStart.Location = new System.Drawing.Point(367, 259);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(75, 23);
            this.BTStart.TabIndex = 3;
            this.BTStart.Text = "Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TBthoughts
            // 
            this.TBthoughts.Location = new System.Drawing.Point(367, 37);
            this.TBthoughts.Multiline = true;
            this.TBthoughts.Name = "TBthoughts";
            this.TBthoughts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBthoughts.Size = new System.Drawing.Size(194, 216);
            this.TBthoughts.TabIndex = 6;
            // 
            // RBcountdown
            // 
            this.RBcountdown.AutoSize = true;
            this.RBcountdown.Checked = true;
            this.RBcountdown.Location = new System.Drawing.Point(6, 19);
            this.RBcountdown.Name = "RBcountdown";
            this.RBcountdown.Size = new System.Drawing.Size(84, 17);
            this.RBcountdown.TabIndex = 7;
            this.RBcountdown.TabStop = true;
            this.RBcountdown.Text = "Count Down";
            this.RBcountdown.UseVisualStyleBackColor = true;
            // 
            // RBcountup
            // 
            this.RBcountup.AutoSize = true;
            this.RBcountup.Location = new System.Drawing.Point(6, 42);
            this.RBcountup.Name = "RBcountup";
            this.RBcountup.Size = new System.Drawing.Size(68, 17);
            this.RBcountup.TabIndex = 8;
            this.RBcountup.Text = "Count up";
            this.RBcountup.UseVisualStyleBackColor = true;
            // 
            // GBcountType
            // 
            this.GBcountType.Controls.Add(this.RBcountdown);
            this.GBcountType.Controls.Add(this.RBcountup);
            this.GBcountType.Location = new System.Drawing.Point(568, 38);
            this.GBcountType.Name = "GBcountType";
            this.GBcountType.Size = new System.Drawing.Size(140, 64);
            this.GBcountType.TabIndex = 9;
            this.GBcountType.TabStop = false;
            this.GBcountType.Text = "Drop count direction";
            // 
            // Numsecondscount
            // 
            this.Numsecondscount.Location = new System.Drawing.Point(568, 212);
            this.Numsecondscount.Name = "Numsecondscount";
            this.Numsecondscount.Size = new System.Drawing.Size(120, 20);
            this.Numsecondscount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Secounds between counting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seconds before awakening";
            // 
            // NumSecondsAwake
            // 
            this.NumSecondsAwake.Location = new System.Drawing.Point(568, 256);
            this.NumSecondsAwake.Name = "NumSecondsAwake";
            this.NumSecondsAwake.Size = new System.Drawing.Size(120, 20);
            this.NumSecondsAwake.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBcount10);
            this.groupBox1.Controls.Add(this.RBawakendown);
            this.groupBox1.Controls.Add(this.RBawakenup);
            this.groupBox1.Location = new System.Drawing.Point(569, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Awaken count direction";
            // 
            // RBawakendown
            // 
            this.RBawakendown.AutoSize = true;
            this.RBawakendown.Location = new System.Drawing.Point(6, 19);
            this.RBawakendown.Name = "RBawakendown";
            this.RBawakendown.Size = new System.Drawing.Size(84, 17);
            this.RBawakendown.TabIndex = 7;
            this.RBawakendown.Text = "Count Down";
            this.RBawakendown.UseVisualStyleBackColor = true;
            // 
            // RBawakenup
            // 
            this.RBawakenup.AutoSize = true;
            this.RBawakenup.Checked = true;
            this.RBawakenup.Location = new System.Drawing.Point(5, 42);
            this.RBawakenup.Name = "RBawakenup";
            this.RBawakenup.Size = new System.Drawing.Size(68, 17);
            this.RBawakenup.TabIndex = 8;
            this.RBawakenup.TabStop = true;
            this.RBawakenup.Text = "Count up";
            this.RBawakenup.UseVisualStyleBackColor = true;
            // 
            // RBcount10
            // 
            this.RBcount10.AutoSize = true;
            this.RBcount10.Location = new System.Drawing.Point(5, 65);
            this.RBcount10.Name = "RBcount10";
            this.RBcount10.Size = new System.Drawing.Size(95, 17);
            this.RBcount10.TabIndex = 9;
            this.RBcount10.Text = "Count up to 10";
            this.RBcount10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumSecondsAwake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numsecondscount);
            this.Controls.Add(this.GBcountType);
            this.Controls.Add(this.TBthoughts);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LByourheadspace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBcountType.ResumeLayout(false);
            this.GBcountType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsecondscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecondsAwake)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LByourheadspace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TBthoughts;
        private System.Windows.Forms.RadioButton RBcountdown;
        private System.Windows.Forms.RadioButton RBcountup;
        private System.Windows.Forms.GroupBox GBcountType;
        private System.Windows.Forms.NumericUpDown Numsecondscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumSecondsAwake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBawakendown;
        private System.Windows.Forms.RadioButton RBawakenup;
        private System.Windows.Forms.RadioButton RBcount10;
    }
}

