﻿
namespace Projeto_Vendas_Fatec_2.br.com.projeto.view
{
    partial class Frmfornecedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.dgfornecedores = new System.Windows.Forms.DataGridView();
            this.Btnconsultar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.lbldados = new System.Windows.Forms.Label();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnexcluir = new System.Windows.Forms.Button();
            this.Btncadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 138);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 519);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.lbluf);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.lblcidade);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.lblbairro);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.lblcomplemento);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.lblendereco);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.lblnumero);
            this.tabPage1.Controls.Add(this.btnpesquisar);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.lblcep);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.lblcelular);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.lbltelefone);
            this.tabPage1.Controls.Add(this.txtcnpj);
            this.tabPage1.Controls.Add(this.lblcnpj);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.lblemail);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.lblnome);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lblcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1209, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados dos Fornecedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbuf
            // 
            this.cbuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(937, 426);
            this.cbuf.Margin = new System.Windows.Forms.Padding(4);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(143, 33);
            this.cbuf.TabIndex = 29;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluf.Location = new System.Drawing.Point(878, 432);
            this.lbluf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(44, 25);
            this.lbluf.TabIndex = 47;
            this.lbluf.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(570, 428);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(265, 30);
            this.txtcidade.TabIndex = 46;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(470, 432);
            this.lblcidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(81, 25);
            this.lblcidade.TabIndex = 45;
            this.lblcidade.Text = "Cidade:";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(148, 428);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(265, 30);
            this.txtbairro.TabIndex = 44;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(60, 432);
            this.lblbairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(69, 25);
            this.lblbairro.TabIndex = 43;
            this.lblbairro.Text = "Bairro:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.Location = new System.Drawing.Point(700, 369);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(265, 30);
            this.txtcomplemento.TabIndex = 42;
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.Location = new System.Drawing.Point(614, 369);
            this.lblcomplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(76, 25);
            this.lblcomplemento.TabIndex = 41;
            this.lblcomplemento.Text = "Comp.:";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(148, 373);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(428, 30);
            this.txtendereco.TabIndex = 40;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(24, 373);
            this.lblendereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(102, 25);
            this.lblendereco.TabIndex = 39;
            this.lblendereco.Text = "Endereço:";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(1044, 254);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(75, 30);
            this.txtnumero.TabIndex = 38;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(991, 257);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(40, 25);
            this.lblnumero.TabIndex = 37;
            this.lblnumero.Text = "N°:";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(804, 257);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(141, 31);
            this.btnpesquisar.TabIndex = 36;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(543, 257);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(253, 30);
            this.txtcep.TabIndex = 35;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(470, 261);
            this.lblcep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(59, 25);
            this.lblcep.TabIndex = 34;
            this.lblcep.Text = "CEP:";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(148, 312);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcelular.Mask = "(##) ##### - ####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(293, 30);
            this.txtcelular.TabIndex = 33;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.Location = new System.Drawing.Point(42, 312);
            this.lblcelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(80, 25);
            this.lblcelular.TabIndex = 32;
            this.lblcelular.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(148, 257);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefone.Mask = "(##) #### - ####";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(293, 30);
            this.txttelefone.TabIndex = 31;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(29, 260);
            this.lbltelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(95, 25);
            this.lbltelefone.TabIndex = 30;
            this.lbltelefone.Text = "Telefone:";
            // 
            // txtcnpj
            // 
            this.txtcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(142, 134);
            this.txtcnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtcnpj.Mask = "##,###,###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(293, 30);
            this.txtcnpj.TabIndex = 19;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnpj.Location = new System.Drawing.Point(56, 134);
            this.lblcnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(71, 25);
            this.lblcnpj.TabIndex = 18;
            this.lblcnpj.Text = "CNPJ:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(142, 192);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(472, 30);
            this.txtemail.TabIndex = 15;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(50, 196);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(73, 25);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "E-mail:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(142, 79);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(472, 30);
            this.txtnome.TabIndex = 13;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(60, 82);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(70, 25);
            this.lblnome.TabIndex = 12;
            this.lblnome.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(142, 34);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(75, 30);
            this.txtcodigo.TabIndex = 11;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(50, 38);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(81, 25);
            this.lblcodigo.TabIndex = 10;
            this.lblcodigo.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbfiltro);
            this.tabPage2.Controls.Add(this.dgfornecedores);
            this.tabPage2.Controls.Add(this.Btnconsultar);
            this.tabPage2.Controls.Add(this.txtconsulta);
            this.tabPage2.Controls.Add(this.lbldados);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1209, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Fornecedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbfiltro
            // 
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Items.AddRange(new object[] {
            "Nome",
            "CNPJ"});
            this.cbfiltro.Location = new System.Drawing.Point(594, 78);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(121, 24);
            this.cbfiltro.TabIndex = 44;
            // 
            // dgfornecedores
            // 
            this.dgfornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfornecedores.Location = new System.Drawing.Point(33, 133);
            this.dgfornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgfornecedores.Name = "dgfornecedores";
            this.dgfornecedores.RowHeadersWidth = 57;
            this.dgfornecedores.Size = new System.Drawing.Size(1143, 290);
            this.dgfornecedores.TabIndex = 43;
            this.dgfornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfornecedores_CellClick);
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Location = new System.Drawing.Point(766, 68);
            this.Btnconsultar.Margin = new System.Windows.Forms.Padding(4);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.Size = new System.Drawing.Size(159, 42);
            this.Btnconsultar.TabIndex = 42;
            this.Btnconsultar.Text = "Consultar";
            this.Btnconsultar.UseVisualStyleBackColor = true;
            this.Btnconsultar.Click += new System.EventHandler(this.Btnconsultar_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsulta.Location = new System.Drawing.Point(115, 75);
            this.txtconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(472, 30);
            this.txtconsulta.TabIndex = 41;
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldados.Location = new System.Drawing.Point(34, 78);
            this.lbldados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(69, 25);
            this.lbldados.TabIndex = 40;
            this.lbldados.Text = "Dados";
            // 
            // Btneditar
            // 
            this.Btneditar.Location = new System.Drawing.Point(741, 671);
            this.Btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(159, 52);
            this.Btneditar.TabIndex = 45;
            this.Btneditar.Text = "Editar";
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btnexcluir
            // 
            this.Btnexcluir.Location = new System.Drawing.Point(540, 671);
            this.Btnexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.Btnexcluir.Name = "Btnexcluir";
            this.Btnexcluir.Size = new System.Drawing.Size(159, 52);
            this.Btnexcluir.TabIndex = 44;
            this.Btnexcluir.Text = "Excluir";
            this.Btnexcluir.UseVisualStyleBackColor = true;
            this.Btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // Btncadastrar
            // 
            this.Btncadastrar.Location = new System.Drawing.Point(344, 671);
            this.Btncadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btncadastrar.Name = "Btncadastrar";
            this.Btncadastrar.Size = new System.Drawing.Size(159, 52);
            this.Btncadastrar.TabIndex = 43;
            this.Btncadastrar.Text = "Cadastrar";
            this.Btncadastrar.UseVisualStyleBackColor = true;
            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // Frmfornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 733);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btnexcluir);
            this.Controls.Add(this.Btncadastrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmfornecedores";
            this.Text = "Frmfornecedores";
            this.Load += new System.EventHandler(this.Frmfornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.DataGridView dgfornecedores;
        private System.Windows.Forms.Button Btnconsultar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label lbldados;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnexcluir;
        private System.Windows.Forms.Button Btncadastrar;
    }
}