namespace CRUD_com_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cnpjText = new Label();
            txtCnpj = new TextBox();
            txtEnd = new TextBox();
            enderecoText = new Label();
            txtInscricao = new TextBox();
            label1 = new Label();
            boxCnae = new ComboBox();
            label2 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            txtComplemento = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtCep = new TextBox();
            label7 = new Label();
            label8 = new Label();
            boxUf = new ComboBox();
            matriz = new RadioButton();
            filial = new RadioButton();
            txtTelefone = new TextBox();
            label9 = new Label();
            txtResp = new TextBox();
            label10 = new Label();
            checkVendas = new CheckBox();
            checkNews = new CheckBox();
            checkRecrutamento = new CheckBox();
            checkNovos = new CheckBox();
            checkFornecimento = new CheckBox();
            checkGarantia = new CheckBox();
            checkPromo = new CheckBox();
            checkEventos = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cnpjText
            // 
            cnpjText.AutoSize = true;
            cnpjText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cnpjText.Location = new Point(22, 21);
            cnpjText.Name = "cnpjText";
            cnpjText.Size = new Size(49, 21);
            cnpjText.TabIndex = 0;
            cnpjText.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            txtCnpj.BorderStyle = BorderStyle.FixedSingle;
            txtCnpj.Location = new Point(22, 45);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(203, 23);
            txtCnpj.TabIndex = 1;
            // 
            // txtEnd
            // 
            txtEnd.BorderStyle = BorderStyle.FixedSingle;
            txtEnd.Location = new Point(22, 106);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(420, 23);
            txtEnd.TabIndex = 3;
            // 
            // enderecoText
            // 
            enderecoText.AutoSize = true;
            enderecoText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enderecoText.Location = new Point(22, 82);
            enderecoText.Name = "enderecoText";
            enderecoText.Size = new Size(81, 21);
            enderecoText.TabIndex = 2;
            enderecoText.Text = "Endereco";
            // 
            // txtInscricao
            // 
            txtInscricao.BorderStyle = BorderStyle.FixedSingle;
            txtInscricao.Location = new Point(231, 45);
            txtInscricao.Name = "txtInscricao";
            txtInscricao.Size = new Size(211, 23);
            txtInscricao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 21);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 4;
            label1.Text = "Inscrição Estadual";
            // 
            // boxCnae
            // 
            boxCnae.FormattingEnabled = true;
            boxCnae.Items.AddRange(new object[] { "ComboBox", "01.11-3/01", "10.11-2/01", "35.11-5/00", "41.20-4/00" });
            boxCnae.Location = new Point(457, 45);
            boxCnae.Name = "boxCnae";
            boxCnae.Size = new Size(93, 23);
            boxCnae.TabIndex = 6;            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(457, 21);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 7;
            label2.Text = "CNAE";
            label2.Click += label2_Click;
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(457, 106);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 23);
            txtNumero.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(457, 82);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 8;
            label3.Text = "Numero";
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Location = new Point(22, 165);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(257, 23);
            txtComplemento.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 10;
            label4.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Location = new Point(285, 165);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(265, 23);
            txtBairro.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(285, 141);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 12;
            label5.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Location = new Point(22, 222);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(257, 23);
            txtCidade.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 198);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 14;
            label6.Text = "Cidade";
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Location = new Point(285, 222);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(157, 23);
            txtCep.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(285, 198);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 16;
            label7.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(457, 197);
            label8.Name = "label8";
            label8.Size = new Size(30, 21);
            label8.TabIndex = 19;
            label8.Text = "UF";
            // 
            // boxUf
            // 
            boxUf.FormattingEnabled = true;
            boxUf.Items.AddRange(new object[] { "ComboBox", "SP", "RJ", "MG" });
            boxUf.Location = new Point(457, 222);
            boxUf.Name = "boxUf";
            boxUf.Size = new Size(93, 23);
            boxUf.TabIndex = 18;
            // 
            // matriz
            // 
            matriz.AutoSize = true;
            matriz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            matriz.Location = new Point(22, 282);
            matriz.Name = "matriz";
            matriz.Size = new Size(61, 19);
            matriz.TabIndex = 20;
            matriz.TabStop = true;
            matriz.Text = "Matriz";
            matriz.UseVisualStyleBackColor = true;
            // 
            // filial
            // 
            filial.AutoSize = true;
            filial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filial.Location = new Point(104, 282);
            filial.Name = "filial";
            filial.Size = new Size(49, 19);
            filial.TabIndex = 21;
            filial.TabStop = true;
            filial.Text = "Filial";
            filial.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Location = new Point(176, 278);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(138, 23);
            txtTelefone.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(176, 254);
            label9.Name = "label9";
            label9.Size = new Size(76, 21);
            label9.TabIndex = 22;
            label9.Text = "Telefone";
            label9.Click += label9_Click;
            // 
            // txtResp
            // 
            txtResp.BorderStyle = BorderStyle.FixedSingle;
            txtResp.Location = new Point(320, 278);
            txtResp.Name = "txtResp";
            txtResp.Size = new Size(230, 23);
            txtResp.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(320, 254);
            label10.Name = "label10";
            label10.Size = new Size(178, 21);
            label10.TabIndex = 24;
            label10.Text = "Responsavel Imediato";
            // 
            // checkVendas
            // 
            checkVendas.AutoSize = true;
            checkVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkVendas.Location = new Point(20, 343);
            checkVendas.Name = "checkVendas";
            checkVendas.Size = new Size(65, 19);
            checkVendas.TabIndex = 26;
            checkVendas.Text = "Vendas";
            checkVendas.UseVisualStyleBackColor = true;
            // 
            // checkNews
            // 
            checkNews.AutoSize = true;
            checkNews.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkNews.Location = new Point(20, 385);
            checkNews.Name = "checkNews";
            checkNews.Size = new Size(95, 19);
            checkNews.TabIndex = 27;
            checkNews.Text = "News Letter";
            checkNews.UseVisualStyleBackColor = true;
            // 
            // checkRecrutamento
            // 
            checkRecrutamento.AutoSize = true;
            checkRecrutamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkRecrutamento.Location = new Point(121, 343);
            checkRecrutamento.Name = "checkRecrutamento";
            checkRecrutamento.Size = new Size(163, 19);
            checkRecrutamento.TabIndex = 28;
            checkRecrutamento.Text = "Recrutamento e Seleção";
            checkRecrutamento.UseVisualStyleBackColor = true;
            // 
            // checkNovos
            // 
            checkNovos.AutoSize = true;
            checkNovos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkNovos.Location = new Point(121, 385);
            checkNovos.Name = "checkNovos";
            checkNovos.Size = new Size(114, 19);
            checkNovos.TabIndex = 29;
            checkNovos.Text = "Novos produtos";
            checkNovos.UseVisualStyleBackColor = true;
            // 
            // checkFornecimento
            // 
            checkFornecimento.AutoSize = true;
            checkFornecimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkFornecimento.Location = new Point(301, 343);
            checkFornecimento.Name = "checkFornecimento";
            checkFornecimento.Size = new Size(104, 19);
            checkFornecimento.TabIndex = 30;
            checkFornecimento.Text = "Fornecimento";
            checkFornecimento.UseVisualStyleBackColor = true;
            // 
            // checkGarantia
            // 
            checkGarantia.AutoSize = true;
            checkGarantia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkGarantia.Location = new Point(301, 385);
            checkGarantia.Name = "checkGarantia";
            checkGarantia.Size = new Size(73, 19);
            checkGarantia.TabIndex = 31;
            checkGarantia.Text = "Garantia";
            checkGarantia.UseVisualStyleBackColor = true;
            // 
            // checkPromo
            // 
            checkPromo.AutoSize = true;
            checkPromo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkPromo.Location = new Point(437, 343);
            checkPromo.Name = "checkPromo";
            checkPromo.Size = new Size(88, 19);
            checkPromo.TabIndex = 32;
            checkPromo.Text = "Promoções";
            checkPromo.UseVisualStyleBackColor = true;
            // 
            // checkEventos
            // 
            checkEventos.AutoSize = true;
            checkEventos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkEventos.Location = new Point(437, 385);
            checkEventos.Name = "checkEventos";
            checkEventos.Size = new Size(70, 19);
            checkEventos.TabIndex = 33;
            checkEventos.Text = "Eventos";
            checkEventos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(214, 435);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 34;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 489);
            Controls.Add(button1);
            Controls.Add(checkEventos);
            Controls.Add(checkPromo);
            Controls.Add(checkGarantia);
            Controls.Add(checkFornecimento);
            Controls.Add(checkNovos);
            Controls.Add(checkRecrutamento);
            Controls.Add(checkNews);
            Controls.Add(checkVendas);
            Controls.Add(txtResp);
            Controls.Add(label10);
            Controls.Add(txtTelefone);
            Controls.Add(label9);
            Controls.Add(filial);
            Controls.Add(matriz);
            Controls.Add(label8);
            Controls.Add(boxUf);
            Controls.Add(txtCep);
            Controls.Add(label7);
            Controls.Add(txtCidade);
            Controls.Add(label6);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(txtComplemento);
            Controls.Add(label4);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(boxCnae);
            Controls.Add(txtInscricao);
            Controls.Add(label1);
            Controls.Add(txtEnd);
            Controls.Add(enderecoText);
            Controls.Add(txtCnpj);
            Controls.Add(cnpjText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cnpjText;
        private TextBox txtCnpj;
        private TextBox txtEnd;
        private Label enderecoText;
        private TextBox txtInscricao;
        private Label label1;
        private ComboBox boxCnae;
        private Label label2;
        private TextBox txtNumero;
        private Label label3;
        private TextBox txtComplemento;
        private Label label4;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtCep;
        private Label label7;
        private Label label8;
        private ComboBox boxUf;
        private RadioButton matriz;
        private RadioButton filial;
        private TextBox txtTelefone;
        private Label label9;
        private TextBox txtResp;
        private Label label10;
        private CheckBox checkVendas;
        private CheckBox checkNews;
        private CheckBox checkRecrutamento;
        private CheckBox checkNovos;
        private CheckBox checkFornecimento;
        private CheckBox checkGarantia;
        private CheckBox checkPromo;
        private CheckBox checkEventos;
        private Button button1;
    }
}
