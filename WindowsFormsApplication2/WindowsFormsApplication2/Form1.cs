using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=luzbd;User=luzgod;Password=12345;");
        public Form1()
        {
            InitializeComponent();
            ActualizarDataGridView();
            this.Font = new Font("Courier", 10, FontStyle.Regular);
            this.BackColor = ColorTranslator.FromHtml("#d5e2cd");
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = info();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
        public DataTable info()
        {
            DataTable datos = new DataTable();

            con.Open();

            string llenar = "SELECT * FROM usuarios  WHERE nombre_usuario != 'ELIMINADO';";

            MySqlCommand com = new MySqlCommand(llenar, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(com);
            dat.Fill(datos);

            con.Close();
            return datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            int resultado = ws.agregarUsuario(textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text, int.Parse(textBox9.Text));
            //String usuario, String contra, String rol, int ci, String nom, String direc, String depa, int telf
            if (resultado == 1)
            {
                MessageBox.Show("Usuario creado correctamente.");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //editar
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            int resultado = ws.editarUsuario(textBox2.Text, textBox6.Text, textBox7.Text, textBox8.Text, int.Parse(textBox9.Text));
            
            if (resultado == 1)
            {
                MessageBox.Show("Usuario editado correctamente.");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error al editar el usuario.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //eliminar
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            int resultado = ws.eliminarUsuario(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);

            if (resultado == 1)
            {
                MessageBox.Show("Usuario eliminado correctamente.");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario.");
            }
        }
    }
}
