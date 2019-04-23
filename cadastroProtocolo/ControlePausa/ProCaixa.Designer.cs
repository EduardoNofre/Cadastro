namespace CadastroProtocolo
{
    partial class ProCaixa
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
            this.CrvProCaixa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbprojetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_proDataSet = new CadastroProtocolo.cad_proDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_projetoTableAdapter = new CadastroProtocolo.cad_proDataSetTableAdapters.tb_projetoTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrvProCaixa
            // 
            this.CrvProCaixa.ActiveViewIndex = -1;
            this.CrvProCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvProCaixa.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvProCaixa.Location = new System.Drawing.Point(6, 39);
            this.CrvProCaixa.Name = "CrvProCaixa";
            this.CrvProCaixa.Size = new System.Drawing.Size(939, 588);
            this.CrvProCaixa.TabIndex = 0;
            this.CrvProCaixa.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbprojetoBindingSource
            // 
            this.tbprojetoBindingSource.DataMember = "tb_projeto";
            this.tbprojetoBindingSource.DataSource = this.cad_proDataSet;
            // 
            // cad_proDataSet
            // 
            this.cad_proDataSet.DataSetName = "cad_proDataSet";
            this.cad_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_projetoTableAdapter
            // 
            this.tb_projetoTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(63, 13);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remessa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CrvProCaixa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 633);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // ProCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(960, 654);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProCaixa";
            this.Load += new System.EventHandler(this.ProCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_proDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvProCaixa;
        private System.Windows.Forms.Button button1;
        private cad_proDataSet cad_proDataSet;
        private System.Windows.Forms.BindingSource tbprojetoBindingSource;
        private cad_proDataSetTableAdapters.tb_projetoTableAdapter tb_projetoTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}