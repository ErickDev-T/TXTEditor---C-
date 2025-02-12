namespace Parcial1_P2
{
    partial class Tiempo
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
            horalabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // horalabel
            // 
            horalabel.AutoSize = true;
            horalabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            horalabel.Location = new Point(115, 131);
            horalabel.Name = "horalabel";
            horalabel.Size = new Size(386, 86);
            horalabel.TabIndex = 1;
            horalabel.Text = "00:00:00 PM";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Tiempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 402);
            Controls.Add(horalabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tiempo";
            Text = "Tiempo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label horalabel;
        private System.Windows.Forms.Timer timer1;
    }
}