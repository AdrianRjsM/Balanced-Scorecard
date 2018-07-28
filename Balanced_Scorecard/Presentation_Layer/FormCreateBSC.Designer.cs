namespace Presentation_Layer
{
    partial class FormCreateBSC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreateBSC = new System.Windows.Forms.Button();
            this.TxtCMI = new System.Windows.Forms.TextBox();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.TxtVision = new System.Windows.Forms.TextBox();
            this.TxtMision = new System.Windows.Forms.TextBox();
            this.lbCMI = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.lbVision = new System.Windows.Forms.Label();
            this.lbMision = new System.Windows.Forms.Label();
            this.lbAgno = new System.Windows.Forms.Label();
            this.CmbxAgno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreateBSC
            // 
            this.BtnCreateBSC.Location = new System.Drawing.Point(272, 326);
            this.BtnCreateBSC.Name = "BtnCreateBSC";
            this.BtnCreateBSC.Size = new System.Drawing.Size(178, 37);
            this.BtnCreateBSC.TabIndex = 0;
            this.BtnCreateBSC.Text = "Crear Control de Mando Integral";
            this.BtnCreateBSC.UseVisualStyleBackColor = true;
            this.BtnCreateBSC.Click += new System.EventHandler(this.BtnCreateBSC_Click);
            // 
            // TxtCMI
            // 
            this.TxtCMI.Location = new System.Drawing.Point(61, 54);
            this.TxtCMI.MaxLength = 50;
            this.TxtCMI.Name = "TxtCMI";
            this.TxtCMI.Size = new System.Drawing.Size(232, 20);
            this.TxtCMI.TabIndex = 1;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(61, 109);
            this.TxtEmpresa.MaxLength = 50;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(232, 20);
            this.TxtEmpresa.TabIndex = 2;
            // 
            // TxtVision
            // 
            this.TxtVision.Location = new System.Drawing.Point(61, 162);
            this.TxtVision.MaxLength = 150;
            this.TxtVision.Multiline = true;
            this.TxtVision.Name = "TxtVision";
            this.TxtVision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtVision.Size = new System.Drawing.Size(232, 77);
            this.TxtVision.TabIndex = 3;
            // 
            // TxtMision
            // 
            this.TxtMision.Location = new System.Drawing.Point(428, 54);
            this.TxtMision.MaxLength = 300;
            this.TxtMision.Multiline = true;
            this.TxtMision.Name = "TxtMision";
            this.TxtMision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMision.Size = new System.Drawing.Size(257, 128);
            this.TxtMision.TabIndex = 4;
            // 
            // lbCMI
            // 
            this.lbCMI.AutoSize = true;
            this.lbCMI.Location = new System.Drawing.Point(58, 38);
            this.lbCMI.Name = "lbCMI";
            this.lbCMI.Size = new System.Drawing.Size(185, 13);
            this.lbCMI.TabIndex = 7;
            this.lbCMI.Text = "Nombre de Cuadro de Mando Integral";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(58, 93);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(113, 13);
            this.lbEmpresa.TabIndex = 8;
            this.lbEmpresa.Text = "Nombre de la empresa";
            // 
            // lbVision
            // 
            this.lbVision.AutoSize = true;
            this.lbVision.Location = new System.Drawing.Point(58, 146);
            this.lbVision.Name = "lbVision";
            this.lbVision.Size = new System.Drawing.Size(104, 13);
            this.lbVision.TabIndex = 9;
            this.lbVision.Text = "Visión de la empresa";
            // 
            // lbMision
            // 
            this.lbMision.AutoSize = true;
            this.lbMision.Location = new System.Drawing.Point(425, 38);
            this.lbMision.Name = "lbMision";
            this.lbMision.Size = new System.Drawing.Size(106, 13);
            this.lbMision.TabIndex = 10;
            this.lbMision.Text = "Misión de la empresa";
            // 
            // lbAgno
            // 
            this.lbAgno.AutoSize = true;
            this.lbAgno.Location = new System.Drawing.Point(425, 203);
            this.lbAgno.Name = "lbAgno";
            this.lbAgno.Size = new System.Drawing.Size(167, 13);
            this.lbAgno.TabIndex = 11;
            this.lbAgno.Text = "Año de Cuadro de Mando Integral";
            // 
            // CmbxAgno
            // 
            this.CmbxAgno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxAgno.FormattingEnabled = true;
            this.CmbxAgno.Location = new System.Drawing.Point(428, 219);
            this.CmbxAgno.MaxLength = 4;
            this.CmbxAgno.Name = "CmbxAgno";
            this.CmbxAgno.Size = new System.Drawing.Size(173, 21);
            this.CmbxAgno.TabIndex = 14;
            // 
            // FormCreateBSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 446);
            this.Controls.Add(this.CmbxAgno);
            this.Controls.Add(this.lbAgno);
            this.Controls.Add(this.lbMision);
            this.Controls.Add(this.lbVision);
            this.Controls.Add(this.lbEmpresa);
            this.Controls.Add(this.lbCMI);
            this.Controls.Add(this.TxtMision);
            this.Controls.Add(this.TxtVision);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtCMI);
            this.Controls.Add(this.BtnCreateBSC);
            this.MaximizeBox = false;
            this.Name = "FormCreateBSC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nuevo Balanced Scorecard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateBSC_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateBSC;
        private System.Windows.Forms.TextBox TxtCMI;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.TextBox TxtVision;
        private System.Windows.Forms.TextBox TxtMision;
        private System.Windows.Forms.Label lbCMI;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Label lbVision;
        private System.Windows.Forms.Label lbMision;
        private System.Windows.Forms.Label lbAgno;
        private System.Windows.Forms.ComboBox CmbxAgno;
    }
}