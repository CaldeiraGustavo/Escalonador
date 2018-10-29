namespace Aed_So_Interdisciplinar
{
    partial class btnInserir
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnIniciarExecao = new System.Windows.Forms.Button();
            this.listViewProcessos = new System.Windows.Forms.ListView();
            this.columnPrioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClicExecut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carregar Processos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnIniciarExecao
            // 
            this.btnIniciarExecao.Location = new System.Drawing.Point(2, 58);
            this.btnIniciarExecao.Name = "btnIniciarExecao";
            this.btnIniciarExecao.Size = new System.Drawing.Size(163, 37);
            this.btnIniciarExecao.TabIndex = 6;
            this.btnIniciarExecao.Text = "Iniciar Exeução";
            this.btnIniciarExecao.UseVisualStyleBackColor = true;
            this.btnIniciarExecao.Click += new System.EventHandler(this.btnIniciarExecao_Click);
            // 
            // listViewProcessos
            // 
            this.listViewProcessos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listViewProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPrioridade,
            this.columnNameProcess,
            this.columnPID,
            this.columnClicExecut});
            this.listViewProcessos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewProcessos.FullRowSelect = true;
            this.listViewProcessos.Location = new System.Drawing.Point(191, 44);
            this.listViewProcessos.Name = "listViewProcessos";
            this.listViewProcessos.Size = new System.Drawing.Size(774, 391);
            this.listViewProcessos.TabIndex = 9;
            this.listViewProcessos.UseCompatibleStateImageBehavior = false;
            this.listViewProcessos.View = System.Windows.Forms.View.Details;
            // 
            // columnPrioridade
            // 
            this.columnPrioridade.Text = "Prioridade";
            this.columnPrioridade.Width = 70;
            // 
            // columnNameProcess
            // 
            this.columnNameProcess.Text = "Nome Processo";
            this.columnNameProcess.Width = 129;
            // 
            // columnPID
            // 
            this.columnPID.Text = "Prioridade";
            this.columnPID.Width = 116;
            // 
            // columnClicExecut
            // 
            this.columnClicExecut.Text = "N Ciclos Executados";
            this.columnClicExecut.Width = 157;
            // 
            // btnInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 623);
            this.Controls.Add(this.listViewProcessos);
            this.Controls.Add(this.btnIniciarExecao);
            this.Controls.Add(this.button1);
            this.Name = "btnInserir";
            this.Text = "list";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnIniciarExecao;
        private System.Windows.Forms.ListView listViewProcessos;
        private System.Windows.Forms.ColumnHeader columnPrioridade;
        private System.Windows.Forms.ColumnHeader columnNameProcess;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.ColumnHeader columnClicExecut;
    }
}

