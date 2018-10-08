namespace SFE.FrontEnd
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabSalir = new MetroFramework.Controls.MetroTile();
            this.tabUsuarios = new MetroFramework.Controls.MetroTile();
            this.tabCierre = new MetroFramework.Controls.MetroTile();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tab_principal = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tab_principal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 480);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabSalir);
            this.flowLayoutPanel1.Controls.Add(this.tabCierre);
            this.flowLayoutPanel1.Controls.Add(this.tabUsuarios);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 397);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(822, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabSalir
            // 
            this.tabSalir.ActiveControl = null;
            this.tabSalir.Location = new System.Drawing.Point(627, 3);
            this.tabSalir.Name = "tabSalir";
            this.tabSalir.Size = new System.Drawing.Size(192, 71);
            this.tabSalir.TabIndex = 1;
            this.tabSalir.Text = "SALIR";
            this.tabSalir.TileImage = ((System.Drawing.Image)(resources.GetObject("tabSalir.TileImage")));
            this.tabSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabSalir.UseSelectable = true;
            this.tabSalir.UseTileImage = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.ActiveControl = null;
            this.tabUsuarios.Location = new System.Drawing.Point(231, 3);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(192, 71);
            this.tabUsuarios.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tabUsuarios.TabIndex = 2;
            this.tabUsuarios.Text = "CONTACTENOS";
            this.tabUsuarios.TileImage = ((System.Drawing.Image)(resources.GetObject("tabUsuarios.TileImage")));
            this.tabUsuarios.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabUsuarios.UseSelectable = true;
            this.tabUsuarios.UseTileImage = true;
            // 
            // tabCierre
            // 
            this.tabCierre.ActiveControl = null;
            this.tabCierre.Location = new System.Drawing.Point(429, 3);
            this.tabCierre.Name = "tabCierre";
            this.tabCierre.Size = new System.Drawing.Size(192, 71);
            this.tabCierre.Style = MetroFramework.MetroColorStyle.Red;
            this.tabCierre.TabIndex = 3;
            this.tabCierre.Text = "ACERCA DE..";
            this.tabCierre.TileImage = ((System.Drawing.Image)(resources.GetObject("tabCierre.TileImage")));
            this.tabCierre.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabCierre.UseSelectable = true;
            this.tabCierre.UseTileImage = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(632, 306);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "USUARIOS";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(632, 355);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "CIERRES";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(632, 355);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "FACTURAR";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(632, 306);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "INVENTARIO";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tab_principal
            // 
            this.tab_principal.Controls.Add(this.metroTabPage1);
            this.tab_principal.Controls.Add(this.metroTabPage2);
            this.tab_principal.Controls.Add(this.metroTabPage3);
            this.tab_principal.Controls.Add(this.metroTabPage4);
            this.tab_principal.Controls.Add(this.metroTabPage5);
            this.tab_principal.Location = new System.Drawing.Point(36, 43);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.SelectedIndex = 4;
            this.tab_principal.Size = new System.Drawing.Size(640, 348);
            this.tab_principal.Style = MetroFramework.MetroColorStyle.Green;
            this.tab_principal.TabIndex = 1;
            this.tab_principal.UseSelectable = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(632, 306);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "CLIENTES";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VentanaPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile tabSalir;
        private MetroFramework.Controls.MetroTile tabUsuarios;
        private MetroFramework.Controls.MetroTile tabCierre;
        private MetroFramework.Controls.MetroTabControl tab_principal;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
    }
}