namespace Presentation_Layer
{
    partial class FormSignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PicMinimize = new System.Windows.Forms.PictureBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname1 = new System.Windows.Forms.TextBox();
            this.TxtSurname2 = new System.Windows.Forms.TextBox();
            this.LnkLogin = new System.Windows.Forms.LinkLabel();
            this.TxtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(170)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 310;
            this.lineShape5.X2 = 716;
            this.lineShape5.Y1 = 172;
            this.lineShape5.Y2 = 172;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 310;
            this.lineShape4.X2 = 716;
            this.lineShape4.Y1 = 202;
            this.lineShape4.Y2 = 202;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 310;
            this.lineShape3.X2 = 716;
            this.lineShape3.Y1 = 142;
            this.lineShape3.Y2 = 142;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 310;
            this.lineShape2.X2 = 716;
            this.lineShape2.Y1 = 112;
            this.lineShape2.Y2 = 112;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 310;
            this.lineShape1.X2 = 716;
            this.lineShape1.Y1 = 82;
            this.lineShape1.Y2 = 82;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUser.Location = new System.Drawing.Point(310, 60);
            this.TxtUser.MaxLength = 30;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(408, 20);
            this.TxtUser.TabIndex = 3;
            this.TxtUser.Text = "Nombre de usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSignUp.FlatAppearance.BorderSize = 0;
            this.BtnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSignUp.Location = new System.Drawing.Point(309, 242);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(408, 40);
            this.BtnSignUp.TabIndex = 8;
            this.BtnSignUp.Text = "Registrarse";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // PicClose
            // 
            this.PicClose.Image = global::Presentation_Layer.Properties.Resources.icon_cerrar2;
            this.PicClose.Location = new System.Drawing.Point(762, 3);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(15, 15);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClose.TabIndex = 7;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // PicMinimize
            // 
            this.PicMinimize.Image = global::Presentation_Layer.Properties.Resources.icon_minimizar;
            this.PicMinimize.Location = new System.Drawing.Point(741, 3);
            this.PicMinimize.Name = "PicMinimize";
            this.PicMinimize.Size = new System.Drawing.Size(15, 15);
            this.PicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMinimize.TabIndex = 8;
            this.PicMinimize.TabStop = false;
            this.PicMinimize.Click += new System.EventHandler(this.PicMinimize_Click);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtName.Location = new System.Drawing.Point(310, 120);
            this.TxtName.MaxLength = 30;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(408, 20);
            this.TxtName.TabIndex = 5;
            this.TxtName.Text = "Nombre";
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            this.TxtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // TxtSurname1
            // 
            this.TxtSurname1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtSurname1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSurname1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname1.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSurname1.Location = new System.Drawing.Point(310, 150);
            this.TxtSurname1.MaxLength = 30;
            this.TxtSurname1.Name = "TxtSurname1";
            this.TxtSurname1.Size = new System.Drawing.Size(408, 20);
            this.TxtSurname1.TabIndex = 6;
            this.TxtSurname1.Text = "Primer Apellido";
            this.TxtSurname1.Enter += new System.EventHandler(this.TxtSurname1_Enter);
            this.TxtSurname1.Leave += new System.EventHandler(this.TxtSurname1_Leave);
            // 
            // TxtSurname2
            // 
            this.TxtSurname2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtSurname2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSurname2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname2.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSurname2.Location = new System.Drawing.Point(310, 180);
            this.TxtSurname2.MaxLength = 30;
            this.TxtSurname2.Name = "TxtSurname2";
            this.TxtSurname2.Size = new System.Drawing.Size(408, 20);
            this.TxtSurname2.TabIndex = 7;
            this.TxtSurname2.Text = "Segundo Apellido";
            this.TxtSurname2.Enter += new System.EventHandler(this.TxtSurname2_Enter);
            this.TxtSurname2.Leave += new System.EventHandler(this.TxtSurname2_Leave);
            // 
            // LnkLogin
            // 
            this.LnkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LnkLogin.AutoSize = true;
            this.LnkLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLogin.LinkColor = System.Drawing.Color.LightGray;
            this.LnkLogin.Location = new System.Drawing.Point(433, 285);
            this.LnkLogin.Name = "LnkLogin";
            this.LnkLogin.Size = new System.Drawing.Size(166, 17);
            this.LnkLogin.TabIndex = 1;
            this.LnkLogin.TabStop = true;
            this.LnkLogin.Text = "Volver al inicio de sesión";
            this.LnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogin_LinkClicked);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPass.Location = new System.Drawing.Point(310, 90);
            this.TxtPass.MaxLength = 20;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(408, 20);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.Text = "Contraseña";
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LnkLogin);
            this.Controls.Add(this.TxtSurname2);
            this.Controls.Add(this.TxtSurname1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.PicMinimize);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignUp";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox TxtUser;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicMinimize;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox TxtName;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox TxtSurname1;
        private System.Windows.Forms.TextBox TxtSurname2;
        private System.Windows.Forms.LinkLabel LnkLogin;
        private System.Windows.Forms.TextBox TxtPass;
    }
}

