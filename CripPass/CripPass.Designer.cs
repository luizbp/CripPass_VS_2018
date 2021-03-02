namespace CripPass
{
    partial class CripPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CripPass));
            this.tabCripPass = new System.Windows.Forms.TabControl();
            this.tbCrip = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCripSenha1 = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtChave1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btNovo1 = new System.Windows.Forms.Button();
            this.btCrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescp = new System.Windows.Forms.TabPage();
            this.btNovo2 = new System.Windows.Forms.Button();
            this.txtSenhaDesc2 = new System.Windows.Forms.TextBox();
            this.txtSenhaCrip2 = new System.Windows.Forms.TextBox();
            this.txtChave2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSair2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btDescrip = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCripPass.SuspendLayout();
            this.tbCrip.SuspendLayout();
            this.tbDescp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCripPass
            // 
            this.tabCripPass.Controls.Add(this.tbCrip);
            this.tabCripPass.Controls.Add(this.tbDescp);
            this.tabCripPass.Controls.Add(this.tabPage1);
            this.tabCripPass.Location = new System.Drawing.Point(7, 8);
            this.tabCripPass.Name = "tabCripPass";
            this.tabCripPass.SelectedIndex = 0;
            this.tabCripPass.Size = new System.Drawing.Size(462, 242);
            this.tabCripPass.TabIndex = 0;
            this.tabCripPass.Click += new System.EventHandler(this.tabCripPass_Click);
            // 
            // tbCrip
            // 
            this.tbCrip.Controls.Add(this.label7);
            this.tbCrip.Controls.Add(this.button1);
            this.tbCrip.Controls.Add(this.txtCripSenha1);
            this.tbCrip.Controls.Add(this.txtSenha1);
            this.tbCrip.Controls.Add(this.txtChave1);
            this.tbCrip.Controls.Add(this.label3);
            this.tbCrip.Controls.Add(this.btSair);
            this.tbCrip.Controls.Add(this.label2);
            this.tbCrip.Controls.Add(this.btNovo1);
            this.tbCrip.Controls.Add(this.btCrip);
            this.tbCrip.Controls.Add(this.label1);
            this.tbCrip.Location = new System.Drawing.Point(4, 22);
            this.tbCrip.Name = "tbCrip";
            this.tbCrip.Padding = new System.Windows.Forms.Padding(3);
            this.tbCrip.Size = new System.Drawing.Size(454, 216);
            this.tbCrip.TabIndex = 0;
            this.tbCrip.Text = "Criptografar";
            this.tbCrip.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Atenção: essa chave é a unica que pode descriptografar sua senha!!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostar senha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // txtCripSenha1
            // 
            this.txtCripSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCripSenha1.Location = new System.Drawing.Point(11, 137);
            this.txtCripSenha1.Name = "txtCripSenha1";
            this.txtCripSenha1.ReadOnly = true;
            this.txtCripSenha1.Size = new System.Drawing.Size(254, 24);
            this.txtCripSenha1.TabIndex = 4;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha1.Location = new System.Drawing.Point(11, 84);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(254, 24);
            this.txtSenha1.TabIndex = 2;
            // 
            // txtChave1
            // 
            this.txtChave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave1.Location = new System.Drawing.Point(11, 33);
            this.txtChave1.Name = "txtChave1";
            this.txtChave1.Size = new System.Drawing.Size(220, 24);
            this.txtChave1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha Criptografada:";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(360, 177);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // btNovo1
            // 
            this.btNovo1.Location = new System.Drawing.Point(279, 177);
            this.btNovo1.Name = "btNovo1";
            this.btNovo1.Size = new System.Drawing.Size(75, 23);
            this.btNovo1.TabIndex = 6;
            this.btNovo1.Text = "Novo";
            this.btNovo1.UseVisualStyleBackColor = true;
            this.btNovo1.Click += new System.EventHandler(this.btNovo1_Click);
            // 
            // btCrip
            // 
            this.btCrip.Location = new System.Drawing.Point(198, 177);
            this.btCrip.Name = "btCrip";
            this.btCrip.Size = new System.Drawing.Size(75, 23);
            this.btCrip.TabIndex = 5;
            this.btCrip.Text = "Criptografar";
            this.btCrip.UseVisualStyleBackColor = true;
            this.btCrip.Click += new System.EventHandler(this.btCrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chave:";
            // 
            // tbDescp
            // 
            this.tbDescp.Controls.Add(this.btNovo2);
            this.tbDescp.Controls.Add(this.txtSenhaDesc2);
            this.tbDescp.Controls.Add(this.txtSenhaCrip2);
            this.tbDescp.Controls.Add(this.txtChave2);
            this.tbDescp.Controls.Add(this.label4);
            this.tbDescp.Controls.Add(this.btSair2);
            this.tbDescp.Controls.Add(this.label5);
            this.tbDescp.Controls.Add(this.btDescrip);
            this.tbDescp.Controls.Add(this.label6);
            this.tbDescp.Location = new System.Drawing.Point(4, 22);
            this.tbDescp.Name = "tbDescp";
            this.tbDescp.Padding = new System.Windows.Forms.Padding(3);
            this.tbDescp.Size = new System.Drawing.Size(454, 216);
            this.tbDescp.TabIndex = 1;
            this.tbDescp.Text = "Descriptografar";
            this.tbDescp.UseVisualStyleBackColor = true;
            // 
            // btNovo2
            // 
            this.btNovo2.Location = new System.Drawing.Point(280, 179);
            this.btNovo2.Name = "btNovo2";
            this.btNovo2.Size = new System.Drawing.Size(75, 23);
            this.btNovo2.TabIndex = 5;
            this.btNovo2.Text = "Novo";
            this.btNovo2.UseVisualStyleBackColor = true;
            this.btNovo2.Click += new System.EventHandler(this.btNovo2_Click);
            // 
            // txtSenhaDesc2
            // 
            this.txtSenhaDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaDesc2.Location = new System.Drawing.Point(12, 139);
            this.txtSenhaDesc2.Name = "txtSenhaDesc2";
            this.txtSenhaDesc2.ReadOnly = true;
            this.txtSenhaDesc2.Size = new System.Drawing.Size(254, 24);
            this.txtSenhaDesc2.TabIndex = 3;
            // 
            // txtSenhaCrip2
            // 
            this.txtSenhaCrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCrip2.Location = new System.Drawing.Point(12, 86);
            this.txtSenhaCrip2.Name = "txtSenhaCrip2";
            this.txtSenhaCrip2.Size = new System.Drawing.Size(254, 24);
            this.txtSenhaCrip2.TabIndex = 2;
            // 
            // txtChave2
            // 
            this.txtChave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave2.Location = new System.Drawing.Point(12, 35);
            this.txtChave2.Name = "txtChave2";
            this.txtChave2.Size = new System.Drawing.Size(220, 24);
            this.txtChave2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha Criptografada:";
            // 
            // btSair2
            // 
            this.btSair2.Location = new System.Drawing.Point(361, 179);
            this.btSair2.Name = "btSair2";
            this.btSair2.Size = new System.Drawing.Size(75, 23);
            this.btSair2.TabIndex = 6;
            this.btSair2.Text = "Sair";
            this.btSair2.UseVisualStyleBackColor = true;
            this.btSair2.Click += new System.EventHandler(this.btSair2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha Descriptografada:";
            // 
            // btDescrip
            // 
            this.btDescrip.Location = new System.Drawing.Point(183, 179);
            this.btDescrip.Name = "btDescrip";
            this.btDescrip.Size = new System.Drawing.Size(91, 23);
            this.btDescrip.TabIndex = 4;
            this.btDescrip.Text = "Descriptografar";
            this.btDescrip.UseVisualStyleBackColor = true;
            this.btDescrip.Click += new System.EventHandler(this.btDescrip_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chave:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 216);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sobre";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.MaximumSize = new System.Drawing.Size(270, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "CripPass foi criado na inteção de aumentar a segurança de senhas, tornando o uso " +
    "da mesma mais segura!!!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "carlinhospereira12@hotmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contato: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Luiz Carlos B. Pereira";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Autor: ";
            // 
            // CripPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 253);
            this.Controls.Add(this.tabCripPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CripPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CripPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CripPass_FormClosing);
            this.Load += new System.EventHandler(this.CripPass_Load);
            this.tabCripPass.ResumeLayout(false);
            this.tbCrip.ResumeLayout(false);
            this.tbCrip.PerformLayout();
            this.tbDescp.ResumeLayout(false);
            this.tbDescp.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCripPass;
        private System.Windows.Forms.TabPage tbCrip;
        private System.Windows.Forms.TextBox txtCripSenha1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtChave1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbDescp;
        private System.Windows.Forms.TextBox txtSenhaDesc2;
        private System.Windows.Forms.TextBox txtSenhaCrip2;
        private System.Windows.Forms.TextBox txtChave2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSair2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDescrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btNovo1;
        private System.Windows.Forms.Button btNovo2;
    }
}

