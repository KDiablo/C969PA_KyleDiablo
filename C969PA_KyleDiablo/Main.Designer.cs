
namespace C969PA_KyleDiablo
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.monthTab = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.weekTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.monthTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.monthTab);
            this.tabControl1.Controls.Add(this.weekTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // monthTab
            // 
            this.monthTab.Controls.Add(this.monthCalendar1);
            this.monthTab.Location = new System.Drawing.Point(4, 22);
            this.monthTab.Name = "monthTab";
            this.monthTab.Padding = new System.Windows.Forms.Padding(3);
            this.monthTab.Size = new System.Drawing.Size(656, 503);
            this.monthTab.TabIndex = 0;
            this.monthTab.Text = "Month View";
            this.monthTab.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // weekTab
            // 
            this.weekTab.Location = new System.Drawing.Point(4, 22);
            this.weekTab.Name = "weekTab";
            this.weekTab.Padding = new System.Windows.Forms.Padding(3);
            this.weekTab.Size = new System.Drawing.Size(656, 503);
            this.weekTab.TabIndex = 1;
            this.weekTab.Text = "Week Tab";
            this.weekTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.appointmentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUsersToolStripMenuItem,
            this.editDeleteCustomerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "Customers";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addUsersToolStripMenuItem.Text = "Add Customer";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // editDeleteCustomerToolStripMenuItem
            // 
            this.editDeleteCustomerToolStripMenuItem.Name = "editDeleteCustomerToolStripMenuItem";
            this.editDeleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editDeleteCustomerToolStripMenuItem.Text = "Edit/Delete Customer";
            this.editDeleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.editDeleteCustomerToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmetToolStripMenuItem,
            this.editAppointmentToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // addAppointmetToolStripMenuItem
            // 
            this.addAppointmetToolStripMenuItem.Name = "addAppointmetToolStripMenuItem";
            this.addAppointmetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addAppointmetToolStripMenuItem.Text = "Add Appointmet";
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editAppointmentToolStripMenuItem.Text = "Edit Appointment";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.monthTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage monthTab;
        private System.Windows.Forms.TabPage weekTab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
    }
}