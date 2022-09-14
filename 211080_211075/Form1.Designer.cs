namespace _211080_211075
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImportarArquivos = new System.Windows.Forms.Button();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.dgvMercado = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAumentoPreco = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(622, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(46, 41);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImportarArquivos
            // 
            this.btnImportarArquivos.BackColor = System.Drawing.Color.LightGray;
            this.btnImportarArquivos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImportarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarArquivos.Location = new System.Drawing.Point(12, 12);
            this.btnImportarArquivos.Name = "btnImportarArquivos";
            this.btnImportarArquivos.Size = new System.Drawing.Size(117, 41);
            this.btnImportarArquivos.TabIndex = 1;
            this.btnImportarArquivos.Text = "Importar Arquivos";
            this.btnImportarArquivos.UseVisualStyleBackColor = false;
            this.btnImportarArquivos.Click += new System.EventHandler(this.btnImportarArquivos_Click);
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarTodos.Location = new System.Drawing.Point(551, 455);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(117, 41);
            this.btnMarcarTodos.TabIndex = 2;
            this.btnMarcarTodos.Text = "Marcar Todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = false;
            this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnDesmarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDesmarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(551, 502);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(117, 41);
            this.btnDesmarcarTodos.TabIndex = 4;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = false;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleção:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(84, 471);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecao.Location = new System.Drawing.Point(114, 518);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(54, 25);
            this.lblSelecao.TabIndex = 8;
            this.lblSelecao.Text = "0,00";
            // 
            // dgvMercado
            // 
            this.dgvMercado.AllowUserToAddRows = false;
            this.dgvMercado.AllowUserToDeleteRows = false;
            this.dgvMercado.AllowUserToOrderColumns = true;
            this.dgvMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercado.Location = new System.Drawing.Point(12, 66);
            this.dgvMercado.Name = "dgvMercado";
            this.dgvMercado.ReadOnly = true;
            this.dgvMercado.Size = new System.Drawing.Size(656, 383);
            this.dgvMercado.TabIndex = 9;
            this.dgvMercado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMercado_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(428, 455);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 41);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir Pruduto";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAumentoPreco
            // 
            this.btnAumentoPreco.BackColor = System.Drawing.Color.LightGray;
            this.btnAumentoPreco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAumentoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentoPreco.Location = new System.Drawing.Point(428, 502);
            this.btnAumentoPreco.Name = "btnAumentoPreco";
            this.btnAumentoPreco.Size = new System.Drawing.Size(117, 41);
            this.btnAumentoPreco.TabIndex = 11;
            this.btnAumentoPreco.Text = "Aumento de preço";
            this.btnAumentoPreco.UseVisualStyleBackColor = false;
            this.btnAumentoPreco.Click += new System.EventHandler(this.btnAumentoPreco_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(680, 559);
            this.Controls.Add(this.btnAumentoPreco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvMercado);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnMarcarTodos);
            this.Controls.Add(this.btnImportarArquivos);
            this.Controls.Add(this.btnFechar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImportarArquivos;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.DataGridView dgvMercado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAumentoPreco;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}

