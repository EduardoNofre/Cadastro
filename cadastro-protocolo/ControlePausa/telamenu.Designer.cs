namespace CadastroProtocolo
{
    partial class telamenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telamenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtAtrsenhausuario = new System.Windows.Forms.Button();
            this.BtPatch = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BtRemessa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupPesquisa = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupPallet = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupIndexer = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tbprojetoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cad_proDataSet = new CadastroProtocolo.cad_proDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprojetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_projetoTableAdapter = new CadastroProtocolo.cad_proDataSetTableAdapters.tb_projetoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPesquisa.SuspendLayout();
            this.groupPallet.SuspendLayout();
            this.groupIndexer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupPallet);
            this.groupBox1.Controls.Add(this.groupPesquisa);
            this.groupBox1.Controls.Add(this.groupIndexer);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtAtrsenhausuario);
            this.groupBox2.Controls.Add(this.BtPatch);
            this.groupBox2.Controls.Add(this.btConfig);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.BtRemessa);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // BtAtrsenhausuario
            // 
            this.BtAtrsenhausuario.BackColor = System.Drawing.Color.White;
            this.BtAtrsenhausuario.Image = ((System.Drawing.Image)(resources.GetObject("BtAtrsenhausuario.Image")));
            this.BtAtrsenhausuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtAtrsenhausuario.Location = new System.Drawing.Point(425, 19);
            this.BtAtrsenhausuario.Name = "BtAtrsenhausuario";
            this.BtAtrsenhausuario.Size = new System.Drawing.Size(98, 120);
            this.BtAtrsenhausuario.TabIndex = 8;
            this.BtAtrsenhausuario.Text = "Alterar Senha";
            this.BtAtrsenhausuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtAtrsenhausuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtAtrsenhausuario.UseVisualStyleBackColor = false;
            this.BtAtrsenhausuario.Visible = false;
            this.BtAtrsenhausuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtPatch
            // 
            this.BtPatch.BackColor = System.Drawing.Color.White;
            this.BtPatch.Image = ((System.Drawing.Image)(resources.GetObject("BtPatch.Image")));
            this.BtPatch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtPatch.Location = new System.Drawing.Point(217, 19);
            this.BtPatch.Name = "BtPatch";
            this.BtPatch.Size = new System.Drawing.Size(98, 120);
            this.BtPatch.TabIndex = 4;
            this.BtPatch.Text = "Gerar Etiquetas/Patch";
            this.BtPatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtPatch.UseVisualStyleBackColor = false;
            this.BtPatch.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btConfig
            // 
            this.btConfig.BackColor = System.Drawing.Color.White;
            this.btConfig.Image = ((System.Drawing.Image)(resources.GetObject("btConfig.Image")));
            this.btConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConfig.Location = new System.Drawing.Point(425, 19);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(98, 120);
            this.btConfig.TabIndex = 0;
            this.btConfig.Text = "Configurações";
            this.btConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConfig.UseVisualStyleBackColor = false;
            this.btConfig.Visible = false;
            this.btConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(321, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 120);
            this.button10.TabIndex = 7;
            this.button10.Text = "Pesquisa";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtRemessa
            // 
            this.BtRemessa.BackColor = System.Drawing.Color.White;
            this.BtRemessa.Image = ((System.Drawing.Image)(resources.GetObject("BtRemessa.Image")));
            this.BtRemessa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtRemessa.Location = new System.Drawing.Point(113, 19);
            this.BtRemessa.Name = "BtRemessa";
            this.BtRemessa.Size = new System.Drawing.Size(98, 120);
            this.BtRemessa.TabIndex = 3;
            this.BtRemessa.Text = "Gerar Protocolo";
            this.BtRemessa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtRemessa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtRemessa.UseVisualStyleBackColor = false;
            this.BtRemessa.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(9, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 120);
            this.button3.TabIndex = 2;
            this.button3.Text = "Indexar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupPesquisa
            // 
            this.groupPesquisa.Controls.Add(this.button13);
            this.groupPesquisa.Controls.Add(this.button12);
            this.groupPesquisa.Controls.Add(this.button11);
            this.groupPesquisa.Location = new System.Drawing.Point(12, 167);
            this.groupPesquisa.Name = "groupPesquisa";
            this.groupPesquisa.Size = new System.Drawing.Size(528, 154);
            this.groupPesquisa.TabIndex = 7;
            this.groupPesquisa.TabStop = false;
            this.groupPesquisa.Text = "Pesquisa";
            this.groupPesquisa.Visible = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.Location = new System.Drawing.Point(6, 26);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 120);
            this.button13.TabIndex = 8;
            this.button13.Text = "Procurar Remessa";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(214, 26);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 120);
            this.button12.TabIndex = 9;
            this.button12.Text = "Procurar Lote";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(110, 26);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 120);
            this.button11.TabIndex = 8;
            this.button11.Text = "Procurar Participante";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupPallet
            // 
            this.groupPallet.Controls.Add(this.textBox2);
            this.groupPallet.Controls.Add(this.button4);
            this.groupPallet.Controls.Add(this.button1);
            this.groupPallet.Controls.Add(this.button9);
            this.groupPallet.Controls.Add(this.button6);
            this.groupPallet.Location = new System.Drawing.Point(7, 170);
            this.groupPallet.Name = "groupPallet";
            this.groupPallet.Size = new System.Drawing.Size(533, 151);
            this.groupPallet.TabIndex = 3;
            this.groupPallet.TabStop = false;
            this.groupPallet.Text = "Configurações";
            this.groupPallet.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(318, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 120);
            this.button4.TabIndex = 9;
            this.button4.Text = "Gerenciar Remessas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(213, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 120);
            this.button1.TabIndex = 7;
            this.button1.Text = "Relatório de Produção";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(110, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 120);
            this.button9.TabIndex = 6;
            this.button9.Text = "Alterar Senha";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(6, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 120);
            this.button6.TabIndex = 5;
            this.button6.Text = "Cadastrar\\Excluir Usuário";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupIndexer
            // 
            this.groupIndexer.Controls.Add(this.button8);
            this.groupIndexer.Controls.Add(this.comboBox5);
            this.groupIndexer.Controls.Add(this.comboBox4);
            this.groupIndexer.Controls.Add(this.label7);
            this.groupIndexer.Controls.Add(this.label6);
            this.groupIndexer.Location = new System.Drawing.Point(6, 168);
            this.groupIndexer.Name = "groupIndexer";
            this.groupIndexer.Size = new System.Drawing.Size(534, 81);
            this.groupIndexer.TabIndex = 1;
            this.groupIndexer.TabStop = false;
            this.groupIndexer.Text = "Indexer";
            this.groupIndexer.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(446, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Abrir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(70, 49);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(240, 21);
            this.comboBox5.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.tbprojetoBindingSource1;
            this.comboBox4.DisplayMember = "nmprojeto";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(70, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(240, 21);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "idprojeto";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // tbprojetoBindingSource1
            // 
            this.tbprojetoBindingSource1.DataMember = "tb_projeto";
            this.tbprojetoBindingSource1.DataSource = this.cad_proDataSet;
            // 
            // cad_proDataSet
            // 
            this.cad_proDataSet.DataSetName = "cad_proDataSet";
            this.cad_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nº Remessa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Projeto";
            // 
            // tbprojetoBindingSource
            // 
            this.tbprojetoBindingSource.DataMember = "tb_projeto";
            this.tbprojetoBindingSource.DataSource = this.cad_proDataSet;
            // 
            // tb_projetoTableAdapter
            // 
            this.tb_projetoTableAdapter.ClearBeforeFill = true;
            // 
            // telamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "telamenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Protocolo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telamenu_FormClosed);
            this.Load += new System.EventHandler(this.telamenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupPesquisa.ResumeLayout(false);
            this.groupPallet.ResumeLayout(false);
            this.groupPallet.PerformLayout();
            this.groupIndexer.ResumeLayout(false);
            this.groupIndexer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtRemessa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Button BtPatch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupIndexer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private cad_proDataSet cad_proDataSet;
        private System.Windows.Forms.BindingSource tbprojetoBindingSource;
        private cad_proDataSetTableAdapters.tb_projetoTableAdapter tb_projetoTableAdapter;
        private System.Windows.Forms.BindingSource tbprojetoBindingSource1;
        private System.Windows.Forms.GroupBox groupPallet;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupPesquisa;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtAtrsenhausuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
    }
}