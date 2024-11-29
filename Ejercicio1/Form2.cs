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
        public Form2(FileInfo file)
        {
            InitializeComponent();
            textBox1.Size = ClientSize;
            this.Text = file.Name;
            filePath = file.FullName;

            using (StreamReader sr = new StreamReader(file.FullName))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (changedText)
            {
                if (MessageBox.Show("Quieres guaradar los cambios?", "Guardar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(filePath)) 
                    {
                        sw.Write(textBox1.Text);
                    }
                                                 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changedText = true;
        }
    }
}
