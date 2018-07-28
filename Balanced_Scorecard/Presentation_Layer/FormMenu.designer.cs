namespace Presentation_Layer
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlVertical = new System.Windows.Forms.Panel();
            this.BtnNewBSC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicBoxExit = new System.Windows.Forms.PictureBox();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.PnlUser = new System.Windows.Forms.Panel();
            this.PicBUser = new System.Windows.Forms.PictureBox();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbEmpresa = new System.Windows.Forms.Label();
            this.LbVision = new System.Windows.Forms.Label();
            this.LbMision = new System.Windows.Forms.Label();
            this.LbAgno = new System.Windows.Forms.Label();
            this.LbActivo = new System.Windows.Forms.Label();
            this.PnlVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxExit)).BeginInit();
            this.PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBUser)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlVertical
            // 
            this.PnlVertical.AutoScroll = true;
            this.PnlVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(170)))));
            this.PnlVertical.Controls.Add(this.BtnNewBSC);
            this.PnlVertical.Controls.Add(this.label1);
            this.PnlVertical.Location = new System.Drawing.Point(0, 0);
            this.PnlVertical.Name = "PnlVertical";
            this.PnlVertical.Size = new System.Drawing.Size(292, 573);
            this.PnlVertical.TabIndex = 0;
            // 
            // BtnNewBSC
            // 
            this.BtnNewBSC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNewBSC.FlatAppearance.BorderSize = 0;
            this.BtnNewBSC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnNewBSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewBSC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewBSC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnNewBSC.Image = global::Presentation_Layer.Properties.Resources.BalancedScorecard;
            this.BtnNewBSC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNewBSC.Location = new System.Drawing.Point(3, 45);
            this.BtnNewBSC.Name = "BtnNewBSC";
            this.BtnNewBSC.Size = new System.Drawing.Size(69, 65);
            this.BtnNewBSC.TabIndex = 4;
            this.BtnNewBSC.Text = "Crear";
            this.BtnNewBSC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNewBSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewBSC.UseVisualStyleBackColor = true;
            this.BtnNewBSC.Click += new System.EventHandler(this.BtnNewBSC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Mando Integral";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlTitulo.Location = new System.Drawing.Point(292, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(643, 73);
            this.PnlTitulo.TabIndex = 1;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.icon_minimizar;
            this.pictureBox1.Location = new System.Drawing.Point(941, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicBoxExit
            // 
            this.PicBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxExit.Image = global::Presentation_Layer.Properties.Resources.icon_cerrar2;
            this.PicBoxExit.Location = new System.Drawing.Point(964, 0);
            this.PicBoxExit.Name = "PicBoxExit";
            this.PicBoxExit.Size = new System.Drawing.Size(20, 20);
            this.PicBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxExit.TabIndex = 5;
            this.PicBoxExit.TabStop = false;
            this.PicBoxExit.Click += new System.EventHandler(this.PicBoxExit_Click);
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlContainer.Location = new System.Drawing.Point(471, 70);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(513, 509);
            this.PnlContainer.TabIndex = 2;
            // 
            // PnlUser
            // 
            this.PnlUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlUser.Controls.Add(this.PicBUser);
            this.PnlUser.Location = new System.Drawing.Point(295, 0);
            this.PnlUser.Name = "PnlUser";
            this.PnlUser.Size = new System.Drawing.Size(94, 93);
            this.PnlUser.TabIndex = 6;
            // 
            // PicBUser
            // 
            this.PicBUser.Image = global::Presentation_Layer.Properties.Resources.boss_man_128;
            this.PicBUser.Location = new System.Drawing.Point(-3, 0);
            this.PicBUser.Name = "PicBUser";
            this.PicBUser.Size = new System.Drawing.Size(96, 90);
            this.PicBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBUser.TabIndex = 0;
            this.PicBUser.TabStop = false;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlBottom.Controls.Add(this.BtnAdmin);
            this.PnlBottom.Location = new System.Drawing.Point(292, 523);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(692, 50);
            this.PnlBottom.TabIndex = 3;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(314, 15);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(75, 23);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.Text = "Administrar";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(298, 97);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(62, 16);
            this.LbUsername.TabIndex = 7;
            this.LbUsername.Text = "Username";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(298, 113);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(41, 16);
            this.LbName.TabIndex = 8;
            this.LbName.Text = "Name";
            // 
            // LbEmpresa
            // 
            this.LbEmpresa.AutoSize = true;
            this.LbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpresa.Location = new System.Drawing.Point(375, 171);
            this.LbEmpresa.Name = "LbEmpresa";
            this.LbEmpresa.Size = new System.Drawing.Size(68, 18);
            this.LbEmpresa.TabIndex = 9;
            this.LbEmpresa.Text = "Empresa";
            // 
            // LbVision
            // 
            this.LbVision.AutoSize = true;
            this.LbVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbVision.Location = new System.Drawing.Point(375, 214);
            this.LbVision.Name = "LbVision";
            this.LbVision.Size = new System.Drawing.Size(48, 18);
            this.LbVision.TabIndex = 10;
            this.LbVision.Text = "Visión";
            // 
            // LbMision
            // 
            this.LbMision.AutoSize = true;
            this.LbMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMision.Location = new System.Drawing.Point(375, 314);
            this.LbMision.Name = "LbMision";
            this.LbMision.Size = new System.Drawing.Size(52, 18);
            this.LbMision.TabIndex = 11;
            this.LbMision.Text = "Misión";
            // 
            // LbAgno
            // 
            this.LbAgno.AutoSize = true;
            this.LbAgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAgno.Location = new System.Drawing.Point(375, 390);
            this.LbAgno.Name = "LbAgno";
            this.LbAgno.Size = new System.Drawing.Size(34, 18);
            this.LbAgno.TabIndex = 12;
            this.LbAgno.Text = "Año";
            // 
            // LbActivo
            // 
            this.LbActivo.AutoSize = true;
            this.LbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbActivo.Location = new System.Drawing.Point(375, 466);
            this.LbActivo.Name = "LbActivo";
            this.LbActivo.Size = new System.Drawing.Size(48, 18);
            this.LbActivo.TabIndex = 13;
            this.LbActivo.Text = "Activo";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 573);
            this.Controls.Add(this.LbActivo);
            this.Controls.Add(this.LbAgno);
            this.Controls.Add(this.LbMision);
            this.Controls.Add(this.LbVision);
            this.Controls.Add(this.LbEmpresa);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlUser);
            this.Controls.Add(this.PicBoxExit);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlVertical.ResumeLayout(false);
            this.PnlVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxExit)).EndInit();
            this.PnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBUser)).EndInit();
            this.PnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlVertical;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNewBSC;
        private System.Windows.Forms.PictureBox PicBoxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlUser;
        private System.Windows.Forms.PictureBox PicBUser;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbEmpresa;
        private System.Windows.Forms.Label LbVision;
        private System.Windows.Forms.Label LbMision;
        private System.Windows.Forms.Label LbAgno;
        private System.Windows.Forms.Label LbActivo;
    }
}

