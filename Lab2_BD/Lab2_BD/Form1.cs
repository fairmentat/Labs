using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sMARTPHONESDataSet.Likes". При необходимости она может быть перемещена или удалена.
            this.likesTableAdapter.Fill(this.sMARTPHONESDataSet.Likes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sMARTPHONESDataSet.Best". При необходимости она может быть перемещена или удалена.
            this.bestTableAdapter.Fill(this.sMARTPHONESDataSet.Best);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sMARTPHONESDataSet.Bench". При необходимости она может быть перемещена или удалена.
            this.benchTableAdapter.Fill(this.sMARTPHONESDataSet.Bench);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bestBindingSource1.EndEdit();
            this.bestTableAdapter.Update(this.sMARTPHONESDataSet.Best);
        }

        private void button1_FontChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bestBindingSource1.Filter = "id<4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bestBindingSource1.Filter = "id<6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bestBindingSource1.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            benchBindingSource2.Filter = "geekBench >= 2301";
            
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            benchBindingSource2.Filter = "";
        }

       

       

       
    }
}
