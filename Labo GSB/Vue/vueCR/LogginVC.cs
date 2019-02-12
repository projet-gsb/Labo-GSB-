using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_GSB.Vue.vueCR
{
    public partial class LogginVC : Form
    {
        public LogginVC()
        {
            InitializeComponent();
        }
        private bool utilisateurValide()
        {
            
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\gsb-gestion.mdf;
            Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) FROM visiteurcommercial WHERE mel='" + textBox1.Text + "' AND motDePasse='" + textBox2.Text + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString()== "1")
            {
                //on accede a l'application
                MessageBox.Show("Connection reussie");
            }
            else
            {
                MessageBox.Show("Utilisateur ou mot de passe incorrecte");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
