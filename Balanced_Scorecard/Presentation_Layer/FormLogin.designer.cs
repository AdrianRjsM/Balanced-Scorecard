namespace Presentation_Layer
{
    partial class FormLogin
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
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccess = new System.Windows.Forms.Button();
            this.LnkPass = new System.Windows.Forms.LinkLabel();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PicMinimize = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 310;
            this.lineShape2.X2 = 717;
            this.lineShape2.Y1 = 151;
            this.lineShape2.Y2 = 151;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 310;
            this.lineShape1.X2 = 717;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 100;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUser.Location = new System.Drawing.Point(310, 79);
            this.TxtUser.MaxLength = 30;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(408, 20);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Text = "Usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPass.Location = new System.Drawing.Point(310, 131);
            this.TxtPass.MaxLength = 20;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(408, 20);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "Contraseña";
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar Sesión";
            // 
            // BtnAccess
            // 
            this.BtnAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAccess.FlatAppearance.BorderSize = 0;
            this.BtnAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccess.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAccess.Location = new System.Drawing.Point(310, 221);
            this.BtnAccess.Name = "BtnAccess";
            this.BtnAccess.Size = new System.Drawing.Size(408, 40);
            this.BtnAccess.TabIndex = 3;
            this.BtnAccess.Text = "Acceder";
            this.BtnAccess.UseVisualStyleBackColor = false;
            this.BtnAccess.Click += new System.EventHandler(this.BtnAccess_Click);
            // 
            // LnkPass
            // 
            this.LnkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LnkPass.AutoSize = true;
            this.LnkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkPass.LinkColor = System.Drawing.Color.LightGray;
            this.LnkPass.Location = new System.Drawing.Point(544, 264);
            this.LnkPass.Name = "LnkPass";
            this.LnkPass.Size = new System.Drawing.Size(74, 17);
            this.LnkPass.TabIndex = 0;
            this.LnkPass.TabStop = true;
            this.LnkPass.Text = "Regístrese!";
            this.LnkPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPass_LinkClicked);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(398, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "¿Aún no es miembro?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicMinimize);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.LnkPass);
            this.Controls.Add(this.BtnAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox TxtPass;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccess;
        private System.Windows.Forms.LinkLabel LnkPass;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicMinimize;
        private System.Windows.Forms.Label label2;
    }
}

