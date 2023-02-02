using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.PoolSalePoint
{
    public partial class Cut : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sefaro21; Database = Mr.Pool");
        NpgsqlCommand cm;

        public string cajero, supervisor;
        public double total;
        public CajWindow CajW;

        public Cut(string C)
        {
            InitializeComponent();
            cajero = C;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("No se ha ingresado depósito", "Mr.Pool");
            }

            else
            {
                total = total - Convert.ToDouble(textBox1.Text);

                if (total < 0)
                {
                    MessageBox.Show("Hubo un sobrante de: " + total + "", "Mr.Pool");
                }
                else
                {
                    MessageBox.Show("Hubo un faltante de: " + total + "", "Mr.Pool");
                }

                conn.Open();
                cm = new NpgsqlCommand("update cuts set totalventa = 0 where usuario = '" + cajero + "'", conn);
                cm.ExecuteNonQuery();
                conn.Close();


                DateTime thisDay = DateTime.Now;

                conn.Open();
                cm = new NpgsqlCommand("insert into past values ('" + thisDay.ToString("d") + "', '" + thisDay.ToString("hh:mm:ss") + "', '" + supervisor + "', 'Cortó a " + cajero + "')", conn);
                cm.ExecuteNonQuery();
                conn.Close();

                CajW.Hide();
                this.Hide();

                Form1 Start = new Form1();
                Start.Show();
            }
        }
    }
}
