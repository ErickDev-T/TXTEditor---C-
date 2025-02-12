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
            bnt1 = new Button();
            CajaResultado = new TextBox();
            ResultadoLABEL = new Label();
            bnt3 = new Button();
            bnt2 = new Button();
            bnt5 = new Button();
            bnt6 = new Button();
            bnt4 = new Button();
            bnt8 = new Button();
            bnt9 = new Button();
            bnt7 = new Button();
            button10 = new Button();
            button11 = new Button();
            bntMuLtiplicar = new Button();
            bntRestar = new Button();
            bntSumar = new Button();
            btnResulado = new Button();
            bntPorciento = new Button();
            bntdividir = new Button();
            bntreset = new Button();
            bntborrar = new Button();
            SuspendLayout();
            // 
            // bnt1
            // 
            bnt1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt1.Location = new Point(28, 267);
            bnt1.Name = "bnt1";
            bnt1.Size = new Size(113, 57);
            bnt1.TabIndex = 0;
            bnt1.Text = "1";
            bnt1.UseVisualStyleBackColor = true;
            bnt1.Click += button1_Click_1;
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
            // ResultadoLABEL
            // 
            ResultadoLABEL.AutoSize = true;
            ResultadoLABEL.Location = new Point(38, 9);
            ResultadoLABEL.Name = "ResultadoLABEL";
            ResultadoLABEL.Size = new Size(34, 15);
            ResultadoLABEL.TabIndex = 2;
            ResultadoLABEL.Text = ".........";
            // 
            // bnt3
            // 
            bnt3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt3.Location = new Point(299, 267);
            bnt3.Name = "bnt3";
            bnt3.Size = new Size(113, 57);
            bnt3.TabIndex = 3;
            bnt3.Text = "3";
            bnt3.UseVisualStyleBackColor = true;
            bnt3.Click += bnt3_Click;
            // 
            // bnt2
            // 
            bnt2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt2.Location = new Point(166, 267);
            bnt2.Name = "bnt2";
            bnt2.Size = new Size(113, 57);
            bnt2.TabIndex = 4;
            bnt2.Text = "2";
            bnt2.UseVisualStyleBackColor = true;
            bnt2.Click += button2_Click;
            // 
            // bnt5
            // 
            bnt5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt5.Location = new Point(166, 204);
            bnt5.Name = "bnt5";
            bnt5.Size = new Size(113, 57);
            bnt5.TabIndex = 7;
            bnt5.Text = "5";
            bnt5.UseVisualStyleBackColor = true;
            bnt5.Click += button4_Click;
            // 
            // bnt6
            // 
            bnt6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt6.Location = new Point(299, 204);
            bnt6.Name = "bnt6";
            bnt6.Size = new Size(113, 57);
            bnt6.TabIndex = 6;
            bnt6.Text = "6";
            bnt6.UseVisualStyleBackColor = true;
            bnt6.Click += bnt6_Click;
            // 
            // bnt4
            // 
            bnt4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt4.Location = new Point(28, 204);
            bnt4.Name = "bnt4";
            bnt4.Size = new Size(113, 57);
            bnt4.TabIndex = 5;
            bnt4.Text = "4";
            bnt4.UseVisualStyleBackColor = true;
            bnt4.Click += bnt4_Click;
            // 
            // bnt8
            // 
            bnt8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt8.Location = new Point(166, 141);
            bnt8.Name = "bnt8";
            bnt8.Size = new Size(113, 57);
            bnt8.TabIndex = 10;
            bnt8.Text = "8";
            bnt8.UseVisualStyleBackColor = true;
            bnt8.Click += button7_Click;
            // 
            // bnt9
            // 
            bnt9.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt9.Location = new Point(299, 141);
            bnt9.Name = "bnt9";
            bnt9.Size = new Size(113, 57);
            bnt9.TabIndex = 9;
            bnt9.Text = "9";
            bnt9.UseVisualStyleBackColor = true;
            bnt9.Click += bnt9_Click;
            // 
            // bnt7
            // 
            bnt7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bnt7.Location = new Point(28, 141);
            bnt7.Name = "bnt7";
            bnt7.Size = new Size(113, 57);
            bnt7.TabIndex = 8;
            bnt7.Text = "7";
            bnt7.UseVisualStyleBackColor = true;
            bnt7.Click += bnt7_Click;
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
            // bntMuLtiplicar
            // 
            bntMuLtiplicar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntMuLtiplicar.Location = new Point(432, 141);
            bntMuLtiplicar.Name = "bntMuLtiplicar";
            bntMuLtiplicar.Size = new Size(113, 57);
            bntMuLtiplicar.TabIndex = 13;
            bntMuLtiplicar.Text = "X";
            bntMuLtiplicar.UseVisualStyleBackColor = true;
            bntMuLtiplicar.Click += bntMuLtiplicar_Click;
            // 
            // bntRestar
            // 
            bntRestar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntRestar.Location = new Point(432, 204);
            bntRestar.Name = "bntRestar";
            bntRestar.Size = new Size(113, 57);
            bntRestar.TabIndex = 14;
            bntRestar.Text = "-";
            bntRestar.UseVisualStyleBackColor = true;
            bntRestar.Click += bntRestar_Click;
            // 
            // bntSumar
            // 
            bntSumar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntSumar.Location = new Point(432, 267);
            bntSumar.Name = "bntSumar";
            bntSumar.Size = new Size(113, 57);
            bntSumar.TabIndex = 15;
            bntSumar.Text = "+";
            bntSumar.UseVisualStyleBackColor = true;
            bntSumar.Click += bntSumar_Click;
            // 
            // btnResulado
            // 
            btnResulado.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResulado.Location = new Point(432, 330);
            btnResulado.Name = "btnResulado";
            btnResulado.Size = new Size(113, 57);
            btnResulado.TabIndex = 16;
            btnResulado.Text = "=";
            btnResulado.UseVisualStyleBackColor = true;
            btnResulado.Click += btnResulado_Click;
            // 
            // bntPorciento
            // 
            bntPorciento.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntPorciento.Location = new Point(28, 78);
            bntPorciento.Name = "bntPorciento";
            bntPorciento.Size = new Size(113, 57);
            bntPorciento.TabIndex = 17;
            bntPorciento.Text = "%";
            bntPorciento.UseVisualStyleBackColor = true;
            bntPorciento.Click += bntPorciento_Click;
            // 
            // bntdividir
            // 
            bntdividir.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntdividir.Location = new Point(166, 78);
            bntdividir.Name = "bntdividir";
            bntdividir.Size = new Size(113, 57);
            bntdividir.TabIndex = 18;
            bntdividir.Text = "/";
            bntdividir.UseVisualStyleBackColor = true;
            bntdividir.Click += bntdividir_Click;
            // 
            // bntreset
            // 
            bntreset.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntreset.Location = new Point(299, 78);
            bntreset.Name = "bntreset";
            bntreset.Size = new Size(113, 57);
            bntreset.TabIndex = 19;
            bntreset.Text = "C";
            bntreset.UseVisualStyleBackColor = true;
            bntreset.Click += bntreset_Click;
            // 
            // bntborrar
            // 
            bntborrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntborrar.Location = new Point(432, 78);
            bntborrar.Name = "bntborrar";
            bntborrar.Size = new Size(113, 57);
            bntborrar.TabIndex = 20;
            bntborrar.Text = "<";
            bntborrar.UseVisualStyleBackColor = true;
            bntborrar.Click += bntborrar_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 402);
            Controls.Add(bntborrar);
            Controls.Add(bntreset);
            Controls.Add(bntdividir);
            Controls.Add(bntPorciento);
            Controls.Add(btnResulado);
            Controls.Add(bntSumar);
            Controls.Add(bntRestar);
            Controls.Add(bntMuLtiplicar);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(bnt8);
            Controls.Add(bnt9);
            Controls.Add(bnt7);
            Controls.Add(bnt5);
            Controls.Add(bnt6);
            Controls.Add(bnt4);
            Controls.Add(bnt2);
            Controls.Add(bnt3);
            Controls.Add(ResultadoLABEL);
            Controls.Add(CajaResultado);
            Controls.Add(bnt1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculatorForm";
            Text = "Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LeerNumero("0");
        }

        private void button3_Click(object sender, EventArgs e)
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
        #endregion

        private Button bnt1;
        private TextBox CajaResultado;
        private Label ResultadoLABEL;
        private Button bnt3;
        private Button bnt2;
        private Button bnt5;
        private Button bnt6;
        private Button bnt4;
        private Button bnt8;
        private Button bnt9;
        private Button bnt7;
        private Button button10;
        private Button button11;
        private Button bntMuLtiplicar;
        private Button bntRestar;
        private Button bntSumar;
        private Button btnResulado;
        private Button bntPorciento;
        private Button bntdividir;
        private Button bntreset;
        private Button bntborrar;
    }
}