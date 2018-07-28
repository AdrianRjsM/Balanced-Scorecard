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
    struct IndiDg
    {
        public int IdIndicador { get; set; }
        public string Perspectiva { get; set; }
        public string Indicador { get; set; }
        public string Valor { get; set; }
        public string MaxMin { get; set; }
        public string Activo { get; set; }
    }

    struct ObjeDg
    {
        public int IdObjetive { get; set; }
        public string Perspective { get; set; }
        public string Objective { get; set; }
        public string Indicator { get; set; }
        public string Value { get; set; }
        public string MaxMin { get; set; }
        public string Active { get; set; }
    }

    struct ControlObjeDg
    {
        public int IdValorObjetivo { get; set; }
        public string Perspectiva { get; set; }
        public string Objetivo { get; set; }
        public string Mes { get; set; }
        public int IdObjetivo { get; set; }
        public string Meta { get; set; }
        public string Alcanzado { get; set; }
        public int IdMes { get; set; }
        public string Valor { get; set; }
        public string TipoDato { get; set; }
        public string MaxMin { get; set; }
        public string Indicador { get; set; }
    }
    public partial class FormGestorPrincipal : Form
    {
        B_Indicador B_ObjIndicador;
        B_Objective B_ObjObjective;
        B_Metrica B_ObjMetrica;
        B_CObjectives B_ObjCObjectives;
        E_Indicador ObjIndicator;
        E_Objetivo ObjObjetive;
        E_Metrica ObjMetrica;
        E_ObjectiveControl ObjControl;
        List<IndiDg> ListIndicator;
        List<ObjeDg> ListObjective;
        List<E_Metrica> ListMetrica;
        List<ControlObjeDg> ListControlObje;
        
        public int IdBalancedScorecard;
        public FormGestorPrincipal(int IdBalancedScorecard)
        {
            InitializeComponent();
            this.IdBalancedScorecard = IdBalancedScorecard;
        }

        private void FormGestorPrincipal_Load(object sender, EventArgs e)
        {
            LoadCmbxMaxMin();
            LoadCmbxValueIndicator();
            LoadCmbxPerspective(IdBalancedScorecard);
            LoadCmbxActivo();
            I_LoadDataGridView();
            LoadCmbxO_Perspectives(IdBalancedScorecard);
            LoadCmbxO_Activo();
            LoadCmbxO_Indicators();
            O_LoadDataGridView();
            LoadCmbxM_Objectives();
            LoadCmbxCOObjectives();
            LoadCmbxCOMonths();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bool ActiveIndicator = (CmbxActivo.Text == "Activo") ? true : false;
            ObjIndicator = new E_Indicador();
            ObjIndicator.Indicador = TxtIndicador.Text = TxtIndicador.Text.Trim();
            ObjIndicator.IdTipoValor = Convert.ToInt32(CmbxValor.SelectedValue);
            ObjIndicator.IdMaxMin = Convert.ToInt32(CmbxMaxMin.SelectedValue);
            ObjIndicator.IdPerspectiva = Convert.ToInt32(CmbxPerspectiva.SelectedValue);
            ObjIndicator.Activo = ActiveIndicator;

            if (new B_Indicador().CreateIndicator(ObjIndicator))
            {
                I_LoadDataGridView();
                I_CleanData();
                LoadCmbxO_Indicators();
            }
            else
            {
                MessageBox.Show("No se insertó la información en la base de datos, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region "MethodsCmbx"
        public async void LoadCmbxMaxMin()
        {
            B_ObjIndicador = new B_Indicador();

            CmbxMaxMin.DisplayMember = "Descripcion";
            CmbxMaxMin.ValueMember = "IdTipoMaxMin_Indicador";
            CmbxMaxMin.DataSource = await B_ObjIndicador.B_GetMaxMinIndicator();
        }

        public async void LoadCmbxValueIndicator()
        {
            B_ObjIndicador = new B_Indicador();

            CmbxValor.DisplayMember = "Valor";
            CmbxValor.ValueMember = "IdTipoValor_Indicador";
            CmbxValor.DataSource = await B_ObjIndicador.B_GetValueIndicator();
        }

        public async void LoadCmbxPerspective(int IdBSC)
        {
            B_ObjIndicador = new B_Indicador();
            
            CmbxPerspectiva.DisplayMember = "P_Nombre";
            CmbxPerspectiva.ValueMember = "IdPerspectiva";
            CmbxPerspectiva.DataSource = await B_ObjIndicador.B_GetPerspective(IdBSC);
        }

        public void LoadCmbxActivo()
        {
            CmbxActivo.Items.Add("Activo");
            CmbxActivo.Items.Add("Inactivo");
            CmbxActivo.Text = (CmbxActivo.Items[0] as dynamic);
        }

        //Comboboxs de Objetivos
        public async void LoadCmbxO_Perspectives(int IdBSC)
        {
            B_ObjIndicador = new B_Indicador();

            CmbxO_Perspectiva.DisplayMember = "P_Nombre";
            CmbxO_Perspectiva.ValueMember = "IdPerspectiva";
            CmbxO_Perspectiva.DataSource = await B_ObjIndicador.B_GetPerspective(IdBSC);
        }

        public void LoadCmbxO_Activo()
        {
            CmbxO_Activo.Items.Add("Activo");
            CmbxO_Activo.Items.Add("Inactivo");
            CmbxO_Activo.Text = (CmbxO_Activo.Items[0] as dynamic);
        }

        public async void LoadCmbxO_Indicators()
        {
            B_ObjObjective = new B_Objective();

            CmbxO_Indicador.DisplayMember = "Indicador";
            CmbxO_Indicador.ValueMember = "IdIndicador";
            CmbxO_Indicador.DataSource = await B_ObjObjective.B_GetO_Indicators(IdBalancedScorecard);
        }

        //Combobox de Metricas
        public async void LoadCmbxM_Objectives()
        {
            B_ObjMetrica = new B_Metrica();

            CmbxM_Objetivos.DisplayMember = "Objetivo";
            CmbxM_Objetivos.ValueMember = "IdObjetivo";
            CmbxM_Objetivos.DataSource = await B_ObjMetrica.B_GetObjectives(IdBalancedScorecard);
        }

        //Combobox de Control de Objetivos
        public async void LoadCmbxCOObjectives()
        {
            B_ObjMetrica = new B_Metrica();

            Cmbx_COObjetivos.DisplayMember = "Objetivo";
            Cmbx_COObjetivos.ValueMember = "IdObjetivo";
            Cmbx_COObjetivos.DataSource = await B_ObjMetrica.B_GetObjectives(IdBalancedScorecard);
        }

        //Combobox de los Meses de Control de Objetivos
        public async void LoadCmbxCOMonths()
        {
            B_ObjCObjectives = new B_CObjectives();

            Cmbx_COMes.DisplayMember = "Mes";
            Cmbx_COMes.ValueMember = "IdMes";
            Cmbx_COMes.DataSource = await B_ObjCObjectives.B_GetMonths();
        }
        #endregion

        public async void I_LoadDataGridView()
        {
            ListIndicator = new List<IndiDg>();
            B_ObjIndicador = new B_Indicador();
            foreach (E_IndicatorDg item in await B_ObjIndicador.QueryToDg(IdBalancedScorecard))
            {
                IndiDg ResultDg = new IndiDg();
                ResultDg.IdIndicador = item.IdIndicador;
                ResultDg.Perspectiva = item.Perspectiva;
                ResultDg.Indicador = item.Indicador;
                ResultDg.Valor = item.Valor;
                ResultDg.MaxMin = item.MaxMin;
                ResultDg.Activo = (item.Activo == true) ? "Si" : "No";
                ListIndicator.Add(ResultDg);
            }
            DtgvIndicadores.DataSource = ListIndicator.ToList();

        }

        public void I_CleanData()
        {
            TxtIndicador.Clear();
            TxtIdIndicador.Clear();
            CmbxActivo.SelectedIndex = 0;
            CmbxMaxMin.SelectedIndex = 0;
            CmbxPerspectiva.SelectedIndex = 0;
            CmbxValor.SelectedIndex = 0;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            B_ObjIndicador = new B_Indicador();
            B_ObjIndicador.B_UpdateIndicator(CreateIndicator());
            I_LoadDataGridView();
            I_CleanData();
        }

        public E_Indicador CreateIndicator()
        {
            bool ActiveIndicator = (CmbxActivo.Text == "Activo") ? true : false;
            ObjIndicator = new E_Indicador();
            try
            {
                ObjIndicator.IdIndicador = Convert.ToInt32(TxtIdIndicador.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningún registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ObjIndicator.Indicador = TxtIndicador.Text = TxtIndicador.Text.Trim();
            ObjIndicator.IdTipoValor = Convert.ToInt32(CmbxValor.SelectedValue);
            ObjIndicator.IdMaxMin = Convert.ToInt32(CmbxMaxMin.SelectedValue);
            ObjIndicator.IdPerspectiva = Convert.ToInt32(CmbxPerspectiva.SelectedValue);
            ObjIndicator.Activo = ActiveIndicator;

            return ObjIndicator;
        }

        void I_RegistroSeleccionado()
        {
            TxtIdIndicador.Text = DtgvIndicadores.CurrentRow.Cells["dgIdIndicador"].Value.ToString();
            TxtIndicador.Text = DtgvIndicadores.CurrentRow.Cells["dgIndicador"].Value.ToString();
            CmbxMaxMin.Text = DtgvIndicadores.CurrentRow.Cells["dgMaxMin"].Value.ToString();
            CmbxPerspectiva.Text = DtgvIndicadores.CurrentRow.Cells["dgPerspectiva"].Value.ToString();
            CmbxValor.Text = DtgvIndicadores.CurrentRow.Cells["dgValorIndicador"].Value.ToString();
            CmbxActivo.Text = (DtgvIndicadores.CurrentRow.Cells["dgActivo"].Value.ToString() == "Si") ? "Activo" : "Inactivo";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            B_ObjIndicador = new B_Indicador();
            B_ObjIndicador.B_DeleteIndicator(CreateIndicator());
            I_LoadDataGridView();
            I_CleanData();
        }

        private void DtgvIndicadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            I_RegistroSeleccionado();
        }

        //TabControl Objetivos
        private void BtnO_Agregar_Click(object sender, EventArgs e)
        {
            B_ObjObjective = new B_Objective();
            bool ActiveObjective = (CmbxO_Activo.Text == "Activo") ? true : false;
            ObjObjetive = new E_Objetivo();
            ObjObjetive.Objetivo = TxtObjetivo.Text = TxtObjetivo.Text.Trim();
            ObjObjetive.IdIndicador = Convert.ToInt32(CmbxO_Indicador.SelectedValue);
            ObjObjetive.IdPerspectiva = Convert.ToInt32(CmbxO_Perspectiva.SelectedValue);
            ObjObjetive.Activo = ActiveObjective;
            if (B_ObjObjective.B_CreateObjetive(ObjObjetive))
            {
                //MessageBox.Show("Objetivo registrado correctamente");
                O_LoadDataGridView();
                O_CleanData();
                LoadCmbxM_Objectives();
                LoadCmbxCOObjectives();
            }
            else
            {
                MessageBox.Show("Objetivo no registrado");
            }
            //LoadDataGridView();
            //CleanData();
        }

        public E_Objetivo CreateObjetive()
        {
            bool ActiveObjective = (CmbxO_Activo.Text == "Activo") ? true : false;
            ObjObjetive = new E_Objetivo();
            try
            {
                ObjObjetive.IdObjetivo = Convert.ToInt32(TxtIdObjetivo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningún registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ObjObjetive.Objetivo = TxtObjetivo.Text = TxtObjetivo.Text.Trim();
            ObjObjetive.IdIndicador = Convert.ToInt32(CmbxO_Indicador.SelectedValue);
            ObjObjetive.IdPerspectiva = Convert.ToInt32(CmbxO_Perspectiva.SelectedValue);
            ObjObjetive.Activo = ActiveObjective;
            return ObjObjetive;
        }

        private void BtnO_Modificar_Click(object sender, EventArgs e)
        {
            B_ObjObjective = new B_Objective();
            B_ObjObjective.B_UpdateObjective(CreateObjetive());
            O_LoadDataGridView();
            O_CleanData();
        }

        private void BtnO_Eliminar_Click(object sender, EventArgs e)
        {
            B_ObjObjective = new B_Objective();
            B_ObjObjective.B_DeleteObjective(CreateObjetive());
            O_LoadDataGridView();
            O_CleanData();
        }

        public async void O_LoadDataGridView()
        {
            ListObjective = new List<ObjeDg>();
            B_ObjObjective = new B_Objective();
            foreach (E_ObjectivesDg item in await B_ObjObjective.QueryToObjectiveDg(IdBalancedScorecard))
            {
                ObjeDg ResultDg = new ObjeDg();
                ResultDg.IdObjetive = item.IdObjective;
                ResultDg.Perspective = item.Perspective;
                ResultDg.Objective = item.Objetive;
                ResultDg.Indicator = item.Indicator;
                ResultDg.Value = item.Value;
                ResultDg.MaxMin = item.MaxMin;
                ResultDg.Active = (item.Active == true) ? "Si" : "No";
                ListObjective.Add(ResultDg);
            }
            DtgvObjectives.DataSource = ListObjective.ToList();
        }

        void O_RegistroSeleccionado()
        {
            TxtIdObjetivo.Text = DtgvObjectives.CurrentRow.Cells["dgIdObjetivo"].Value.ToString();
            TxtObjetivo.Text = DtgvObjectives.CurrentRow.Cells["dgObjetivo"].Value.ToString();
            CmbxO_Perspectiva.Text = DtgvObjectives.CurrentRow.Cells["dgO_Perspectiva"].Value.ToString();
            CmbxO_Indicador.Text = DtgvObjectives.CurrentRow.Cells["dgO_Indicador"].Value.ToString();
            CmbxO_Activo.Text = (DtgvObjectives.CurrentRow.Cells["dgO_Activo"].Value.ToString() == "Si") ? "Activo" : "Inactivo";
        }

        private void DtgvObjectives_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            O_RegistroSeleccionado();
        }

        public void O_CleanData()
        {
            TxtIdObjetivo.Clear();
            TxtObjetivo.Clear();
            CmbxO_Perspectiva.SelectedIndex = 0;
            CmbxO_Indicador.SelectedIndex = 0;
            CmbxO_Activo.SelectedIndex = 0;
        }

        //TabControl Metricas
        private void BtnM_Agregar_Click(object sender, EventArgs e)
        {
            B_ObjMetrica = new B_Metrica();
            ObjMetrica = new E_Metrica();
            ObjMetrica.Metrica = TxtMetrica.Text = TxtMetrica.Text.Trim();
            ObjMetrica.IdObjective = Convert.ToInt32(CmbxM_Objetivos.SelectedValue);
            if (B_ObjMetrica.B_CreateMetrica(ObjMetrica))
            {
                M_CleanData();
                M_LoadDataGridView(Convert.ToInt32(CmbxM_Objetivos.SelectedValue));
                //MessageBox.Show("Metrica registrado correctamente");

            }
            else
            {
                MessageBox.Show("Metrica no registrado");
            }
        }

        private void BtnM_Modificar_Click(object sender, EventArgs e)
        {
            B_ObjMetrica = new B_Metrica();
            B_ObjMetrica.B_UpdateMetrica(CreateMetrica());
            M_LoadDataGridView(Convert.ToInt32(CmbxM_Objetivos.SelectedValue));
            //O_CleanData();
        }

        private void BtnM_Eliminar_Click(object sender, EventArgs e)
        {
            B_ObjMetrica = new B_Metrica();
            B_ObjMetrica.B_DeleteMetrica(CreateMetrica());
            M_CleanData();
            M_LoadDataGridView(Convert.ToInt32(CmbxM_Objetivos.SelectedValue));
        }

        public async void M_LoadDataGridView(int IdCmbxValueObjective)
        {
            B_ObjMetrica = new B_Metrica();
            ListMetrica = new List<E_Metrica>();
            foreach (E_Metrica item in await B_ObjMetrica.QueryToMetricaDg(IdCmbxValueObjective))
            {
                ListMetrica.Add(item);
            }
            DtgvMetricas.DataSource = ListMetrica.ToList();
        }

        private void CmbxM_Objetivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            M_LoadDataGridView(Convert.ToInt32(CmbxM_Objetivos.SelectedValue));
        }

        private void DtgvMetricas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            M_RegistroSeleccionado();
        }

        void M_RegistroSeleccionado()
        {
            TxtIdMetrica.Text = DtgvMetricas.CurrentRow.Cells["dgM_IdMetrica"].Value.ToString();
            TxtMetrica.Text = DtgvMetricas.CurrentRow.Cells["dgM_Metrica"].Value.ToString();
            CmbxM_Objetivos.Text = DtgvMetricas.CurrentRow.Cells["dgM_Objetivo"].Value.ToString();
        }

        public E_Metrica CreateMetrica()
        {
            ObjMetrica = new E_Metrica();
            try
            {
                ObjMetrica.IdMetrica = Convert.ToInt32(TxtIdMetrica.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningún registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ObjMetrica.Metrica = TxtMetrica.Text = TxtMetrica.Text.Trim();
            ObjMetrica.IdObjective = Convert.ToInt32(CmbxM_Objetivos.SelectedValue);
            return ObjMetrica;
        }

        public void M_CleanData()
        {
            TxtMetrica.Clear();
            TxtIdMetrica.Clear();
            //CmbxM_Objetivos.SelectedIndex = 0;
        }

        //TabControl Control de Objetivos
        private void Btn_COAgregar_Click(object sender, EventArgs e)
        {
            B_ObjCObjectives = new B_CObjectives();
            ObjControl = new E_ObjectiveControl();
            ObjControl.Meta = Txt_COValorObjetivo.Text = Txt_COValorObjetivo.Text.Trim();
            ObjControl.Alcanzado = Txt_COValorReal.Text = Txt_COValorReal.Text.Trim();
            ObjControl.IdMes = Convert.ToInt32(Cmbx_COMes.SelectedValue);
            ObjControl.IdObjetivo = Convert.ToInt32(Cmbx_COObjetivos.SelectedValue);
            if (B_ObjCObjectives.B_CreateCObjective(ObjControl))
            {
                CO_CleanData();
                OControl_LoadDataGridView(Convert.ToInt32(Cmbx_COObjetivos.SelectedValue));
                //MessageBox.Show("Valor objetivo registrado correctamente");

            }
            else
            {
                MessageBox.Show("Control de objetivo no registrado");
            }
        }

        public void CO_CleanData()
        {
            Txt_COValorObjetivo.Clear();
            Txt_COValorReal.Clear();
            Cmbx_COMes.SelectedIndex = 0;
        }

        public async void OControl_LoadDataGridView(int IdObjective)
        {
            ListControlObje = new List<ControlObjeDg>();
            B_ObjCObjectives = new B_CObjectives();
            foreach (E_ObjectiveControl item in await B_ObjCObjectives.QueryToOCDg(IdObjective))
            {
                ControlObjeDg ResultDg = new ControlObjeDg();
                ResultDg.IdValorObjetivo = item.IdValorObjetivo;
                ResultDg.Perspectiva = item.Perspectiva;
                ResultDg.Objetivo = item.Objetivo;
                ResultDg.Mes = item.Mes;
                ResultDg.IdObjetivo = item.IdObjetivo;
                ResultDg.Meta = item.Meta;
                ResultDg.Alcanzado = item.Alcanzado;
                ResultDg.IdMes = item.IdMes;
                ResultDg.Valor = item.Valor;
                ResultDg.TipoDato = item.TipoDato;
                ResultDg.MaxMin = item.MaxMin;
                ResultDg.Indicador = item.Indicador;
                ListControlObje.Add(ResultDg);
            }
            DtgvControlOb.DataSource = ListControlObje.ToList();
        }

        private void Cmbx_COObjetivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            OControl_LoadDataGridView(Convert.ToInt32(Cmbx_COObjetivos.SelectedValue));
        }

        private void Btn_COModificar_Click(object sender, EventArgs e)
        {
            B_ObjCObjectives = new B_CObjectives();
            B_ObjCObjectives.B_UpdateOControl(CreateControlObj());
            OControl_LoadDataGridView(Convert.ToInt32(Cmbx_COObjetivos.SelectedValue));
            //O_CleanData();
        }

        public E_ObjectiveControl CreateControlObj()
        {
            ObjControl = new E_ObjectiveControl();
            try
            {
                ObjControl.IdValorObjetivo = Convert.ToInt32(TxtIdValorObjetivo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningún registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ObjControl.Meta = Txt_COValorObjetivo.Text = Txt_COValorObjetivo.Text.Trim();
            ObjControl.Alcanzado = Txt_COValorReal.Text = Txt_COValorReal.Text.Trim();
            ObjControl.IdObjetivo = Convert.ToInt32(Cmbx_COObjetivos.SelectedValue);
            ObjControl.IdMes = Convert.ToInt32(Cmbx_COMes.SelectedValue);

            return ObjControl;
        }

        void CO_RegistroSeleccionado()
        {
            Txt_COValorObjetivo.Text = DtgvControlOb.CurrentRow.Cells["dg_COValorObjetivo"].Value.ToString();
            TxtIdValorObjetivo.Text = DtgvControlOb.CurrentRow.Cells["dg_COIdValorObjetivo"].Value.ToString();
            Txt_COValorReal.Text = DtgvControlOb.CurrentRow.Cells["dg_COValorReal"].Value.ToString();
            Cmbx_COMes.Text = DtgvControlOb.CurrentRow.Cells["dg_COMes"].Value.ToString();
        }

        private void DtgvControlOb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CO_RegistroSeleccionado();
        }
    }
}
