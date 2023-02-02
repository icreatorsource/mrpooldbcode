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

namespace Mr.PoolSalePoint
{
    public partial class SupWindow : Form
    {
        public string actualUser;
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sefaro21; Database = Mr.Pool");
        public SupWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario from users where usuario = '" + textBoxUsuarioCaj.Text + "'", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();

            if(dr.Read())
            {
                conn.Close();
                MessageBox.Show("El usuario ya existe", "Mr.Pool");
            }
            else
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into users values ('" + textBoxUsuarioCaj.Text + "', '" + textBoxNombreCaj.Text + "', '" + textBoxContraseñaCaj.Text + "', 'Caj')", conn);
                cm.ExecuteNonQuery();

                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into cuts values('"+ textBoxUsuarioCaj.Text + "', '"+ textBoxNombreCaj.Text +"', 0)", conn);
                cm.ExecuteNonQuery();


                DateTime thisDay = DateTime.Now;

                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into past values ('"+ thisDay.ToString("d")+ "', '" + thisDay.ToString("hh:mm:ss") + "', '" + actualUser + "', 'Agregó a " + textBoxUsuarioCaj.Text+ "')", conn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Cajero agregado", "Mr.Pool");
                conn.Close();
            }
        }

        private void buttonAddSup_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario from users where usuario = '" + textBoxUsuarioSup.Text + "'", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                MessageBox.Show("El usuario ya existe", "Mr.Pool");
            }
            else
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into users values ('" + textBoxUsuarioSup.Text + "', '" + textBoxNombreSup.Text + "', '" + textBoxContraseñaSup.Text + "', 'Sup')", conn);
                cm.ExecuteNonQuery();

                DateTime thisDay = DateTime.Now;

                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into past values ('" + thisDay.ToString("d") + "', '" + thisDay.ToString("hh:mm:ss") + "', '" + actualUser + "', 'Agregó a " + textBoxUsuarioSup.Text + "')", conn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Supervisor agregado", "Mr.Pool");
                conn.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 SignIn = new Form1();
            SignIn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario from users where usuario = '" + textBoxDelUser.Text + "'", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("delete from users where usuario = '" + textBoxDelUser.Text + "'", conn);
                cm.ExecuteNonQuery();

                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("delete from cuts where usuario = '" + textBoxDelUser.Text + "'", conn);
                cm.ExecuteNonQuery();

                DateTime thisDay = DateTime.Now;

                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("insert into past values ('" + thisDay.ToString("d") + "', '" + thisDay.ToString("hh:mm:ss") + "', '" + actualUser + "',  'Eliminó a " + textBoxDelUser.Text + "')", conn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Usuario eliminado", "Mr.Pool");
                conn.Close();
            }
            else
            {
                conn.Close();
                MessageBox.Show("El usuario no existe", "Mr.Pool");
            }
        }

        private void buttonUpdatePast_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserPast.Text))
            {
                dataGridViewPast.DataSource = Consultar();
            }
            else
            {
                dataGridViewPast.DataSource = Consultar(textBoxUserPast.Text);
            }
        }

        public DataTable Consultar()
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select* from past", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        public DataTable Consultar(string nom)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select* from past where usuario = '" +textBoxUserPast.Text + "'", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        public DataTable ConsultarUsers()
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario,nombre,puesto from users", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = ConsultarUsers();
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(BoxProductISBM.Text) || string.IsNullOrEmpty(BoxProductName.Text) || string.IsNullOrEmpty(BoxProductPrice.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Mr.Pool");
            }
            else
            {
                conn.Open();
                NpgsqlCommand cm = new NpgsqlCommand("insert into products (isbn, nombre, precio) values ('" + BoxProductISBM.Text + "', '" + BoxProductName.Text + "', '" + BoxProductPrice.Text + "');", conn);
                cm.ExecuteNonQuery();

                conn.Close();
            }
            
        }

        private void ProductUpdateTable_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select isbn, nombre, precio from products", conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cm);
            DataTable Table = new DataTable();
            datos.Fill(Table);
            conn.Close();

            BoxViewTable.DataSource = Table;
        }
    }
}
