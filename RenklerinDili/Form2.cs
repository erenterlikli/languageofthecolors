using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenklerinDili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + " huzurun rengidir" + " ";
                button2.BackColor= Color.Blue ;
                
            }
            if(comboBox1.Text== "Yeşil")
            {
                label4.Text= textBox1.Text+ " "+ comboBox1.Text+ " " + "bereketin rengidir"+ " " ;
                button2.BackColor = Color.Green;
            }
            if( comboBox1.Text== "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "iyimserliğin rengidir" + " ";
                button2.BackColor = Color.Yellow;

            }
            if(comboBox1.Text== "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "aşkın rengidir" + " ";
                button2.BackColor = Color.Red;
            }
            if(comboBox1.Text== "Beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "saflığın rengidir" + " ";
                button2.BackColor = Color.White;
            }
            if(comboBox1.Text=="Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "mutsuzluğun rengidir" + " ";
                button2.BackColor = Color.Black;
            }

        }

    }
}