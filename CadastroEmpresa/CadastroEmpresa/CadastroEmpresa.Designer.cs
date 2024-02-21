namespace CadastroEmpresa
{
    partial class CadastroEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.MaskedTextBox();
            this.razaoSocial = new System.Windows.Forms.TextBox();
            this.nomeFantasia = new System.Windows.Forms.TextBox();
            this.situacaoCadastral = new System.Windows.Forms.ComboBox();
            this.SimplesNacional = new System.Windows.Forms.RadioButton();
            this.LucroPresumido = new System.Windows.Forms.RadioButton();
            this.Real = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataInicioAt = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.capitalSocial = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.novo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome Fantasia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação Cadastral:";
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(62, 63);
            this.cnpj.Mask = "00,000,000/0000-00";
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(104, 20);
            this.cnpj.TabIndex = 5;
            // 
            // razaoSocial
            // 
            this.razaoSocial.Location = new System.Drawing.Point(98, 101);
            this.razaoSocial.Name = "razaoSocial";
            this.razaoSocial.Size = new System.Drawing.Size(126, 20);
            this.razaoSocial.TabIndex = 6;
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.Location = new System.Drawing.Point(106, 139);
            this.nomeFantasia.Name = "nomeFantasia";
            this.nomeFantasia.Size = new System.Drawing.Size(128, 20);
            this.nomeFantasia.TabIndex = 7;
            // 
            // situacaoCadastral
            // 
            this.situacaoCadastral.FormattingEnabled = true;
            this.situacaoCadastral.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.situacaoCadastral.Location = new System.Drawing.Point(124, 174);
            this.situacaoCadastral.Name = "situacaoCadastral";
            this.situacaoCadastral.Size = new System.Drawing.Size(100, 21);
            this.situacaoCadastral.TabIndex = 8;
            // 
            // SimplesNacional
            // 
            this.SimplesNacional.AutoSize = true;
            this.SimplesNacional.Location = new System.Drawing.Point(0, 23);
            this.SimplesNacional.Name = "SimplesNacional";
            this.SimplesNacional.Size = new System.Drawing.Size(106, 17);
            this.SimplesNacional.TabIndex = 10;
            this.SimplesNacional.TabStop = true;
            this.SimplesNacional.Text = "Simples Nacional";
            this.SimplesNacional.UseVisualStyleBackColor = true;
            // 
            // LucroPresumido
            // 
            this.LucroPresumido.AutoSize = true;
            this.LucroPresumido.Location = new System.Drawing.Point(111, 23);
            this.LucroPresumido.Name = "LucroPresumido";
            this.LucroPresumido.Size = new System.Drawing.Size(104, 17);
            this.LucroPresumido.TabIndex = 11;
            this.LucroPresumido.TabStop = true;
            this.LucroPresumido.Text = "Lucro Presumido";
            this.LucroPresumido.UseVisualStyleBackColor = true;
            // 
            // Real
            // 
            this.Real.AutoSize = true;
            this.Real.Location = new System.Drawing.Point(219, 23);
            this.Real.Name = "Real";
            this.Real.Size = new System.Drawing.Size(47, 17);
            this.Real.TabIndex = 12;
            this.Real.TabStop = true;
            this.Real.Text = "Real";
            this.Real.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de Inicio de Atividades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Capital Social:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço Completo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(772, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(654, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Rua, bairro e número";
            // 
            // dataInicioAt
            // 
            this.dataInicioAt.Location = new System.Drawing.Point(160, 278);
            this.dataInicioAt.Mask = "00/00/0000";
            this.dataInicioAt.Name = "dataInicioAt";
            this.dataInicioAt.Size = new System.Drawing.Size(64, 20);
            this.dataInicioAt.TabIndex = 20;
            this.dataInicioAt.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(79, 311);
            this.maskedTextBox1.Mask = "(00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // capitalSocial
            // 
            this.capitalSocial.Location = new System.Drawing.Point(92, 352);
            this.capitalSocial.Name = "capitalSocial";
            this.capitalSocial.Size = new System.Drawing.Size(100, 20);
            this.capitalSocial.TabIndex = 22;
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.estado.Location = new System.Drawing.Point(733, 81);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 23;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(567, 82);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(117, 20);
            this.cidade.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(562, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Natureza Juridica:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "CPF do proprietário:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(548, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Nome do proprietário:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(660, 342);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(567, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(287, 20);
            this.textBox4.TabIndex = 32;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Matriz";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Filial";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 17);
            this.radioButton3.TabIndex = 36;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pequeno";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(80, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 37;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Médio";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(140, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 17);
            this.radioButton5.TabIndex = 38;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Grande";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EI - Empresário Individual",
            "MEI - Microempreendedor Individual",
            "Sociedade Anônima"});
            this.comboBox1.Location = new System.Drawing.Point(660, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(660, 368);
            this.cpf.Mask = "000,000,000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(84, 20);
            this.cpf.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cadastrar Empresa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(567, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 62);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da Empresa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(570, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 64);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Porte da Empresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SimplesNacional);
            this.groupBox3.Controls.Add(this.LucroPresumido);
            this.groupBox3.Controls.Add(this.Real);
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 51);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regime Tributário";
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(622, 423);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(148, 45);
            this.novo.TabIndex = 46;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 508);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.capitalSocial);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataInicioAt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.situacaoCadastral);
            this.Controls.Add(this.nomeFantasia);
            this.Controls.Add(this.razaoSocial);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEmpresa";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cnpj;
        private System.Windows.Forms.TextBox razaoSocial;
        private System.Windows.Forms.TextBox nomeFantasia;
        private System.Windows.Forms.ComboBox situacaoCadastral;
        private System.Windows.Forms.RadioButton SimplesNacional;
        private System.Windows.Forms.RadioButton LucroPresumido;
        private System.Windows.Forms.RadioButton Real;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox dataInicioAt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox capitalSocial;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button novo;
    }
}