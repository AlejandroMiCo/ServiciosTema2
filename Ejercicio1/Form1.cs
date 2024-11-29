using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            DirectoryInfo dire = null;
            string ruta = txtDirectorio.Text.Trim();

            if (ruta != "" && ruta.StartsWith("%") && ruta.EndsWith("%"))
            {
                string variableEnt = ruta.Trim('%');
                if (Directory.Exists(Environment.GetEnvironmentVariable(variableEnt)))
                {
                    dire = new DirectoryInfo(Environment.GetEnvironmentVariable(variableEnt));
                }
            }
            else
            {
                if (Directory.Exists(ruta))
                {
                    dire = new DirectoryInfo(ruta);
                }
            }

            if (dire != null)
            {
                Directory.SetCurrentDirectory(dire.FullName);
                try
                {
                    listDirectorio.Items.Clear();
                    listFicheros.Items.Clear();

                    listDirectorio.Items.Add("..");

                    foreach (DirectoryInfo sonDir in dire.GetDirectories())
                    {
                        listDirectorio.Items.Add(sonDir);
                    }

                    foreach (FileInfo sonFile in dire.GetFiles())
                    {
                        listFicheros.Items.Add(sonFile);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    //Regresa al directorio anterior en caso de no tener permisos
                    MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Directory.SetCurrentDirectory("..");
                    txtDirectorio.Text = Directory.GetCurrentDirectory();
                    btnDir.PerformClick();
                }


            }
        }

        private void listDirectorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Directory.SetCurrentDirectory(listDirectorio.SelectedItem.ToString());
                txtDirectorio.Text = Directory.GetCurrentDirectory();
                btnDir.PerformClick();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listFicheros_SelectedIndexChanged(object sender, EventArgs e)
        {

            FileInfo file = ((FileInfo)listFicheros.SelectedItem);
            long fileSize = file.Length;

            switch (fileSize)
            {
                // < Math.Pow(2, 10) Con lo comodo y bonito que quedaria asi Curro Ç_Ç
                case long n when (n < Math.Pow(2, 10)):
                    lblTamaño.Text = $"{file.ToString()}: {n.ToString()} bytes";
                    break;
                case long n when (n < Math.Pow(2, 20)):
                    lblTamaño.Text = $"{file.ToString()}: {n / Math.Pow(2, 10):0,00} KB";
                    break;
                case long n when (n < Math.Pow(2, 30)):
                    lblTamaño.Text = $"{file.ToString()}: {n / Math.Pow(2, 20):0,00} MB";
                    break;
                default:
                    lblTamaño.Text = $"{file.ToString()}: {fileSize / Math.Pow(2, 30):0.00} GB";
                    break;
            }

            if (file.Extension == ".txt")
            {
                Form2 form2 = new Form2(file);
                form2.ShowDialog();
            }
        }
    }
}
