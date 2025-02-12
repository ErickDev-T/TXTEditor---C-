using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_P2
{
    public partial class MenuForm : Form


    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());  // Set EditorForm as the main form
        }

        public MenuForm()
        {
            InitializeComponent();
        }
        private void AbrirPanel(object childpanel)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form fh = childpanel as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(fh);
            this.MainPanel.Tag = fh;
            fh.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new EditorTextForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PaintForm1());
        }

        private void CalcularBNB_Click(object sender, EventArgs e)
        {
            AbrirPanel(new CalculatorForm());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Time());
        }

        // Método para guardar los datos en el archivo INI
        public void SaveDataToFile(string data)
        {
            string filePath = Path.Combine(Application.StartupPath, "note.ini");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }


            File.WriteAllText(filePath, data);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "note.ini");

            SaveDataToFile(filePath);

            EditorTextForm editorForm = new EditorTextForm();
            editorForm.Editor_FormClosing(sender, e);
        }
    }
}
