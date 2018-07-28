using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Entities;

namespace Presentation_Layer
{
    public partial class FormCreateBSC : Form
    {
        E_BalancedScorecard ObjBSC;
        public FormCreateBSC()
        {
            InitializeComponent();
            GenerateDates();
        }

        private void BtnCreateBSC_Click(object sender, EventArgs e)
        {
            bool ActivoBSC = GenerateActive(Convert.ToInt32(CmbxAgno.Text));
            DateTime year = new DateTime(Convert.ToInt32(CmbxAgno.Text), 01, 01);
            ObjBSC = new E_BalancedScorecard();
            ObjBSC.BSNombre = TxtCMI.Text = TxtCMI.Text.Trim();
            ObjBSC.N_Empresa = TxtEmpresa.Text = TxtEmpresa.Text.Trim();
            ObjBSC.Vision = TxtEmpresa.Text = TxtEmpresa.Text.Trim();
            ObjBSC.Mision = TxtMision.Text = TxtMision.Text.Trim();
            ObjBSC.Agno = year;
            ObjBSC.Active = ActivoBSC;
            if (new B_Menu().CreateBSC(ObjBSC))
            {
                //MessageBox.Show("Cuadro de Mando Integral registrado con éxito");
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();
            }

        }
        public void GenerateDates()
        {
            string idDate = DateTime.Now.ToString("yyyy");
            int InicitialDate = 2000;
            int CurrentDate = Convert.ToInt32(idDate);
            while (InicitialDate <= CurrentDate)
            {
                CmbxAgno.Items.Add(InicitialDate);
                InicitialDate += 1;
            }
            InicitialDate = InicitialDate - 1;
            CmbxAgno.Text = InicitialDate.ToString();
            
        }

        public bool GenerateActive(int date)
        {
            string idDate = DateTime.Now.ToString("yyyy");
            bool Active = false;
            if (Convert.ToInt32(idDate) == date)
            {
                Active = true;
            }
            return Active;
        }

        private void FormCreateBSC_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
