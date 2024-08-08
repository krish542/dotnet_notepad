namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.save_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cut_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.format_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrap_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.font_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.view_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomin_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomout_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.defzoom_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.statbar_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.edit_menu,
            this.format_menu,
            this.view_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_menu,
            this.open_menu,
            this.toolStripSeparator3,
            this.save_menu,
            this.toolStripSeparator2,
            this.exit_menu});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(46, 24);
            this.file_menu.Text = "File";
            // 
            // new_menu
            // 
            this.new_menu.Name = "new_menu";
            this.new_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_menu.Size = new System.Drawing.Size(181, 26);
            this.new_menu.Text = "New";
            this.new_menu.Click += new System.EventHandler(this.new_menu_Click);
            // 
            // open_menu
            // 
            this.open_menu.Name = "open_menu";
            this.open_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_menu.Size = new System.Drawing.Size(181, 26);
            this.open_menu.Text = "Open";
            this.open_menu.Click += new System.EventHandler(this.open_menu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // save_menu
            // 
            this.save_menu.Name = "save_menu";
            this.save_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_menu.Size = new System.Drawing.Size(181, 26);
            this.save_menu.Text = "Save";
            this.save_menu.Click += new System.EventHandler(this.save_menu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // exit_menu
            // 
            this.exit_menu.Name = "exit_menu";
            this.exit_menu.Size = new System.Drawing.Size(181, 26);
            this.exit_menu.Text = "Exit";
            this.exit_menu.Click += new System.EventHandler(this.exit_menu_Click);
            // 
            // edit_menu
            // 
            this.edit_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo_menu,
            this.toolStripSeparator1,
            this.cut_menu,
            this.copy_menu,
            this.paste_menu,
            this.delete_menu,
            this.dateTimeToolStripMenuItem});
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.edit_menu.ShowShortcutKeys = false;
            this.edit_menu.Size = new System.Drawing.Size(49, 24);
            this.edit_menu.Text = "Edit";
            // 
            // undo_menu
            // 
            this.undo_menu.Name = "undo_menu";
            this.undo_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo_menu.Size = new System.Drawing.Size(184, 26);
            this.undo_menu.Text = "Undo";
            this.undo_menu.Click += new System.EventHandler(this.undo_menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // cut_menu
            // 
            this.cut_menu.Name = "cut_menu";
            this.cut_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut_menu.Size = new System.Drawing.Size(184, 26);
            this.cut_menu.Text = "Cut";
            this.cut_menu.Click += new System.EventHandler(this.cut_menu_Click);
            // 
            // copy_menu
            // 
            this.copy_menu.Name = "copy_menu";
            this.copy_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy_menu.Size = new System.Drawing.Size(184, 26);
            this.copy_menu.Text = "Copy";
            this.copy_menu.Click += new System.EventHandler(this.copy_menu_Click);
            // 
            // paste_menu
            // 
            this.paste_menu.Name = "paste_menu";
            this.paste_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste_menu.Size = new System.Drawing.Size(184, 26);
            this.paste_menu.Text = "Paste";
            this.paste_menu.Click += new System.EventHandler(this.paste_menu_Click);
            // 
            // delete_menu
            // 
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete_menu.Size = new System.Drawing.Size(184, 26);
            this.delete_menu.Text = "Delete";
            this.delete_menu.Click += new System.EventHandler(this.delete_menu_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.dateTimeToolStripMenuItem.Text = "Date/time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // format_menu
            // 
            this.format_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordwrap_menu,
            this.font_menu});
            this.format_menu.Name = "format_menu";
            this.format_menu.Size = new System.Drawing.Size(70, 24);
            this.format_menu.Text = "Format";
            // 
            // wordwrap_menu
            // 
            this.wordwrap_menu.Checked = true;
            this.wordwrap_menu.CheckOnClick = true;
            this.wordwrap_menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordwrap_menu.Name = "wordwrap_menu";
            this.wordwrap_menu.Size = new System.Drawing.Size(168, 26);
            this.wordwrap_menu.Text = "Word Wrap";
            this.wordwrap_menu.Click += new System.EventHandler(this.wordwrap_menu_Click);
            // 
            // font_menu
            // 
            this.font_menu.Name = "font_menu";
            this.font_menu.Size = new System.Drawing.Size(168, 26);
            this.font_menu.Text = "Font";
            this.font_menu.Click += new System.EventHandler(this.font_menu_Click);
            // 
            // view_menu
            // 
            this.view_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom_menu,
            this.statbar_menu});
            this.view_menu.Name = "view_menu";
            this.view_menu.Size = new System.Drawing.Size(55, 24);
            this.view_menu.Text = "View";
            // 
            // zoom_menu
            // 
            this.zoom_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomin_menu,
            this.zoomout_menu,
            this.defzoom_menu});
            this.zoom_menu.Name = "zoom_menu";
            this.zoom_menu.Size = new System.Drawing.Size(158, 26);
            this.zoom_menu.Text = "Zoom";
            // 
            // zoomin_menu
            // 
            this.zoomin_menu.Name = "zoomin_menu";
            this.zoomin_menu.Size = new System.Drawing.Size(243, 26);
            this.zoomin_menu.Text = "Zoom In";
            this.zoomin_menu.Click += new System.EventHandler(this.zoomin_menu_Click);
            // 
            // zoomout_menu
            // 
            this.zoomout_menu.Name = "zoomout_menu";
            this.zoomout_menu.Size = new System.Drawing.Size(243, 26);
            this.zoomout_menu.Text = "Zoom out";
            this.zoomout_menu.Click += new System.EventHandler(this.zoomout_menu_Click);
            // 
            // defzoom_menu
            // 
            this.defzoom_menu.Name = "defzoom_menu";
            this.defzoom_menu.Size = new System.Drawing.Size(243, 26);
            this.defzoom_menu.Text = " Restore Default Zoom";
            this.defzoom_menu.Click += new System.EventHandler(this.defzoom_menu_Click);
            // 
            // statbar_menu
            // 
            this.statbar_menu.Checked = true;
            this.statbar_menu.CheckOnClick = true;
            this.statbar_menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statbar_menu.Name = "statbar_menu";
            this.statbar_menu.Size = new System.Drawing.Size(158, 26);
            this.statbar_menu.Text = "Status bar";
            this.statbar_menu.Click += new System.EventHandler(this.statbar_menu_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem new_menu;
        private System.Windows.Forms.ToolStripMenuItem open_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem save_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_menu;
        private System.Windows.Forms.ToolStripMenuItem undo_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cut_menu;
        private System.Windows.Forms.ToolStripMenuItem copy_menu;
        private System.Windows.Forms.ToolStripMenuItem paste_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem format_menu;
        private System.Windows.Forms.ToolStripMenuItem wordwrap_menu;
        private System.Windows.Forms.ToolStripMenuItem font_menu;
        private System.Windows.Forms.ToolStripMenuItem view_menu;
        private System.Windows.Forms.ToolStripMenuItem zoom_menu;
        private System.Windows.Forms.ToolStripMenuItem zoomin_menu;
        private System.Windows.Forms.ToolStripMenuItem zoomout_menu;
        private System.Windows.Forms.ToolStripMenuItem defzoom_menu;
        private System.Windows.Forms.ToolStripMenuItem statbar_menu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

