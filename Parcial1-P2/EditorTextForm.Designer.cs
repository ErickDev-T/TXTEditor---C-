namespace Parcial1_P2
{
    partial class EditorTextForm
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
            dlgOpenTXT = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            dlgOpen = new ToolStripMenuItem();
            dlgSafe = new ToolStripMenuItem();
            MenuExit = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            MenuFormatBold = new ToolStripMenuItem();
            MenuFormatItalic = new ToolStripMenuItem();
            MenuFormatUnderline = new ToolStripMenuItem();
            MenuFormatSize = new ToolStripMenuItem();
            MenuSmallSize = new ToolStripMenuItem();
            MenuMediunSize = new ToolStripMenuItem();
            MenuLargeSize = new ToolStripMenuItem();
            dlgsafeTXT = new SaveFileDialog();
            txtEditor = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dlgOpenTXT
            // 
            dlgOpenTXT.FileName = "TxtOpen";
            dlgOpenTXT.Filter = "Text Files(*.txt)|*.txt";
            dlgOpenTXT.Title = "Open File";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(575, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, dlgOpen, dlgSafe, MenuExit });
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
            // dlgOpen
            // 
            dlgOpen.Name = "dlgOpen";
            dlgOpen.Size = new Size(103, 22);
            dlgOpen.Text = "&Open";
            dlgOpen.Click += MenuOpen_Click;
            // 
            // dlgSafe
            // 
            dlgSafe.Name = "dlgSafe";
            dlgSafe.Size = new Size(103, 22);
            dlgSafe.Text = "&Safe";
            dlgSafe.Click += MenuSafeClick;
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
            MenuFormatBold.Size = new Size(125, 22);
            MenuFormatBold.Text = "&Bold";
            MenuFormatBold.Click += MenuFormatBold_Click;
            // 
            // MenuFormatItalic
            // 
            MenuFormatItalic.Name = "MenuFormatItalic";
            MenuFormatItalic.Size = new Size(125, 22);
            MenuFormatItalic.Text = "&Italic";
            MenuFormatItalic.Click += MenuFormatItalic_Click;
            // 
            // MenuFormatUnderline
            // 
            MenuFormatUnderline.Name = "MenuFormatUnderline";
            MenuFormatUnderline.Size = new Size(125, 22);
            MenuFormatUnderline.Text = "&Underline";
            MenuFormatUnderline.Click += MenuFormatUnderline_Click;
            // 
            // MenuFormatSize
            // 
            MenuFormatSize.DropDownItems.AddRange(new ToolStripItem[] { MenuSmallSize, MenuMediunSize, MenuLargeSize });
            MenuFormatSize.Name = "MenuFormatSize";
            MenuFormatSize.Size = new Size(125, 22);
            MenuFormatSize.Text = "&Size";
            MenuFormatSize.Click += MenuFormatSize_Click;
            // 
            // MenuSmallSize
            // 
            MenuSmallSize.Checked = true;
            MenuSmallSize.CheckState = CheckState.Checked;
            MenuSmallSize.Name = "MenuSmallSize";
            MenuSmallSize.Size = new Size(115, 22);
            MenuSmallSize.Text = "&Small";
            MenuSmallSize.Click += MenuFormatSize_Click;
            // 
            // MenuMediunSize
            // 
            MenuMediunSize.Name = "MenuMediunSize";
            MenuMediunSize.Size = new Size(115, 22);
            MenuMediunSize.Text = "&Mediun";
            MenuMediunSize.Click += MenuFormatSize_Click;
            // 
            // MenuLargeSize
            // 
            MenuLargeSize.Name = "MenuLargeSize";
            MenuLargeSize.Size = new Size(115, 22);
            MenuLargeSize.Text = "&Large";
            MenuLargeSize.Click += MenuFormatSize_Click;
            // 
            // dlgsafeTXT
            // 
            dlgsafeTXT.Filter = "Text Files(*.txt)|*.txt";
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(67, 27);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Vertical;
            txtEditor.Size = new Size(437, 281);
            txtEditor.TabIndex = 10;
            txtEditor.TextChanged += textBox1_TextChanged;
            // 
            // EditorTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 335);
            Controls.Add(txtEditor);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "EditorTextForm";
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
        private OpenFileDialog dlgOpenTXT;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem formatToolStripMenuItem;
        private SaveFileDialog dlgsafeTXT;
        private ToolStripMenuItem dlgOpen;
        private ToolStripMenuItem dlgSafe;
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