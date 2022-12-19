namespace CRUD_MVC_Daniel_Saraiva.UI
{
    partial class FormMenu
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(198)))), ((int)(((byte)(221)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrincipal,
            this.tsmAjuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.menuPrincipal.Size = new System.Drawing.Size(1182, 36);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // tsmPrincipal
            // 
            this.tsmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrarUsuario,
            this.tsmListarUsuarios});
            this.tsmPrincipal.Name = "tsmPrincipal";
            this.tsmPrincipal.Size = new System.Drawing.Size(97, 24);
            this.tsmPrincipal.Text = "Principal";
            // 
            // tsmCadastrarUsuario
            // 
            this.tsmCadastrarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCadastrarUsuario.Name = "tsmCadastrarUsuario";
            this.tsmCadastrarUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmCadastrarUsuario.Size = new System.Drawing.Size(289, 26);
            this.tsmCadastrarUsuario.Text = "Cadastrar Usuários";
            this.tsmCadastrarUsuario.Click += new System.EventHandler(this.tsmCadastrarUsuario_Click);
            // 
            // tsmListarUsuarios
            // 
            this.tsmListarUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmListarUsuarios.Name = "tsmListarUsuarios";
            this.tsmListarUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmListarUsuarios.Size = new System.Drawing.Size(289, 26);
            this.tsmListarUsuarios.Text = "Listar Usuários";
            this.tsmListarUsuarios.Click += new System.EventHandler(this.tsmListarUsuarios_Click);
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.Size = new System.Drawing.Size(71, 24);
            this.tsmAjuda.Text = "Ajuda";
            this.tsmAjuda.Click += new System.EventHandler(this.tsmAjuda_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CRUD_MVC_Daniel_Saraiva.Properties.Resources.roberto_sorin_RS0_h_pyByk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmListarUsuarios;
    }
}