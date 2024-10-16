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

namespace academica
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

            private void btnIngresar_Click(object sender, EventArgs e)
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                try
                {
                    
                    string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND clave = @clave";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Bienvenido " + reader["nombre"].ToString(), "Acceso Concedido");
                        this.Hide();
                        frmLogin principal = new frmLogin();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrectos", "Acceso Denegado");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            private void txtUsuario_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
      
