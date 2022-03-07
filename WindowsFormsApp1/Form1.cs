using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<employer> l = new List<employer>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int num = int.Parse(textBox1.Text);
                string nom = textBox2.Text;
                int age = int.Parse(textBox3.Text);
                employer e1 = new employer(num, nom, age);
                l.Add(e1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("num", "num");
            dataGridView1.Columns.Add("mon", "nom");
            dataGridView1.Columns.Add("Age", "Age");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string y = textBox4.Text;
            FileStream f = File.Open(y, FileMode.OpenOrCreate);
            XmlSerializer s = new XmlSerializer(typeof(List<employer>));
            s.Serialize(f, l);

            f.Close();

            MessageBox.Show("serialisation bien fait", "formation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string y = textBox4.Text;
            FileStream f = File.Open(y, FileMode.Open);
            XmlSerializer s = new XmlSerializer(typeof(List<employer>));
            List<employer> lis = (List<employer>)s.Deserialize(f);
            f.Close();

            MessageBox.Show("deserialization bien fait", "formation");

            foreach (employer i in lis)
            {
                dataGridView1.Rows.Add(i.num, i.nom, i, i.age);
            }

            foreach(employer j in lis)
            {
                listBox1.Items.Add(j.ToString());
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
//C:\Users\youness\source\repos