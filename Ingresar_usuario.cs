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

namespace SpotiHitssV1
{
    public partial class Ingresar_usuario : Form
    {
        public Ingresar_usuario()
        {
            InitializeComponent();
                        
        }

        private void Ingresar_usuario_Load(object sender, EventArgs e)
        {
            
            

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string UserName = Txbx_Usuario.Text;
            string PassWrd = Txbx_Password.Text;

            SqlConnection Conexion = new SqlConnection("server=HGDLAPCARRASCOJ\\SQLEXPRESS ; database=SpotiHitss ; integrated security = true");
            SqlCommand Comando = new SqlCommand("SP_Search_User", Conexion);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Add("@Nam_2Put", SqlDbType.VarChar).Value = UserName;
            Comando.Parameters.Add("@Pass_2Put", SqlDbType.VarChar).Value = PassWrd;
            Conexion.Open();
            Comando.ExecuteNonQuery();

            SqlDataReader Reader = Comando.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                MessageBox.Show("Bienvenido " + Reader.GetString(1));
                Canciones Songs = new Canciones();
                Songs.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("No se Encontro el usuario, Intente de nuevo");
            }
        }
    }
}
