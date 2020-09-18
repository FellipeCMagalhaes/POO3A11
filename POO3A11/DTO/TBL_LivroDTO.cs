using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A11.DTO
{
    class TBL_LivroDTO
    {

        //atributos da tabela
        private int ideditora, idautor, idlivro, paginas;
        private string titulo;
        private double valor;
        private DateTime dt_cadastro;


        //metodos get e set - verificação
        public string Titulo 
        {
            set
            {
                if(value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O capo Título é obrigatório.");
                }
            }
            get { return this.titulo; }
        }

        public int Ideditora {
            set
            {
                if (value != 0)
                {
                    this.ideditora = value;
                }
                else
                {
                    throw new Exception("O campo Id da Editora é obrigatório");
                }
            }
            get { return this.ideditora; }
        }

        public int Idautor {
            set
            {
                if (value != 0)
                {
                    this.idautor = value;
                }
                else
                {
                    throw new Exception("O campo Id do Autor é obrigatório");
                }
            }
            get { return this.idautor; }
        } 
        
        public int Paginas {
            set
            {
                if (value != 0)
                {
                    this.paginas = value;
                }
                else
                {
                    throw new Exception("O campo N° de Páginas é obrigatório");
                }
            }
            get { return this.paginas; }
        }

        public int Idlivro { get => idlivro; set => idlivro = value; }
        public double Valor {
            set
            {
                if (value >= 0)
                {
                    this.valor = value;
                }
                else
                {
                    throw new Exception("O capo Valor é obrigatório.");
                }
            }
            get { return this.valor; }
        }

        public DateTime Dt_cadastro {
            set
            {
                if (value <= DateTime.MaxValue)
                {
                    this.dt_cadastro = value;
                }
                else
                {
                    throw new Exception("O capo Data de Cadastro é obrigatório.");
                }
            }
            get { return this.dt_cadastro; }
        }
    }
}
