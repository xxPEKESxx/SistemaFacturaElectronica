namespace SFE.FrontEnd
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.botonInicioSesion = new MetroFramework.Controls.MetroTile();
            this.campoTextoPassword = new MetroFramework.Controls.MetroTextBox();
            this.campoTextoUser = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.botonInicioSesion);
            this.metroPanel1.Controls.Add(this.campoTextoPassword);
            this.metroPanel1.Controls.Add(this.campoTextoUser);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(402, 346);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(215, 211);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(130, 97);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "SALIR";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.ActiveControl = null;
            this.botonInicioSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonInicioSesion.Location = new System.Drawing.Point(65, 211);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(124, 97);
            this.botonInicioSesion.Style = MetroFramework.MetroColorStyle.Yellow;
            this.botonInicioSesion.TabIndex = 4;
            this.botonInicioSesion.Text = "INICIO SESIÓN";
            this.botonInicioSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonInicioSesion.TileImage = ((System.Drawing.Image)(resources.GetObject("botonInicioSesion.TileImage")));
            this.botonInicioSesion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonInicioSesion.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.botonInicioSesion.UseSelectable = true;
            this.botonInicioSesion.UseTileImage = true;
            this.botonInicioSesion.Click += new System.EventHandler(this.botonInicioSesion_Click);
            // 
            // campoTextoPassword
            // 
            // 
            // 
            // 
            this.campoTextoPassword.CustomButton.Image = null;
            this.campoTextoPassword.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.campoTextoPassword.CustomButton.Name = "";
            this.campoTextoPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.campoTextoPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.campoTextoPassword.CustomButton.TabIndex = 1;
            this.campoTextoPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.campoTextoPassword.CustomButton.UseSelectable = true;
            this.campoTextoPassword.CustomButton.Visible = false;
            this.campoTextoPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.campoTextoPassword.Lines = new string[0];
            this.campoTextoPassword.Location = new System.Drawing.Point(65, 161);
            this.campoTextoPassword.MaxLength = 32767;
            this.campoTextoPassword.Name = "campoTextoPassword";
            this.campoTextoPassword.PasswordChar = '●';
            this.campoTextoPassword.PromptText = "Contraseña de Usuario";
            this.campoTextoPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.campoTextoPassword.SelectedText = "";
            this.campoTextoPassword.SelectionLength = 0;
            this.campoTextoPassword.SelectionStart = 0;
            this.campoTextoPassword.ShortcutsEnabled = true;
            this.campoTextoPassword.Size = new System.Drawing.Size(280, 30);
            this.campoTextoPassword.TabIndex = 3;
            this.campoTextoPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.campoTextoPassword.UseSelectable = true;
            this.campoTextoPassword.UseSystemPasswordChar = true;
            this.campoTextoPassword.WaterMark = "Contraseña de Usuario";
            this.campoTextoPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.campoTextoPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // campoTextoUser
            // 
            // 
            // 
            // 
            this.campoTextoUser.CustomButton.Image = null;
            this.campoTextoUser.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.campoTextoUser.CustomButton.Name = "";
            this.campoTextoUser.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.campoTextoUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.campoTextoUser.CustomButton.TabIndex = 1;
            this.campoTextoUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.campoTextoUser.CustomButton.UseSelectable = true;
            this.campoTextoUser.CustomButton.Visible = false;
            this.campoTextoUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.campoTextoUser.Lines = new string[0];
            this.campoTextoUser.Location = new System.Drawing.Point(65, 104);
            this.campoTextoUser.MaxLength = 32767;
            this.campoTextoUser.Name = "campoTextoUser";
            this.campoTextoUser.PasswordChar = '\0';
            this.campoTextoUser.PromptText = "Nombre De Usuario";
            this.campoTextoUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.campoTextoUser.SelectedText = "";
            this.campoTextoUser.SelectionLength = 0;
            this.campoTextoUser.SelectionStart = 0;
            this.campoTextoUser.ShortcutsEnabled = true;
            this.campoTextoUser.Size = new System.Drawing.Size(280, 30);
            this.campoTextoUser.TabIndex = 3;
            this.campoTextoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.campoTextoUser.UseSelectable = true;
            this.campoTextoUser.WaterMark = "Nombre De Usuario";
            this.campoTextoUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.campoTextoUser.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(134, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio De Sesión";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Facturacion Electronica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 390);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox campoTextoUser;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox campoTextoPassword;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile botonInicioSesion;
    }
}

