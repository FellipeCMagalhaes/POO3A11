using POO3A11.BLL;
using POO3A11.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3A11
{
    public partial class Form1 : Form
    {

        TBL_LivroBLL bllCliente = new TBL_LivroBLL();
        TBL_LivroDTO dtoCliente = new TBL_LivroDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_grid.DataSource = bllCliente.Listarlivros();



        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            try
            {

                dtoCliente.Idautor = int.Parse(txt_autor.Text);
                dtoCliente.Ideditora = int.Parse(txt_editora.Text);
                dtoCliente.Titulo = txt_titulo.Text.ToString();
                dtoCliente.Dt_cadastro = DateTime.Parse(dtp_cadastro.CustomFormat);
                dtoCliente.Paginas = int.Parse(txt_paginas.Text);
                dtoCliente.Valor = double.Parse(txt_valor.Text);



                bllCliente.Inserirlivro(dtoCliente);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_grid.DataSource = bllCliente.Listarlivros();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            string condicao = "idLivro like '%" + int.Parse(txt_id.Text) + "%'" +
                             "or titulo like '%" + txt_titulo.Text + "%'" +
                             "or idAutor like '%" + int.Parse(txt_autor.Text) + "%'" +
                             "or idEditora like '%" + int.Parse(txt_editora.Text) + "%'";
            dgv_grid.DataSource = bllCliente.Pesquisarlivro(condicao);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dtoCliente.Idautor = int.Parse(txt_autor.Text);
            dtoCliente.Ideditora = int.Parse(txt_editora.Text);
            dtoCliente.Titulo = txt_titulo.Text.ToString();
            dtoCliente.Dt_cadastro = DateTime.Parse(dtp_cadastro.CustomFormat);
            dtoCliente.Paginas = int.Parse(txt_paginas.Text);
            dtoCliente.Valor = double.Parse(txt_valor.Text);

            bllCliente.Alterarlivro(dtoCliente);
            dgv_grid.DataSource = bllCliente.Listarlivros();
        }

        private void dgv_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_autor.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_editora.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_titulo.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtp_cadastro.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_paginas.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_valor.Text = dgv_grid.Rows[e.RowIndex].Cells[0].Value.ToString();

            btn_edit.Enabled = true;
            btn_del.Enabled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoCliente.Idlivro = Convert.ToInt32(txt_id.Text);
                    bllCliente.Excluirlivro(dtoCliente);
                    dgv_grid.DataSource = bllCliente.Listarlivros();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
