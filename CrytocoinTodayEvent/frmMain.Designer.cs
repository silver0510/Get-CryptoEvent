namespace CrytocoinTodayEvent
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnGetEvent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEvent = new System.Windows.Forms.RichTextBox();
            this.dtpCheckDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpCheckDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPageNumber);
            this.panel1.Controls.Add(this.btnGetEvent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL PAGE CHECK";
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(135, 6);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(114, 19);
            this.txtPageNumber.TabIndex = 1;
            // 
            // btnGetEvent
            // 
            this.btnGetEvent.Location = new System.Drawing.Point(289, 29);
            this.btnGetEvent.Name = "btnGetEvent";
            this.btnGetEvent.Size = new System.Drawing.Size(89, 23);
            this.btnGetEvent.TabIndex = 0;
            this.btnGetEvent.Text = "Get event";
            this.btnGetEvent.UseVisualStyleBackColor = true;
            this.btnGetEvent.Click += new System.EventHandler(this.btnGetEvent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 602);
            this.panel2.TabIndex = 0;
            // 
            // txtEvent
            // 
            this.txtEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvent.Location = new System.Drawing.Point(0, 0);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(498, 602);
            this.txtEvent.TabIndex = 0;
            this.txtEvent.Text = "";
            // 
            // dtpCheckDay
            // 
            this.dtpCheckDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckDay.Location = new System.Drawing.Point(135, 33);
            this.dtpCheckDay.Name = "dtpCheckDay";
            this.dtpCheckDay.Size = new System.Drawing.Size(114, 19);
            this.dtpCheckDay.TabIndex = 3;
            this.dtpCheckDay.Value = new System.DateTime(2018, 1, 24, 9, 23, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHECK DAY";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crytocoin Event";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.DateTimePicker dtpCheckDay;
        private System.Windows.Forms.Label label2;
    }
}

