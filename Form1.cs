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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro_Usuario RegUser = new Registro_Usuario();
            RegUser.Show();
            this.Hide();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Ingresar_usuario Login = new Ingresar_usuario();
            Login.Show();
            this.Hide();
        }
    }
}
