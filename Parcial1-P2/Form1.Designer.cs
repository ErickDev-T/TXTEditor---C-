﻿namespace Parcial1_P2
{
    partial class textedit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            safeToolStripMenuItem = new ToolStripMenuItem();
            MenuExit = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            MenuFormatBold = new ToolStripMenuItem();
            MenuFormatItalic = new ToolStripMenuItem();
            MenuFormatUnderline = new ToolStripMenuItem();
            MenuFormatSize = new ToolStripMenuItem();
            MenuSmallSize = new ToolStripMenuItem();
            MenuMediunSize = new ToolStripMenuItem();
            MenuLargeSize = new ToolStripMenuItem();
            safeTXT = new SaveFileDialog();
            txtEditor = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "OpenTXT";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog1.Title = "Open File";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, safeToolStripMenuItem, MenuExit });
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new Size(37, 20);
            MenuFile.Text = "&File";
            MenuFile.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += MenuOpenClick;
            // 
            // safeToolStripMenuItem
            // 
            safeToolStripMenuItem.Name = "safeToolStripMenuItem";
            safeToolStripMenuItem.Size = new Size(103, 22);
            safeToolStripMenuItem.Text = "&Safe";
            safeToolStripMenuItem.Click += MenuSafeClick;
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(103, 22);
            MenuExit.Text = "&Exit";
            MenuExit.Click += MenuExit_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuFormatBold, MenuFormatItalic, MenuFormatUnderline, MenuFormatSize });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "&Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // MenuFormatBold
            // 
            MenuFormatBold.Name = "MenuFormatBold";
            MenuFormatBold.Size = new Size(180, 22);
            MenuFormatBold.Text = "&Bold";
            MenuFormatBold.Click += MenuFormatBold_Click;
            // 
            // MenuFormatItalic
            // 
            MenuFormatItalic.Name = "MenuFormatItalic";
            MenuFormatItalic.Size = new Size(180, 22);
            MenuFormatItalic.Text = "&Italic";
            MenuFormatItalic.Click += MenuFormatItalic_Click;
            // 
            // MenuFormatUnderline
            // 
            MenuFormatUnderline.Name = "MenuFormatUnderline";
            MenuFormatUnderline.Size = new Size(180, 22);
            MenuFormatUnderline.Text = "&Underline";
            MenuFormatUnderline.Click += MenuFormatUnderline_Click;
            // 
            // MenuFormatSize
            // 
            MenuFormatSize.DropDownItems.AddRange(new ToolStripItem[] { MenuSmallSize, MenuMediunSize, MenuLargeSize });
            MenuFormatSize.Name = "MenuFormatSize";
            MenuFormatSize.Size = new Size(180, 22);
            MenuFormatSize.Text = "&Size";
            MenuFormatSize.Click += MenuFormatSize_Click;
            // 
            // MenuSmallSize
            // 
            MenuSmallSize.Checked = true;
            MenuSmallSize.CheckState = CheckState.Checked;
            MenuSmallSize.Name = "MenuSmallSize";
            MenuSmallSize.Size = new Size(180, 22);
            MenuSmallSize.Text = "&Small";
            MenuSmallSize.Click += MenuFormatSize_Click;
            // 
            // MenuMediunSize
            // 
            MenuMediunSize.Name = "MenuMediunSize";
            MenuMediunSize.Size = new Size(180, 22);
            MenuMediunSize.Text = "&Mediun";
            MenuMediunSize.Click += MenuFormatSize_Click;
            // 
            // MenuLargeSize
            // 
            MenuLargeSize.Name = "MenuLargeSize";
            MenuLargeSize.Size = new Size(180, 22);
            MenuLargeSize.Text = "&Large";
            MenuLargeSize.Click += MenuFormatSize_Click;
            // 
            // safeTXT
            // 
            safeTXT.Filter = "Text Files(*.txt)|*.txt";
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(12, 27);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Vertical;
            txtEditor.Size = new Size(360, 240);
            txtEditor.TabIndex = 10;
            txtEditor.TextChanged += textBox1_TextChanged;
            // 
            // textedit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 283);
            Controls.Add(txtEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "textedit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            FormClosing += Editor_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem formatToolStripMenuItem;
        private SaveFileDialog safeTXT;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem safeToolStripMenuItem;
        private ToolStripMenuItem MenuExit;
        private TextBox txtEditor;
        private ToolStripMenuItem MenuFormatBold;
        private ToolStripMenuItem MenuFormatItalic;
        private ToolStripMenuItem MenuFormatUnderline;
        private ToolStripMenuItem MenuFormatSize;
        private ToolStripMenuItem MenuSmallSize;
        private ToolStripMenuItem MenuMediunSize;
        private ToolStripMenuItem MenuLargeSize;
        private ToolStripMenuItem newToolStripMenuItem;
    }
}