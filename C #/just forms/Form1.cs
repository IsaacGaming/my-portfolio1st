using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace just_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form2 NewForm = new Form2(); //создаем форму 2
            NewForm.Show(); // открываем форму 2
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
