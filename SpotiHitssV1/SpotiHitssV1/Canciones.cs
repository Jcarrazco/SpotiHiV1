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
    public partial class Canciones : Form
    {
        public Canciones()
        {
            InitializeComponent();
            ComBx_Search.Items.Add("Artista");
            ComBx_Search.Items.Add("Genero");
            ComBx_Search.Items.Add("Album");
            ComBx_Search.Items.Add("Top 10 Best Likes");
        }

        private void ComBx_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string Busqueda = ComBx_Search.Text;//carga texto de combobox
            string Itm;
            if (Busqueda == "Top 10 Best Likes")//Buscar las mejores canciones por likes
            {
                SqlConnection Conexion = new SqlConnection("server=HGDLAPCARRASCOJ\\SQLEXPRESS ; database=SpotiHitss_L2 ; integrated security = true");
                SqlCommand Comando = new SqlCommand("SELECT Top(1) CanLikes.Nombre, CanLikes.NumLikes FROM [dbo].[CanLikes]", Conexion);
                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())//realiza el metodo de lectura
                    {
                        
                    }

                }
            }
        }
    }
}
