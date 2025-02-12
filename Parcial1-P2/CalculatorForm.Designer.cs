using System.Diagnostics.Eventing.Reader;

namespace Parcial1_P2
{
    partial class CalculatorForm
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
            button1 = new Button();
            CajaResultado = new TextBox();
            lblhISTORIAL = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            btnResul = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 267);
            button1.Name = "button1";
            button1.Size = new Size(113, 57);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // CajaResultado
            // 
            CajaResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CajaResultado.Location = new Point(28, 27);
            CajaResultado.Name = "CajaResultado";
            CajaResultado.ReadOnly = true;
            CajaResultado.Size = new Size(517, 39);
            CajaResultado.TabIndex = 0;
            CajaResultado.Text = "0";
            CajaResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhISTORIAL
            // 
            lblhISTORIAL.AutoSize = true;
            lblhISTORIAL.Location = new Point(38, 9);
            lblhISTORIAL.Name = "lblhISTORIAL";
            lblhISTORIAL.Size = new Size(54, 15);
            lblhISTORIAL.TabIndex = 2;
            lblhISTORIAL.Text = "BLANCO";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(299, 267);
            button2.Name = "button2";
            button2.Size = new Size(113, 57);
            button2.TabIndex = 3;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(166, 267);
            button3.Name = "button3";
            button3.Size = new Size(113, 57);
            button3.TabIndex = 4;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(166, 204);
            button4.Name = "button4";
            button4.Size = new Size(113, 57);
            button4.TabIndex = 7;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(299, 204);
            button5.Name = "button5";
            button5.Size = new Size(113, 57);
            button5.TabIndex = 6;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(28, 204);
            button6.Name = "button6";
            button6.Size = new Size(113, 57);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(166, 141);
            button7.Name = "button7";
            button7.Size = new Size(113, 57);
            button7.TabIndex = 10;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(299, 141);
            button8.Name = "button8";
            button8.Size = new Size(113, 57);
            button8.TabIndex = 9;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(28, 141);
            button9.Name = "button9";
            button9.Size = new Size(113, 57);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(28, 330);
            button10.Name = "button10";
            button10.Size = new Size(251, 57);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(299, 330);
            button11.Name = "button11";
            button11.Size = new Size(113, 57);
            button11.TabIndex = 12;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(432, 141);
            button12.Name = "button12";
            button12.Size = new Size(113, 57);
            button12.TabIndex = 13;
            button12.Text = "X";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(432, 204);
            button13.Name = "button13";
            button13.Size = new Size(113, 57);
            button13.TabIndex = 14;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(432, 267);
            button14.Name = "button14";
            button14.Size = new Size(113, 57);
            button14.TabIndex = 15;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            // 
            // btnResul
            // 
            btnResul.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResul.Location = new Point(432, 330);
            btnResul.Name = "btnResul";
            btnResul.Size = new Size(113, 57);
            btnResul.TabIndex = 16;
            btnResul.Text = "=";
            btnResul.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(28, 78);
            button16.Name = "button16";
            button16.Size = new Size(113, 57);
            button16.TabIndex = 17;
            button16.Text = "%";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(166, 78);
            button17.Name = "button17";
            button17.Size = new Size(113, 57);
            button17.TabIndex = 18;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(299, 78);
            button18.Name = "button18";
            button18.Size = new Size(113, 57);
            button18.TabIndex = 19;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(432, 78);
            button19.Name = "button19";
            button19.Size = new Size(113, 57);
            button19.TabIndex = 20;
            button19.Text = "<";
            button19.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 402);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(btnResul);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblhISTORIAL);
            Controls.Add(CajaResultado);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculatorForm";
            Text = "Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Add your button4 click event logic here
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Add your button7 click event logic here
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                CajaResultado.Text += "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add your button3 click event logic here
        }
        #endregion

        private Button button1;
        private TextBox CajaResultado;
        private Label lblhISTORIAL;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btnResul;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}