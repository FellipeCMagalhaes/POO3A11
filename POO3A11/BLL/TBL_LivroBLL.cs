using POO3A11.DAL;
using POO3A11.DTO;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A11.BLL
{
    class TBL_LivroBLL
    {
        DALBD daobanco = new DALBD();

        public DataTable Listarlivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daobanco.ExecutarConsulta(sql);
        }

        public void Alterarlivro(TBL_LivroDTO DtoCliente)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set idAutor = '{DtoCliente.Idautor}',
                                                                 idEditora = '{DtoCliente.Ideditora}',
                                                                 titulo = '{DtoCliente.Titulo}',
                                                                 dataCadastro = '{DtoCliente.Dt_cadastro}',
                                                                 numPaginas = '{DtoCliente.Paginas}',
                                                                 valor = '{DtoCliente.Valor}'
                                                   where idLivro = '{DtoCliente.Idlivro}';");
            daobanco.ExecutarComando(sql);
        }

        public void Inserirlivro(TBL_LivroDTO ObjCliente)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL, '{ObjCliente.Idautor}',
                                                                                '{ObjCliente.Ideditora}',
                                                                                '{ObjCliente.Titulo}',
                                                                                '{ObjCliente.Dt_cadastro}',
                                                                                '{ObjCliente.Paginas}',    
                                                                                '{ObjCliente.Valor}');");
            daobanco.ExecutarComando(sql);
        }

        public void Excluirlivro(TBL_LivroDTO objCliente)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {objCliente.Idlivro};");
            daobanco.ExecutarComando(sql);
        }

        public DataTable Pesquisarlivro(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Livro where " + condicao);
            return daobanco.ExecutarConsulta(sql);
        }

    }
}
