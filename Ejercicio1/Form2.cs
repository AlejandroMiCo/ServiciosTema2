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
    public partial class Form2 : Form
    {

        bool changedText = false;
        string filePath;
        string textoIni;
        string textoFin;
        public Form2(FileInfo file)
        {
            InitializeComponent();
            textBox1.Size = ClientSize;
            this.Text = file.Name;
            filePath = file.FullName;


            try
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    textBox1.Text = sr.ReadToEnd();
                    textoIni = textBox1.Text;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No posee los permisos necesarios para leer este archivo", "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (textoIni != textoFin)
            {

                try
                {
                    if (MessageBox.Show("Quieres guaradar los cambios?", "Guardar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.Write(textBox1.Text);
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("No posee los permisos necesarios para escribir en este archivo", "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textoFin = textBox1.Text;
        }
    }
}
