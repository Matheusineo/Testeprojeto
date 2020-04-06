namespace Formulario_de_cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPublicplace = new System.Windows.Forms.Label();
            this.txtPublicplace = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-134, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(171, 13);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(61, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Sobrenome";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(174, 29);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(116, 20);
            this.txtLastname.TabIndex = 4;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(8, 93);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Acre(AC)",
            "Alagoas(AL)",
            "Amapá(AP)",
            "Amazonas(AM)",
            "Bahia(BA)",
            "Ceará(CE)",
            "Espírito Santo(ES)",
            "Goiás(GO)",
            "Maranhão(MA)",
            "Mato Grosso(MT)",
            "Mato Grosso do Sul(MS)",
            "Minas Gerais(MG)",
            "Pará(PA)",
            "Paraíba(PB)",
            "Paraná(PR)",
            "Pernambuco(PE)",
            "Piauí(PI)",
            "Rio de Janeiro(RJ)",
            "Rio Grande do Norte(RN)",
            "Rio Grande do Sul(RS)",
            "Rondônia(RO)",
            "Roraima(RR)",
            "Santa Catarina(SC)",
            "São Paulo(SP)",
            "Sergipe(SE)",
            "Tocantins(TO)",
            "Distrito Federal(DF)"});
            this.cmbState.Location = new System.Drawing.Point(11, 32);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(116, 21);
            this.cmbState.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(8, 16);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "Estado";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(11, 109);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(116, 20);
            this.txtCpf.TabIndex = 10;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(171, 93);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 11;
            this.lblRg.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(174, 109);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(116, 20);
            this.txtRg.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtRg);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblRg);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtCpf);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 146);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cidade";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(174, 33);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(116, 20);
            this.txtCity.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(579, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(429, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(579, 213);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Senha";
            // 
            // lblPublicplace
            // 
            this.lblPublicplace.AutoSize = true;
            this.lblPublicplace.Location = new System.Drawing.Point(8, 82);
            this.lblPublicplace.Name = "lblPublicplace";
            this.lblPublicplace.Size = new System.Drawing.Size(61, 13);
            this.lblPublicplace.TabIndex = 20;
            this.lblPublicplace.Text = "Logradouro";
            // 
            // txtPublicplace
            // 
            this.txtPublicplace.Location = new System.Drawing.Point(11, 98);
            this.txtPublicplace.Name = "txtPublicplace";
            this.txtPublicplace.Size = new System.Drawing.Size(116, 20);
            this.txtPublicplace.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblCep);
            this.panel2.Controls.Add(this.txtNumber);
            this.panel2.Controls.Add(this.txtCep);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.cmbState);
            this.panel2.Controls.Add(this.txtPublicplace);
            this.panel2.Controls.Add(this.lblPublicplace);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 231);
            this.panel2.TabIndex = 22;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(171, 82);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 23;
            this.lblNumber.Text = "Numero";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(174, 98);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(116, 20);
            this.txtNumber.TabIndex = 24;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(11, 156);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(116, 20);
            this.txtCep.TabIndex = 23;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(8, 140);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 24;
            this.lblCep.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPublicplace;
        private System.Windows.Forms.TextBox txtPublicplace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label3;
    }
}

