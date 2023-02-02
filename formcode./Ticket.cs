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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Mr.PoolSalePoint
{
    public partial class Ticket : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sefaro21; Database = Mr.Pool");
        public int numMesa;
        double total;
        int idProd;
        double dineroIngresado, cambio;
        public CajWindow cajW;
        public string usuarioActual;
        public Ticket()
        {
            InitializeComponent();
        }

        public DataTable ConsultarTicket()
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select * from tickets where mesa = "+numMesa+"", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                conn.Open();
                NpgsqlCommand cm = new NpgsqlCommand("select isbn from products where isbn = '"+textBox1.Text+"'" , conn);
                NpgsqlDataReader dr = cm.ExecuteReader();

                if(dr.Read())
                {
                    conn.Close();
                    conn.Open();
                    cm = new NpgsqlCommand("select isbn from products where isbn = '" + textBox1.Text + "'", conn);
                    string ISBN = Convert.ToString(cm.ExecuteScalar());
                    conn.Close();
                    conn.Open();
                    cm = new NpgsqlCommand("select nombre from products where isbn = '" + textBox1.Text + "'", conn);
                    string name = Convert.ToString(cm.ExecuteScalar());
                    conn.Close();
                    conn.Open();
                    cm = new NpgsqlCommand("select precio from products where isbn = '" + textBox1.Text + "'", conn);
                    decimal price = Convert.ToDecimal(cm.ExecuteScalar());
                    conn.Close();

                    conn.Open();
                    cm = new NpgsqlCommand("select count(*)from tickets where isbn='"+ISBN+"' and mesa = "+numMesa+"", conn);
                    idProd = Convert.ToInt32(cm.ExecuteScalar());
                    conn.Close();

                    conn.Open();
                    cm = new NpgsqlCommand("insert into tickets values("+ idProd +", " + numMesa + ", '" + ISBN + "', '" + name + "', " + price + ")", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    dataGridViewTicket.DataSource = ConsultarTicket();

                    conn.Open();
                    cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = "+ numMesa +"", conn);
                    total = Convert.ToDouble(cm.ExecuteScalar());
                    labelTotal.Text = Convert.ToString(total);
                    conn.Close();

                    conn.Open();
                    cm = new NpgsqlCommand("update pooltables set total = "+ total +" where nummesa = " + numMesa + "", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                }

                else
                {
                    MessageBox.Show("Producto no encontrado", "Mr.Pool");
                    conn.Close();
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("update pooltables set tiempototal = '"+textBoxHours.Text+":"+textBoxMinutes.Text+":0' where nummesa = "+numMesa+"", conn);
            cm.ExecuteNonQuery();
            conn.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conn.Open();
                NpgsqlCommand cm = new NpgsqlCommand("select isbn, mesa from tickets where isbn = '" + textBox2.Text + "' and mesa = "+numMesa+"", conn);
                NpgsqlDataReader dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    conn.Close();
                    conn.Open();
                    cm = new NpgsqlCommand("select count(*)from tickets where isbn='" + textBox2.Text + "' and mesa = " + numMesa + "", conn);
                    idProd = Convert.ToInt32(cm.ExecuteScalar());
                    idProd--;
                    conn.Close();

                    conn.Open();
                    cm = new NpgsqlCommand("delete from tickets where id = " + idProd + " and isbn = '" + textBox2.Text + "' and mesa =" + numMesa + "", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();


                    dataGridViewTicket.DataSource = ConsultarTicket();

                    if(idProd > 0)
                    { 
                    conn.Open();
                    cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = " + numMesa + "", conn);
                    total = Convert.ToDouble(cm.ExecuteScalar());
                    labelTotal.Text = Convert.ToString(total);
                    conn.Close();
                    }

                    else
                    {
                        total = 0;
                        labelTotal.Text = "0";
                    }

                    conn.Open();
                    cm = new NpgsqlCommand("update pooltables set total = " + total + " where nummesa = " + numMesa + "", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                }

                else
                {
                    MessageBox.Show("Producto no encontrado en el ticket", "Mr.Pool");
                    conn.Close();
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Debe ingresar el dinero recibido por el cliente");

                return;
            }

            else
            {
                dineroIngresado = Convert.ToDouble(textBox3.Text);
                cambio = dineroIngresado - total;

                labelCambio.Text = Convert.ToString(cambio);

                conn.Open();
                NpgsqlCommand cm = new NpgsqlCommand("update pooltables set total = 0, disponible = true, tiempototal = '0:0:0' where nummesa = "+numMesa+"", conn);
                cm.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                cm = new NpgsqlCommand("delete from tickets where mesa = "+numMesa+"", conn);
                cm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cambio: "+cambio+"");

                conn.Open();
                cm = new NpgsqlCommand("update cuts set totalventa = totalventa + "+total+" where usuario = '"+usuarioActual+"'", conn);
                cm.ExecuteNonQuery();
                conn.Close();

                this.Hide();
            }
        }
    }
}
