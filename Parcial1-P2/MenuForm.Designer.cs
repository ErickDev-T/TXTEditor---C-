namespace Parcial1_P2
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            CalcularBNB = new FontAwesome.Sharp.IconButton();
            DibujarBNB = new FontAwesome.Sharp.IconButton();
            EscribirBNB = new FontAwesome.Sharp.IconButton();
            MainPanel = new Panel();
            horalabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 43, 43);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(CalcularBNB);
            panel1.Controls.Add(DibujarBNB);
            panel1.Controls.Add(EscribirBNB);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 402);
            panel1.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Magento;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(52, 24);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 78);
            iconButton4.TabIndex = 3;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // CalcularBNB
            // 
            CalcularBNB.FlatAppearance.BorderSize = 0;
            CalcularBNB.FlatStyle = FlatStyle.Flat;
            CalcularBNB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalcularBNB.ForeColor = Color.White;
            CalcularBNB.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            CalcularBNB.IconColor = Color.White;
            CalcularBNB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CalcularBNB.Location = new Point(0, 268);
            CalcularBNB.Name = "CalcularBNB";
            CalcularBNB.Size = new Size(215, 68);
            CalcularBNB.TabIndex = 2;
            CalcularBNB.Text = "Calcular";
            CalcularBNB.TextImageRelation = TextImageRelation.ImageBeforeText;
            CalcularBNB.UseVisualStyleBackColor = true;
            CalcularBNB.Click += CalcularBNB_Click;
            // 
            // DibujarBNB
            // 
            DibujarBNB.FlatAppearance.BorderSize = 0;
            DibujarBNB.FlatStyle = FlatStyle.Flat;
            DibujarBNB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DibujarBNB.ForeColor = Color.White;
            DibujarBNB.IconChar = FontAwesome.Sharp.IconChar.Book;
            DibujarBNB.IconColor = Color.White;
            DibujarBNB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DibujarBNB.Location = new Point(0, 188);
            DibujarBNB.Name = "DibujarBNB";
            DibujarBNB.Size = new Size(215, 68);
            DibujarBNB.TabIndex = 1;
            DibujarBNB.Text = "Dibujar";
            DibujarBNB.TextImageRelation = TextImageRelation.ImageBeforeText;
            DibujarBNB.UseVisualStyleBackColor = true;
            DibujarBNB.Click += iconButton2_Click;
            // 
            // EscribirBNB
            // 
            EscribirBNB.FlatAppearance.BorderSize = 0;
            EscribirBNB.FlatStyle = FlatStyle.Flat;
            EscribirBNB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EscribirBNB.ForeColor = Color.White;
            EscribirBNB.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            EscribirBNB.IconColor = Color.White;
            EscribirBNB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EscribirBNB.Location = new Point(0, 108);
            EscribirBNB.Name = "EscribirBNB";
            EscribirBNB.Size = new Size(215, 68);
            EscribirBNB.TabIndex = 0;
            EscribirBNB.Text = "Escribir";
            EscribirBNB.TextImageRelation = TextImageRelation.ImageBeforeText;
            EscribirBNB.UseVisualStyleBackColor = true;
            EscribirBNB.Click += iconButton1_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(horalabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(218, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(582, 402);
            MainPanel.TabIndex = 1;
            // 
            // horalabel
            // 
            horalabel.AutoSize = true;
            horalabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            horalabel.Location = new Point(108, 148);
            horalabel.Name = "horalabel";
            horalabel.Size = new Size(386, 86);
            horalabel.TabIndex = 0;
            horalabel.Text = "00:00:00 PM";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "MenuForm";
            Text = "MenuForm";
            FormClosing += Menu_FormClosing;
            panel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton CalcularBNB;
        private FontAwesome.Sharp.IconButton DibujarBNB;
        private FontAwesome.Sharp.IconButton EscribirBNB;
        private Panel MainPanel;
        private Label horalabel;
        private System.Windows.Forms.Timer timer1;
    }
}