namespace CadastroProtocolo
{
    partial class Indexer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox14 = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.BtInsert = new System.Windows.Forms.Button();
            this.cad_proDataSet = new CadastroProtocolo.cad_proDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.indiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tbprojetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_projetoTableAdapter = new CadastroProtocolo.cad_proDataSetTableAdapters.tb_projetoTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo Processo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Documento";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(115, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 13;
            this.comboBox3.Location = new System.Drawing.Point(115, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(210, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processo e Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 274);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indices";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.BtUpdate);
            this.panel6.Controls.Add(this.maskedTextBox4);
            this.panel6.Controls.Add(this.maskedTextBox14);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Controls.Add(this.BtInsert);
            this.panel6.Location = new System.Drawing.Point(6, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 174);
            this.panel6.TabIndex = 18;
            this.panel6.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(397, 148);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtUpdate.TabIndex = 6;
            this.BtUpdate.Text = "Salvar";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Visible = false;
            this.BtUpdate.Click += new System.EventHandler(this.button14_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(161, 3);
            this.maskedTextBox4.Mask = "0000000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(311, 26);
            this.maskedTextBox4.TabIndex = 4;
            this.maskedTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox4_KeyDown);
            // 
            // maskedTextBox14
            // 
            this.maskedTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox14.Location = new System.Drawing.Point(161, 43);
            this.maskedTextBox14.Mask = "00000000";
            this.maskedTextBox14.Name = "maskedTextBox14";
            this.maskedTextBox14.Size = new System.Drawing.Size(312, 26);
            this.maskedTextBox14.TabIndex = 5;
            this.maskedTextBox14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox14_KeyDown);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(2, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(147, 20);
            this.label28.TabIndex = 21;
            this.label28.Text = "Código Participante";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(2, 5);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(123, 20);
            this.label32.TabIndex = 25;
            this.label32.Text = "Numero do Lote";
            // 
            // BtInsert
            // 
            this.BtInsert.Location = new System.Drawing.Point(397, 148);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(75, 23);
            this.BtInsert.TabIndex = 14;
            this.BtInsert.Text = "Salvar";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.button8_Click);
            // 
            // cad_proDataSet
            // 
            this.cad_proDataSet.DataSetName = "cad_proDataSet";
            this.cad_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // indiceDataGridViewTextBoxColumn
            // 
            this.indiceDataGridViewTextBoxColumn.DataPropertyName = "Indice";
            this.indiceDataGridViewTextBoxColumn.HeaderText = "Indice";
            this.indiceDataGridViewTextBoxColumn.Name = "indiceDataGridViewTextBoxColumn";
            // 
            // indiceDataGridViewTextBoxColumn1
            // 
            this.indiceDataGridViewTextBoxColumn1.DataPropertyName = "Indice";
            this.indiceDataGridViewTextBoxColumn1.HeaderText = "Indice";
            this.indiceDataGridViewTextBoxColumn1.Name = "indiceDataGridViewTextBoxColumn1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(418, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "Finalizar Remessa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(12, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Suspender Remessa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(237, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 23;
            this.textBox7.Visible = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(11, 426);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(76, 13);
            this.label47.TabIndex = 24;
            this.label47.Text = "Documentos:  ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Red;
            this.label48.Location = new System.Drawing.Point(83, 426);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(0, 13);
            this.label48.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(237, 35);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 26;
            this.textBox11.Visible = false;
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
            // Indexer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(511, 446);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Indexer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indexer";
            this.Load += new System.EventHandler(this.Indexer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Indexer_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private cad_proDataSet cad_proDataSet;
        private System.Windows.Forms.BindingSource tbprojetoBindingSource;
        private cad_proDataSetTableAdapters.tb_projetoTableAdapter tb_projetoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox14;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button button1;
    }
}