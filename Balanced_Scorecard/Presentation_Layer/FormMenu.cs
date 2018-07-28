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
    public partial class FormMenu : Form
    {
        //Librerias necesarias para poder arrastrar la interfaz del Menu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /*Variable inicial del eje "Y" que va a ir incrementandose consecutivamente según la cantidad de registros de BSC,
          se utiliza para la creación de botones dinámicos
        */
        public int y = 150;
        B_Menu objB_Menu;
        private int IdBSCGlobal;
        

        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtonsBSC();
            string CompleteName = Business_Logic_Layer.Credentials.CurUser.Name+ " " + Business_Logic_Layer.Credentials.CurUser.Surname1 +" "+ Business_Logic_Layer.Credentials.CurUser.Surname2;
            LbName.Text = CompleteName;
            LbUsername.Text = Business_Logic_Layer.Credentials.CurUser.Username;
        }

        //Evento principal de los botones que se crean dinámicamente
        private void ComunHandler_Click(object sender, EventArgs e)
        {
            string IdBSC;
            Button boton = sender as Button;
            IdBSC = boton.Name.Remove(0, 3);
            IdBSCGlobal = Convert.ToInt32(IdBSC);
            CreateInfoMenu(IdBSC);
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if (IdBSCGlobal == 0)
            {
            }
            else
            {
                FormGestorPrincipal main = new FormGestorPrincipal(IdBSCGlobal);
                main.Show();
            }
        }
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnNewBSC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateBSC crear = new FormCreateBSC();
            crear.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region "Methods"

        //Metodo para crear los botones Dinámicamente según los Balanced Scorecards que el usuario tenga creados
        public void CreateButtonsBSC()
        {
            objB_Menu = new B_Menu();
            int labelcount = 0;

            foreach (E_BalancedScorecard record in objB_Menu.BalancedScorecards(Business_Logic_Layer.Credentials.CurUser.Username))
            {

                //Se crear la instancia del boton
                Button temp = new Button();

                //Se asignan las propiedades
                temp.Height = 40;
                temp.Width = 275;
                temp.Location = new Point(0, y);
                y += 46;
                temp.Name = "Btn" + record.IdBalanced_Scorecard;
                temp.Text = record.BSNombre;
                temp.FlatStyle = FlatStyle.Flat;
                temp.FlatAppearance.BorderSize = 0;
                temp.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
                temp.ForeColor = Color.White;
                temp.Font = new Font("Century Gothic", 11, FontStyle.Italic);
                temp.Image = Properties.Resources.BalancedScorecard;
                temp.ImageAlign = ContentAlignment.MiddleLeft;
                temp.TextAlign = ContentAlignment.MiddleRight;
                temp.AutoEllipsis = true;

                //Se adiciona el handler
                temp.Click += new EventHandler(ComunHandler_Click);

                //Se agrega el boton al panel vertical
                PnlVertical.Controls.Add(temp);

                labelcount++;
            }
            CreateLabelList(labelcount);
        }

        //Metodo para crear la información principal de los Balanced Scorecards en el Menu Dinámicamente
        public void CreateInfoMenu(string idbsc)
        {
            PnlTitulo.Controls.Clear();
            PnlContainer.Controls.Clear();
            int IdBSC = Convert.ToInt32(idbsc);
            objB_Menu = new B_Menu();
            E_BalancedScorecard ObjBSCMenu = new E_BalancedScorecard();
            ObjBSCMenu = objB_Menu.B_BSC_Menu(IdBSC);
            CreateTitle(ObjBSCMenu.BSNombre);
            CreateEnterprise(ObjBSCMenu.N_Empresa);
            CreateVision(ObjBSCMenu.Vision);
            CreateMision(ObjBSCMenu.Mision);
            CreateAgno(ObjBSCMenu.Agno);
            CreateActive(ObjBSCMenu.Active);
        }

        #region "Labels Dinámicos"
        public void CreateLabelList(int value)
        {
            if (value > 1)
            {
                Label list = new Label();
                list.Location = new Point(10, 123);
                list.Height = 19;
                list.Width = 229;
                list.Font = new Font("Times New Roman", 12);
                list.Name = "LbList";
                list.Text = "Lista de Cuadros de Mando Integral";
                list.ForeColor = Color.LightCyan;

                PnlVertical.Controls.Add(list);
            }
        }

        public void CreateTitle(string NombreBSC)
        {
            Label bscname = new Label();
            bscname.Location = new Point(300, 15);
            bscname.Font = new Font("Century", 16, FontStyle.Bold);
            bscname.Name = "Lb" + NombreBSC;
            bscname.Text = NombreBSC;
            bscname.ForeColor = Color.Black;
            bscname.AutoEllipsis = true;
            bscname.AutoSize = true;
            bscname.MaximumSize = new Size(300, 70);

            PnlTitulo.Controls.Add(bscname);
        }

        public void CreateEnterprise(string Empresa)
        {
            Label bscname = new Label();
            bscname.Location = new Point(70, 95);
            bscname.Font = new Font("Century", 14);
            bscname.Name = "Lb" + Empresa;
            bscname.Text = Empresa;
            bscname.ForeColor = Color.Black;

            PnlContainer.Controls.Add(bscname);
        }

        public void CreateVision(string Vision)
        {
            Label bscname = new Label();
            bscname.Location = new Point(70, 140);
            bscname.Font = new Font("Century", 14);
            bscname.Name = "Lb" + Vision;
            bscname.Text = Vision;
            bscname.ForeColor = Color.Black;

            PnlContainer.Controls.Add(bscname);
        }

        public void CreateMision(string Mision)
        {
            Label bscname = new Label();
            bscname.Location = new Point(70, 238);
            bscname.Font = new Font("Century", 14);
            bscname.Name = "Lb" + Mision;
            bscname.Text = Mision;
            bscname.ForeColor = Color.Black;

            PnlContainer.Controls.Add(bscname);
        }

        public void CreateAgno(DateTime Agno)
        {
            Label bscname = new Label();
            bscname.Location = new Point(70, 313);
            bscname.Font = new Font("Century", 14);
            bscname.Name = "Lb" + Agno;
            bscname.Text = Agno.ToString().Remove(0, 4);
            bscname.ForeColor = Color.Black;

            PnlContainer.Controls.Add(bscname);
        }

        public void CreateActive(bool Active)
        {
            Label bscname = new Label();
            bscname.Location = new Point(70, 390);
            bscname.Font = new Font("Century", 14);
            bscname.Name = "Lb" + Active;
            if (Active)
            {
                bscname.Text = "Activo";
            }
            else
            {
                bscname.Text = "Inactivo";
            }
            bscname.ForeColor = Color.Black;

            PnlContainer.Controls.Add(bscname);
        }
        #endregion

        #endregion

        
    }
}
