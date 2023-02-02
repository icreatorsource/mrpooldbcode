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
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sefaro21; Database = Mr.Pool");
        public Form1()
        {
            InitializeComponent();
        }
        private void login()
        {
            conn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select usuario, clave from users where usuario = '" +TextBoxUser.Text+ "'and clave = '" +TextBoxPass.Text+ "'" , conn);
            NpgsqlDataReader dr = cm.ExecuteReader();

            if(dr.Read())
            {
                conn.Close();
                conn.Open();
                cm = new NpgsqlCommand("select puesto from users where usuario = '" + TextBoxUser.Text + "'and clave = '" + TextBoxPass.Text + "'", conn);

                string puesto = Convert.ToString(cm.ExecuteScalar());

                if (puesto == "Sup")
                {
                    MessageBox.Show("Bienvenido "+ TextBoxUser.Text +"", "Mr.Pool");
                    this.Hide();
                    SupWindow SupW = new SupWindow();
                    SupW.actualUser = TextBoxUser.Text;
                    SupW.labelSupervisorUser.Text = TextBoxUser.Text;
                    SupW.Show();
                    conn.Close();
                }

                else
                {
                    string NOM, VENT;

                    MessageBox.Show("Bienvenido " + TextBoxUser.Text + "", "Mr.Pool");
                    this.Hide();
                    
                    
                    conn.Close();


                    conn.Open();
                    cm = new NpgsqlCommand("select nombre from users where usuario = '" + TextBoxUser.Text + "'", conn);
                    NOM = Convert.ToString(cm.ExecuteScalar());
                    conn.Close();

                    conn.Open();
                    cm = new NpgsqlCommand("select totalventa from cuts where usuario = '" + TextBoxUser.Text + "'", conn);
                    VENT = Convert.ToString(cm.ExecuteScalar());

                    if (String.IsNullOrEmpty(VENT))
                        VENT = "0.";
                    
                    conn.Close();

                    CajWindow CajW = new CajWindow(TextBoxUser.Text,NOM,VENT);
                    CajW.actualUser = TextBoxUser.Text;
                    CajW.labelCajeroUser.Text = TextBoxUser.Text;
                    CajW.Show();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Mr.Pool");
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
