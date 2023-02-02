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
    public partial class StartCut : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sefaro21; Database = Mr.Pool");
        public string usuarioCajero;
        public double total;
        public CajWindow CajW;
        public string caj;

        public StartCut(string Caj)
        {
            InitializeComponent();
            caj = Caj;  
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario, clave from users where usuario = '" + TextBoxUser.Text + "'and clave = '" + TextBoxPass.Text + "'", conn);
            NpgsqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select puesto from users where usuario = '" + TextBoxUser.Text + "'and clave = '" + TextBoxPass.Text + "'", conn);

                string puesto = Convert.ToString(cm.ExecuteScalar());

                if (puesto == "Sup")
                {
                    Cut C = new Cut(caj);
                    C.cajero = usuarioCajero;
                    C.supervisor = TextBoxUser.Text;
                    C.total = total;
                    C.labelTotal.Text = Convert.ToString(total);
                    C.CajW = CajW;
                    C.Show();
                    this.Hide();
                    conn.Close();
                }

                else
                {
                    MessageBox.Show("El usuario es de cajero, llame a un supervisor", "Mr.Pool");
                    this.Hide();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Mr.Pool");
                conn.Close();
            }
        }
    }
}
