namespace CRUD_MVC_Daniel_Saraiva
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnMostarSenha = new System.Windows.Forms.Button();
			this.lnkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(37, 182);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(84, 26);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "Email :";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.Location = new System.Drawing.Point(37, 241);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(92, 26);
			this.lblSenha.TabIndex = 2;
			this.lblSenha.Text = "Senha :";
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.LightCyan;
			this.txtEmail.Location = new System.Drawing.Point(157, 183);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(290, 26);
			this.txtEmail.TabIndex = 3;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.LightCyan;
			this.txtSenha.Location = new System.Drawing.Point(157, 242);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(250, 26);
			this.txtSenha.TabIndex = 4;
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(198)))), ((int)(((byte)(221)))));
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Location = new System.Drawing.Point(157, 366);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(180, 65);
			this.btnEntrar.TabIndex = 5;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// btnMostarSenha
			// 
			this.btnMostarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostarSenha.BackgroundImage")));
			this.btnMostarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMostarSenha.Location = new System.Drawing.Point(416, 241);
			this.btnMostarSenha.Name = "btnMostarSenha";
			this.btnMostarSenha.Size = new System.Drawing.Size(31, 31);
			this.btnMostarSenha.TabIndex = 9;
			this.btnMostarSenha.UseVisualStyleBackColor = true;
			this.btnMostarSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostarSenha_MouseDown);
			this.btnMostarSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostarSenha_MouseUp);
			// 
			// lnkEsqueceuSenha
			// 
			this.lnkEsqueceuSenha.AutoSize = true;
			this.lnkEsqueceuSenha.LinkColor = System.Drawing.Color.DimGray;
			this.lnkEsqueceuSenha.Location = new System.Drawing.Point(295, 276);
			this.lnkEsqueceuSenha.Name = "lnkEsqueceuSenha";
			this.lnkEsqueceuSenha.Size = new System.Drawing.Size(154, 18);
			this.lnkEsqueceuSenha.TabIndex = 10;
			this.lnkEsqueceuSenha.TabStop = true;
			this.lnkEsqueceuSenha.Text = "Esqueci a senha...";
			this.lnkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEsqueceuSenha_LinkClicked);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(482, 453);
			this.Controls.Add(this.lnkEsqueceuSenha);
			this.Controls.Add(this.btnMostarSenha);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnMostarSenha;
        private System.Windows.Forms.LinkLabel lnkEsqueceuSenha;
    }
}

