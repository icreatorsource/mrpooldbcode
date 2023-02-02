using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.PoolSalePoint
{
    public partial class CajWindow : Form
    {
        Stopwatch osw1 = new Stopwatch();
        Stopwatch osw2 = new Stopwatch();
        Stopwatch osw3 = new Stopwatch();
        Stopwatch osw4 = new Stopwatch();
        Stopwatch osw5 = new Stopwatch();
        Stopwatch osw6 = new Stopwatch();
        Stopwatch osw7 = new Stopwatch();
        Stopwatch osw8 = new Stopwatch();
        Stopwatch osw9 = new Stopwatch();
        public string actualUser;
        double total;

        string tiempo1;
        string tiempo2;
        string tiempo3;
        string tiempo4;
        string tiempo5;
        string tiempo6;
        string tiempo7;
        string tiempo8;
        string tiempo9;

        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; user id = postgres; password = sefaro21; database = Mr.Pool");
        NpgsqlCommand cm;

        string TOTSALE, USERN, NAMUS;
        public CajWindow(string User, string Nombre, string totalventa )
        {
            InitializeComponent();
            TOTSALE = totalventa;
            USERN = User;
            NAMUS = Nombre;
        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            osw1.Start();
            timer1.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 1", conn);
            tiempo1 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw1.ElapsedMilliseconds);
            textBox1Time.Text = ""+ts.Hours.ToString()+":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo1==textBox1Time.Text)
            {
                osw1.Reset();
                timer1.Enabled = false;
                textBox1Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 1", "Mr.Pool");
            }
        }

        private void button2Start_Click(object sender, EventArgs e)
        {
            osw2.Start();
            timer2.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 2", conn);
            tiempo2 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw2.ElapsedMilliseconds);

            textBox2Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo2 == textBox2Time.Text)
            {
                osw2.Reset();
                timer2.Enabled = false;
                textBox2Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 2", "Mr.Pool");
            }
        }

        private void button3Start_Click(object sender, EventArgs e)
        {
            osw3.Start();
            timer3.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 3", conn);
            tiempo3 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw3.ElapsedMilliseconds);

            textBox3Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo3 == textBox3Time.Text)
            {
                osw3.Reset();
                timer3.Enabled = false;
                textBox3Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 3", "Mr.Pool");
            }
        }

        private void button4Start_Click(object sender, EventArgs e)
        {
            osw4.Start();
            timer4.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 4", conn);
            tiempo4 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw4.ElapsedMilliseconds);

            textBox4Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo4 == textBox4Time.Text)
            {
                osw4.Reset();
                timer4.Enabled = false;
                textBox4Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 4", "Mr.Pool");
            }
        }

        private void button5Start_Click(object sender, EventArgs e)
        {
            osw5.Start();
            timer5.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 5", conn);
            tiempo5 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw5.ElapsedMilliseconds);

            textBox5Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo5 == textBox5Time.Text)
            {
                osw5.Reset();
                timer5.Enabled = false;
                textBox5Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 5", "Mr.Pool");
            }
        }

        private void button6Start_Click(object sender, EventArgs e)
        {
            osw6.Start();
            timer6.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 6", conn);
            tiempo6 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw6.ElapsedMilliseconds);

            textBox6Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo6 == textBox6Time.Text)
            {
                osw6.Reset();
                timer6.Enabled = false;
                textBox6Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 6", "Mr.Pool");
            }
        }

        private void button7Start_Click(object sender, EventArgs e)
        {
            osw7.Start();
            timer7.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 7", conn);
            tiempo7 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw7.ElapsedMilliseconds);

            textBox7Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo7 == textBox7Time.Text)
            {
                osw7.Reset();
                timer7.Enabled = false;
                textBox7Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 7", "Mr.Pool");
            }
        }

        private void button8Start_Click(object sender, EventArgs e)
        {
            osw8.Start();
            timer8.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 8", conn);
            tiempo8 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw8.ElapsedMilliseconds);

            textBox8Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo8 == textBox8Time.Text)
            {
                osw8.Reset();
                timer8.Enabled = false;
                textBox8Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 8", "Mr.Pool");
            }
        }

        private void button9Start_Click(object sender, EventArgs e)
        {
            osw9.Start();
            timer9.Enabled = true;

            conn.Open();
            cm = new NpgsqlCommand("select tiempototal from pooltables where nummesa = 9", conn);
            tiempo9 = Convert.ToString(cm.ExecuteScalar());
            conn.Close();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)osw9.ElapsedMilliseconds);

            textBox9Time.Text = "" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + "";

            if (tiempo9 == textBox9Time.Text)
            {
                osw9.Reset();
                timer9.Enabled = false;
                textBox9Time.Text = "0:0:0";
                MessageBox.Show("Tiempo cumplido de la mesa 9", "Mr.Pool");
            }
        }

        private void buttonTickMesa1_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 1;
            T.dataGridViewTicket.DataSource = ConsultarTicket(1);
            T.labelNumMesa.Text = "Mesa 1";
            T.usuarioActual = actualUser;
            T.cajW = this;
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 1", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if(dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 1", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }
            T.Show();
        }

        private void buttonTickMesa2_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 2;
            T.dataGridViewTicket.DataSource = ConsultarTicket(2);
            T.labelNumMesa.Text = "Mesa 2";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 2", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 2", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa3_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 3;
            T.dataGridViewTicket.DataSource = ConsultarTicket(3);
            T.labelNumMesa.Text = "Mesa 3";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 3", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 3", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa4_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 4;
            T.dataGridViewTicket.DataSource = ConsultarTicket(4);
            T.labelNumMesa.Text = "Mesa 4";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 4", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 4", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa5_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 5;
            T.dataGridViewTicket.DataSource = ConsultarTicket(5);
            T.labelNumMesa.Text = "Mesa 5";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 5", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 5", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa6_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 6;
            T.dataGridViewTicket.DataSource = ConsultarTicket(6);
            T.labelNumMesa.Text = "Mesa 6";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 6", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 6", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa7_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 7;
            T.dataGridViewTicket.DataSource = ConsultarTicket(7);
            T.labelNumMesa.Text = "Mesa 7";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 7", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 7", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa8_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 8;
            T.dataGridViewTicket.DataSource = ConsultarTicket(8);
            T.labelNumMesa.Text = "Mesa 8";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 8", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 8", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        private void buttonTickMesa9_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.numMesa = 9;
            T.dataGridViewTicket.DataSource = ConsultarTicket(9);
            T.labelNumMesa.Text = "Mesa 9";
            T.usuarioActual = actualUser;
            T.cajW = this;

            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select mesa from tickets where mesa = 9", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select sum (precio) from tickets where mesa = 9", conn);
                total = Convert.ToDouble(cm.ExecuteScalar());
                T.labelTotal.Text = Convert.ToString(total);
                conn.Close();
            }

            else
            {
                conn.Close();
                T.labelTotal.Text = "0";
            }

            T.Show();
        }

        public DataTable ConsultarTicket(int numeromesa)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select * from tickets where mesa = " + numeromesa + "", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 SignIn = new Form1();
            SignIn.Show();
        }

   

        private void boxClose_Click(object sender, EventArgs e)
        {
            StartCut SC = new StartCut();
            SC.usuarioCajero = actualUser;

            conn.Open();
            cm = new NpgsqlCommand("select totalventa from cuts where usuario = '" + actualUser + "'", conn);
            total = Convert.ToDouble(cm.ExecuteScalar());
            conn.Close();

            SC.total = total;
            SC.CajW = this;
            SC.Show();
        }
    }
}
