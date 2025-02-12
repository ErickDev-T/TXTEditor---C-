namespace Parcial1_P2
{
    public partial class textedit : Form
    {
        public textedit()
        {
            InitializeComponent();
        }

        int fontSize = 9;
        string fontName = "MS Sans Serif";

        public void ChangeFont()
        {
            FontStyle newFont;
            newFont = FontStyle.Regular;
            if (MenuFormatBold.Checked)
            {
                newFont = newFont | FontStyle.Bold;
            }
            if (MenuFormatItalic.Checked)
            {
                newFont = newFont | FontStyle.Italic;
            }
            if (MenuFormatUnderline.Checked)
            {
                newFont = newFont | FontStyle.Underline;
            }

            txtEditor.Font = new Font(fontName, fontSize, newFont);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(Application.StartupPath + "\\note.ini");
            MenuFormatBold.Checked = Convert.ToBoolean(inputFile.ReadLine());
            MenuFormatUnderline.Checked = Convert.ToBoolean(inputFile.ReadLine());
            MenuFormatItalic.Checked = Convert.ToBoolean(inputFile.ReadLine());
            int i = Convert.ToInt32(inputFile.ReadLine());
            switch (i)
            {
                case 1:
                    MenuSmallSize.PerformClick();
                    break;
                case 2:
                    MenuMediunSize.PerformClick();
                    break;
                case 3:
                    MenuLargeSize.PerformClick();
                    break;
            }
            inputFile.Close();
            ChangeFont();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MenuOpenClick(object sender, EventArgs e)
        {

        }

        private void MenuSafeClick(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres un crear un archivo?", "Nuevo Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtEditor.Text = "";
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir?", "Salir de la aplicacion ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();

            }
            else
            {
                return;
            }
        }

        private void MenuFormatBold_Click(object sender, EventArgs e)
        {
            MenuFormatBold.Checked = !MenuFormatBold.Checked;
            ChangeFont();
        }

        private void MenuFormatItalic_Click(object sender, EventArgs e)
        {
            MenuFormatItalic.Checked = !MenuFormatItalic.Checked;
            ChangeFont();
        }

        private void MenuFormatUnderline_Click(object sender, EventArgs e)
        {
            MenuFormatUnderline.Checked = !MenuFormatUnderline.Checked;
            ChangeFont();
        }

        private void MenuFormatSize_Click(object sender, EventArgs e)
        {
            string SizeCliked = ((ToolStripMenuItem)sender).Text;
            MenuSmallSize.Checked = false;
            MenuMediunSize.Checked = false;
            MenuLargeSize.Checked = false;

            switch (SizeCliked)
            {
                case "&Small":
                    fontSize = 8;
                    MenuSmallSize.Checked = true;
                    break;
                case "&Mediun":
                    fontSize = 12;
                    MenuMediunSize.Checked = true;
                    break;

                case "&Large":

                    fontSize = 18;
                    MenuLargeSize.Checked = true;
                    break;

            }
            ChangeFont();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter outputFile = new StreamWriter(Application.StartupPath + "//note.ini");
            outputFile.WriteLine(MenuFormatBold.Checked);
            outputFile.WriteLine(MenuFormatItalic.Checked);
            outputFile.WriteLine(MenuFormatUnderline.Checked);
            if (MenuSmallSize.Checked)
                outputFile.WriteLine(1);
            else if (MenuMediunSize.Checked)
                outputFile.WriteLine(2);
            else
                outputFile.WriteLine(3);

            outputFile.Close();
        }
    }
}