﻿using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace POO3A11.DAL
{
    class DALBD
    {

        private MySqlConnection conexao;
        private string string_conexao = "Persist security info= false; " +
                                         "server = localhost; " +
                                         "Database=dbmvc ;" +
                                         "user = root; pwd=;";
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o banco de dados. Erro: " + e.Message + "  " + string_conexao);

            }
        }
        public void ExecutarComando(string sql)
        {
            try
            {
                
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a consulta no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
