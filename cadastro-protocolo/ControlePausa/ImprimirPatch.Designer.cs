namespace CadastroProtocolo
{
    partial class ImprimirPatch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.CrvGerarPatch = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbProjeto = new System.Windows.Forms.TextBox();
            this.tbTipodoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtGerarPatch = new System.Windows.Forms.Button();
            this.tbprojetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_pro_SEFAZDataSet = new CadastroProtocolo.cad_pro_SEFAZDataSet();
            this.tb_projetoTableAdapter = new CadastroProtocolo.cad_pro_SEFAZDataSetTableAdapters.tb_projetoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_pro_SEFAZDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.CrvGerarPatch);
            this.groupBox1.Controls.Add(this.tbProjeto);
            this.groupBox1.Controls.Add(this.tbTipodoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtGerarPatch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 614);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(63, 18);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // CrvGerarPatch
            // 
            this.CrvGerarPatch.ActiveViewIndex = -1;
            this.CrvGerarPatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvGerarPatch.CachedPageNumberPerDoc = 10;
            this.CrvGerarPatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvGerarPatch.Location = new System.Drawing.Point(6, 45);
            this.CrvGerarPatch.Name = "CrvGerarPatch";
            this.CrvGerarPatch.Size = new System.Drawing.Size(964, 555);
            this.CrvGerarPatch.TabIndex = 9;
            this.CrvGerarPatch.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbProjeto
            // 
            this.tbProjeto.Location = new System.Drawing.Point(348, 19);
            this.tbProjeto.Name = "tbProjeto";
            this.tbProjeto.Size = new System.Drawing.Size(100, 20);
            this.tbProjeto.TabIndex = 7;
            this.tbProjeto.Visible = false;
            // 
            // tbTipodoc
            // 
            this.tbTipodoc.Location = new System.Drawing.Point(242, 19);
            this.tbTipodoc.Name = "tbTipodoc";
            this.tbTipodoc.Size = new System.Drawing.Size(100, 20);
            this.tbTipodoc.TabIndex = 6;
            this.tbTipodoc.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remessa";
            // 
            // BtGerarPatch
            // 
            this.BtGerarPatch.Location = new System.Drawing.Point(895, 16);
            this.BtGerarPatch.Name = "BtGerarPatch";
            this.BtGerarPatch.Size = new System.Drawing.Size(75, 23);
            this.BtGerarPatch.TabIndex = 1;
            this.BtGerarPatch.Text = "Gerar";
            this.BtGerarPatch.UseVisualStyleBackColor = true;
            this.BtGerarPatch.Click += new System.EventHandler(this.BtGerarPatch_Click);
            // 
            // tbprojetoBindingSource
            // 
            this.tbprojetoBindingSource.DataMember = "tb_projeto";
            this.tbprojetoBindingSource.DataSource = this.cad_pro_SEFAZDataSet;
            // 
            // cad_pro_SEFAZDataSet
            // 
            this.cad_pro_SEFAZDataSet.DataSetName = "cad_pro_SEFAZDataSet";
            this.cad_pro_SEFAZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_projetoTableAdapter
            // 
            this.tb_projetoTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimirPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1001, 638);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImprimirPatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Patch.";
            this.Load += new System.EventHandler(this.ImprimirPatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprojetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_pro_SEFAZDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvGerarPatch;
        private System.Windows.Forms.TextBox tbProjeto;
        private System.Windows.Forms.TextBox tbTipodoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtGerarPatch;
        private cad_pro_SEFAZDataSet cad_pro_SEFAZDataSet;
        private System.Windows.Forms.BindingSource tbprojetoBindingSource;
        private cad_pro_SEFAZDataSetTableAdapters.tb_projetoTableAdapter tb_projetoTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}