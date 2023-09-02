namespace CRUD_MVC_Daniel_Saraiva.UI
{
    partial class FormCadastroUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtNomeCompleto = new System.Windows.Forms.TextBox();
			this.lblNomeCompleto = new System.Windows.Forms.Label();
			this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
			this.lblConfirmarSenha = new System.Windows.Forms.Label();
			this.lblNivel = new System.Windows.Forms.Label();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnMostarSenha = new System.Windows.Forms.Button();
			this.btnMostrarConfirmarSenha = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(302, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(170, 153);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.LightCyan;
			this.txtSenha.Location = new System.Drawing.Point(354, 274);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(321, 26);
			this.txtSenha.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.LightCyan;
			this.txtEmail.Location = new System.Drawing.Point(354, 214);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(360, 26);
			this.txtEmail.TabIndex = 7;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.Location = new System.Drawing.Point(204, 273);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(92, 26);
			this.lblSenha.TabIndex = 6;
			this.lblSenha.Text = "Senha :";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(210, 214);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(84, 26);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "Email :";
			// 
			// txtNomeCompleto
			// 
			this.txtNomeCompleto.BackColor = System.Drawing.Color.LightCyan;
			this.txtNomeCompleto.Location = new System.Drawing.Point(354, 159);
			this.txtNomeCompleto.Name = "txtNomeCompleto";
			this.txtNomeCompleto.Size = new System.Drawing.Size(360, 26);
			this.txtNomeCompleto.TabIndex = 10;
			this.txtNomeCompleto.TextChanged += new System.EventHandler(this.txtNomeCompleto_TextChanged);
			// 
			// lblNomeCompleto
			// 
			this.lblNomeCompleto.AutoSize = true;
			this.lblNomeCompleto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCompleto.Location = new System.Drawing.Point(98, 158);
			this.lblNomeCompleto.Name = "lblNomeCompleto";
			this.lblNomeCompleto.Size = new System.Drawing.Size(195, 26);
			this.lblNomeCompleto.TabIndex = 9;
			this.lblNomeCompleto.Text = "Nome Completo :";
			// 
			// txtConfirmarSenha
			// 
			this.txtConfirmarSenha.BackColor = System.Drawing.Color.LightCyan;
			this.txtConfirmarSenha.Location = new System.Drawing.Point(354, 335);
			this.txtConfirmarSenha.Name = "txtConfirmarSenha";
			this.txtConfirmarSenha.PasswordChar = '*';
			this.txtConfirmarSenha.Size = new System.Drawing.Size(321, 26);
			this.txtConfirmarSenha.TabIndex = 12;
			// 
			// lblConfirmarSenha
			// 
			this.lblConfirmarSenha.AutoSize = true;
			this.lblConfirmarSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmarSenha.Location = new System.Drawing.Point(72, 335);
			this.lblConfirmarSenha.Name = "lblConfirmarSenha";
			this.lblConfirmarSenha.Size = new System.Drawing.Size(224, 26);
			this.lblConfirmarSenha.TabIndex = 11;
			this.lblConfirmarSenha.Text = "Confirmar a Senha :";
			// 
			// lblNivel
			// 
			this.lblNivel.AutoSize = true;
			this.lblNivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivel.Location = new System.Drawing.Point(218, 394);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(79, 26);
			this.lblNivel.TabIndex = 13;
			this.lblNivel.Text = "Nível :";
			// 
			// cmbNivel
			// 
			this.cmbNivel.BackColor = System.Drawing.Color.LightCyan;
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.Location = new System.Drawing.Point(354, 394);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(360, 26);
			this.cmbNivel.TabIndex = 14;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(198)))), ((int)(((byte)(221)))));
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(257, 446);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(180, 65);
			this.btnCadastrar.TabIndex = 15;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnMostarSenha
			// 
			this.btnMostarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostarSenha.BackgroundImage")));
			this.btnMostarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMostarSenha.Location = new System.Drawing.Point(683, 273);
			this.btnMostarSenha.Name = "btnMostarSenha";
			this.btnMostarSenha.Size = new System.Drawing.Size(31, 31);
			this.btnMostarSenha.TabIndex = 16;
			this.btnMostarSenha.UseVisualStyleBackColor = true;
			this.btnMostarSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostarSenha_MouseDown);
			this.btnMostarSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostarSenha_MouseUp);
			// 
			// btnMostrarConfirmarSenha
			// 
			this.btnMostrarConfirmarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarConfirmarSenha.BackgroundImage")));
			this.btnMostrarConfirmarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMostrarConfirmarSenha.Location = new System.Drawing.Point(683, 334);
			this.btnMostrarConfirmarSenha.Name = "btnMostrarConfirmarSenha";
			this.btnMostrarConfirmarSenha.Size = new System.Drawing.Size(31, 31);
			this.btnMostrarConfirmarSenha.TabIndex = 17;
			this.btnMostrarConfirmarSenha.UseVisualStyleBackColor = true;
			this.btnMostrarConfirmarSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostrarConfirmarSenha_MouseDown);
			this.btnMostrarConfirmarSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostrarConfirmarSenha_MouseUp);
			// 
			// FormCadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(752, 523);
			this.Controls.Add(this.btnMostrarConfirmarSenha);
			this.Controls.Add(this.btnMostarSenha);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.cmbNivel);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.txtConfirmarSenha);
			this.Controls.Add(this.lblConfirmarSenha);
			this.Controls.Add(this.txtNomeCompleto);
			this.Controls.Add(this.lblNomeCompleto);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCadastroUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Usuário";
			this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnMostarSenha;
        private System.Windows.Forms.Button btnMostrarConfirmarSenha;
    }
}