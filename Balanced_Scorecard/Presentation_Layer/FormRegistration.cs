using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Business_Logic_Layer;

namespace Presentation_Layer
{
    public partial class FormSignUp : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text=="Nombre de usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Nombre de usuario";
                TxtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Contraseña")
            {
                TxtPass.Text = "";
                TxtPass.ForeColor = Color.LightGray;
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPass.Text == "")
            {
                TxtPass.Text = "Contraseña";
                TxtPass.ForeColor = Color.DimGray;
                TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (TxtName.Text == "Nombre")
            {
                TxtName.Text = "";
                TxtName.ForeColor = Color.LightGray;
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                TxtName.Text = "Nombre";
                TxtName.ForeColor = Color.DimGray;
            }
        }

        private void TxtSurname1_Enter(object sender, EventArgs e)
        {
            if (TxtSurname1.Text == "Primer Apellido")
            {
                TxtSurname1.Text = "";
                TxtSurname1.ForeColor = Color.LightGray;
            }
        }

        private void TxtSurname1_Leave(object sender, EventArgs e)
        {
            if (TxtSurname1.Text == "")
            {
                TxtSurname1.Text = "Primer Apellido";
                TxtSurname1.ForeColor = Color.DimGray;
            }
        }

        private void TxtSurname2_Enter(object sender, EventArgs e)
        {
            if (TxtSurname2.Text == "Segundo Apellido")
            {
                TxtSurname2.Text = "";
                TxtSurname2.ForeColor = Color.LightGray;
            }
        }

        private void TxtSurname2_Leave(object sender, EventArgs e)
        {
            if (TxtSurname2.Text == "")
            {
                TxtSurname2.Text = "Segundo Apellido";
                TxtSurname2.ForeColor = Color.DimGray;
            }
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            int admin = 1;
            if (TxtUser.Text == "Nombre de usuario" || TxtPass.Text == "Contraseña" || TxtName.Text == "Nombre" ||  TxtSurname1.Text == "Primer Apellido" || TxtSurname2.Text == "Segundo Apellido")
            {
                MessageBox.Show("Alguno de los campos aún contienen sus nombres de placeholder, por lo tanto se consideran datos vacios, presione el botón [ OK ] para intentar de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = TxtUser.Text = TxtUser.Text.Trim();
                string password = TxtPass.Text = TxtPass.Text.Trim();
                string nombre = TxtName.Text = TxtName.Text.Trim();
                string surname1 = TxtSurname1.Text = TxtSurname1.Text.Trim();
                string surname2 = TxtSurname2.Text = TxtSurname2.Text.Trim();

                if (new B_Reg().ToRegister(admin, username, password, nombre, surname1, surname2))
                {
                    MessageBox.Show("El cliente fue registrado correctamente, por favor inicie sesión");
                    FormLogin login = new FormLogin();
                    this.Close();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente, por favor intente de nuevo");
                }
            }
        }

    }
}
