using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using Login_Window_with_SQLServer.utils;

namespace Login_Window_with_SQLServer
{
    internal static class DataInit
    {
        internal static void Initialize()
        {
            // Conexão com o banco de dados
            SqlConnection conexao = new SqlConnection(@$"{Config.ConnectionQuery}");

            // Criptografando a senha
            string senhaCriptografada = EncryptionHelper.Encrypt("1"); // Aqui você coloca a senha inicial que deseja criptografar

            // Comando SQL para criar o banco de dados
            string queryCreateDatabase = @"
                IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'LoginWind')
                BEGIN
                    CREATE DATABASE LoginWind
                END
                ";

            // Comando SQL para criar a tabela Users
            string queryCreateTable = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
                BEGIN
                    CREATE TABLE Users (
                    Id INT PRIMARY KEY IDENTITY,
                    Username NVARCHAR(50) NOT NULL,
                    Password NVARCHAR(150) NOT NULL,
                    Role NVARCHAR(50) NOT NULL, 
                    Permission INT NOT NULL,
                    )
                END
            ";

            // Comando SQL para inserir o usuário inicial
            string queryInsertUser = @$"
                IF NOT EXISTS (SELECT * FROM Users WHERE Username = 'Admin')
                BEGIN
                    INSERT INTO Users (Username, Password, Role, Permission) VALUES ('Admin', '{senhaCriptografada}', 'Administrador', 1)
                END
                ";
            try
            {
                // Abrindo a conexão
                conexao.Open();

                // Criando o banco de dados
                using (var command = new SqlCommand(queryCreateDatabase, conexao))
                {
                    command.ExecuteNonQuery();
                }

                // Selecionando o banco de dados recém-criado
                conexao.ChangeDatabase("LoginWind");

                // Criando a tabela Users
                using (var command = new SqlCommand(queryCreateTable, conexao))
                {
                    command.ExecuteNonQuery();
                }

                // Inserindo o usuário inicial
                using (var command = new SqlCommand(queryInsertUser, conexao))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inicializar o banco de dados: " + ex.Message);
            }
            finally
            {
                // Fechando a conexão
                conexao.Close();
            }
        }
    }
}
