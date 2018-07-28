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
using Entities;

namespace Presentation_Layer
{
    public partial class FormLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        B_Log ObjLogIn;
        E_User ObjUser;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text=="Usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Usuario";
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

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            FormMenu frmenu;
            DataTable dt = new DataTable();
            ObjUser = new E_User();
            ObjLogIn = new B_Log();
            ObjUser.Username = TxtUser.Text;
            ObjUser.Password = TxtPass.Text;
            dt = ObjLogIn.Business_Log(ObjUser);

            if (dt.Rows.Count > 0)
            {
                B_Log.SaveCredentials(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(dt.Rows[0][1]), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
                this.Hide();
                frmenu = new FormMenu();
                frmenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void LnkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
        }

    }
}
