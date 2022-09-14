using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _211080_211075
{
    public partial class Form1 : Form
    {
        double total = 0;
        double selecao = 0;
        double valor_venda = 0;
        double valor_compra = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMercado.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgvMercado.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgvMercado.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgvMercado.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dgvMercado.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgvMercado.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgvMercado.Columns.Insert(6, new DataGridViewTextBoxColumn());


            dgvMercado.Columns[0].Name = "OK";
            dgvMercado.Columns[1].Name = "ID";
            dgvMercado.Columns[2].Name = "EAN";
            dgvMercado.Columns[3].Name = "PRODUTO";
            dgvMercado.Columns[4].Name = "VALOR DE COMPRA";
            dgvMercado.Columns[5].Name = "VALOR DE VENDA";
            dgvMercado.Columns[6].Name = "ESTOQUE";

            dgvMercado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMercado.ReadOnly = true;
            dgvMercado.AllowUserToAddRows = false;
            dgvMercado.AllowUserToDeleteRows = false;
            dgvMercado.AllowUserToOrderColumns = true;

            dgvMercado.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMercado.Columns[4].DefaultCellStyle.Format = "###, ###, ##0.00";

            dgvMercado.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMercado.Columns[5].DefaultCellStyle.Format = "###, ###, ##0.00";
        }

        private void btnImportarArquivos_Click(object sender, EventArgs e)
        {
            dgvMercado.RowCount = 0;
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                int id = int.Parse(dados[0]);
                string ean = dados[1];
                string produto = dados[2];
                valor_compra = double.Parse(dados[3]);
                valor_venda = double.Parse(dados[4]);
                int estoque = int.Parse(dados[5]);
                dgvMercado.Rows.Add(false, id, ean, produto, valor_compra, valor_venda, estoque);

                total += valor_compra + valor_venda;

                foreach (DataGridViewRow row in dgvMercado.Rows)
                {

                    if (double.Parse(row.Cells[5].Value.ToString()) < double.Parse(row.Cells[4].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            lblTotal.Text = total.ToString("C");
        }

        private void dgvMercado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMercado.Rows.Count > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvMercado.CurrentRow.Cells[0].Value) == false)
                {
                    dgvMercado.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgvMercado.CurrentRow.Cells[5].Value);
                    selecao += Convert.ToDouble(dgvMercado.CurrentRow.Cells[4].Value);
                }
                else
                {
                    dgvMercado.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgvMercado.CurrentRow.Cells[5].Value);
                    selecao -= Convert.ToDouble(dgvMercado.CurrentRow.Cells[4].Value);
                }
                lblSelecao.Text = selecao.ToString("C");
            }
        }
        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvMercado.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[4].Value);
                selecao += Convert.ToDouble(linha.Cells[5].Value);
            }
            lblSelecao.Text = selecao.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvMercado.Rows)
            {
                linha.Cells[0].Value = false;
            }
            lblSelecao.Text = selecao.ToString("C");        
        }

        double total_linha = 0;
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvMercado.Rows)
            {
                total_linha = double.Parse(linha.Cells[4].Value.ToString()) + double.Parse(linha.Cells[5].Value.ToString());

                if (Boolean.Parse(linha.Cells[0].Value.ToString()) == true)
                {
                    selecao = selecao - total_linha;
                    total = total - total_linha;
                }
                
            }
            for (int id = dgvMercado.RowCount - 1; id >= 0; id--)
                if (Convert.ToBoolean(dgvMercado.Rows[id].Cells[0].Value) == true)
                    dgvMercado.Rows.Remove(dgvMercado.Rows[id]);
            lblSelecao.Text = selecao.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private void btnAumentoPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
