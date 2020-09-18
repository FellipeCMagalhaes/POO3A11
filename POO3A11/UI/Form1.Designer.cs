namespace POO3A11
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
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_editora = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_dt_cadastro = new System.Windows.Forms.Label();
            this.lbl_paginas = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_val = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_editora = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.dtp_cadastro = new System.Windows.Forms.DateTimePicker();
            this.txt_paginas = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dgv_grid = new System.Windows.Forms.DataGridView();
            this.btn_salva = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(26, 54);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(59, 13);
            this.lbl_autor.TabIndex = 0;
            this.lbl_autor.Text = "Id do Autor";
            // 
            // lbl_editora
            // 
            this.lbl_editora.AutoSize = true;
            this.lbl_editora.Location = new System.Drawing.Point(26, 83);
            this.lbl_editora.Name = "lbl_editora";
            this.lbl_editora.Size = new System.Drawing.Size(67, 13);
            this.lbl_editora.TabIndex = 1;
            this.lbl_editora.Text = "Id da Editora";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(26, 112);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Titulo";
            // 
            // lbl_dt_cadastro
            // 
            this.lbl_dt_cadastro.AutoSize = true;
            this.lbl_dt_cadastro.Location = new System.Drawing.Point(26, 141);
            this.lbl_dt_cadastro.Name = "lbl_dt_cadastro";
            this.lbl_dt_cadastro.Size = new System.Drawing.Size(90, 13);
            this.lbl_dt_cadastro.TabIndex = 3;
            this.lbl_dt_cadastro.Text = "Data de Cadastro";
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Location = new System.Drawing.Point(26, 170);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(75, 13);
            this.lbl_paginas.TabIndex = 4;
            this.lbl_paginas.Text = "N° de Páginas";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(26, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id";
            // 
            // lbl_val
            // 
            this.lbl_val.AutoSize = true;
            this.lbl_val.Location = new System.Drawing.Point(26, 199);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(31, 13);
            this.lbl_val.TabIndex = 5;
            this.lbl_val.Text = "Valor";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(175, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 20);
            this.txt_id.TabIndex = 6;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(175, 51);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(196, 20);
            this.txt_autor.TabIndex = 7;
            // 
            // txt_editora
            // 
            this.txt_editora.Location = new System.Drawing.Point(175, 80);
            this.txt_editora.Name = "txt_editora";
            this.txt_editora.Size = new System.Drawing.Size(196, 20);
            this.txt_editora.TabIndex = 8;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(175, 109);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(196, 20);
            this.txt_titulo.TabIndex = 9;
            // 
            // dtp_cadastro
            // 
            this.dtp_cadastro.Location = new System.Drawing.Point(175, 135);
            this.dtp_cadastro.MaxDate = new System.DateTime(2020, 9, 12, 0, 0, 0, 0);
            this.dtp_cadastro.Name = "dtp_cadastro";
            this.dtp_cadastro.Size = new System.Drawing.Size(196, 20);
            this.dtp_cadastro.TabIndex = 13;
            this.dtp_cadastro.Value = new System.DateTime(2020, 9, 12, 0, 0, 0, 0);
            // 
            // txt_paginas
            // 
            this.txt_paginas.Location = new System.Drawing.Point(175, 167);
            this.txt_paginas.Name = "txt_paginas";
            this.txt_paginas.Size = new System.Drawing.Size(196, 20);
            this.txt_paginas.TabIndex = 14;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(175, 196);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(196, 20);
            this.txt_valor.TabIndex = 15;
            // 
            // dgv_grid
            // 
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Location = new System.Drawing.Point(29, 257);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.Size = new System.Drawing.Size(737, 150);
            this.dgv_grid.TabIndex = 16;
            this.dgv_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grid_CellClick);
            // 
            // btn_salva
            // 
            this.btn_salva.Location = new System.Drawing.Point(447, 22);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(150, 34);
            this.btn_salva.TabIndex = 17;
            this.btn_salva.Text = "Salvar";
            this.btn_salva.UseVisualStyleBackColor = true;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(447, 102);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 34);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(447, 182);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(150, 34);
            this.btn_busca.TabIndex = 19;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(616, 102);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(150, 34);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "Apagar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_salva);
            this.Controls.Add(this.dgv_grid);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_paginas);
            this.Controls.Add(this.dtp_cadastro);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_editora);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_val);
            this.Controls.Add(this.lbl_paginas);
            this.Controls.Add(this.lbl_dt_cadastro);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_editora);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_autor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_editora;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_dt_cadastro;
        private System.Windows.Forms.Label lbl_paginas;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_val;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_editora;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.DateTimePicker dtp_cadastro;
        private System.Windows.Forms.TextBox txt_paginas;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.Button btn_salva;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_del;
    }
}

