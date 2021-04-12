using _8pr6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 cl = new Class1();
            Form2 f = new Form2(cl);
            
            if (f.ShowDialog ()== DialogResult.OK)
            {
                textBox1.Text += string.Format(" Модель процесора : {0}; країна виробник : {1}; кількість ядер : {2}; інтегрована відеопамять : {3}; тип памяті : {4}; кількість потоків : {5}\n", cl.modelCPU, cl.country, cl.kernel, cl.VidCard ? "є інтегрована відкокарта " : " немає інтегрованої відкокарти ", cl.typeMemor, cl.potokiv);
            }
        }
    }
}
