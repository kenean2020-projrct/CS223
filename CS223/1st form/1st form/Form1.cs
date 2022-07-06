using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1st_form;

namespace _1st_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add Ad = new add {
                name = txtname.Text;
            inventoryName = txtinventory.Text,
            objectName = txtobject.Text,
            price = double.Parse(txtprice.Text),
            count = int.Parse(txtcount.Text),
          
        };

            MessageBox.Show("good");       
          
         
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("process cancled");
        
        }
    }
}
