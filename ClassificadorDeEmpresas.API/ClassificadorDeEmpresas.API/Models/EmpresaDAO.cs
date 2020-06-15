using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassificadorDeEmpresas.API.Entities;

namespace ClassificadorDeEmpresas.API.Models
{
    public class EmpresaDAO
    {
        string conexaoString = "Server=localhost;Database=empresas;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public bool cadastrarEmpresa(string emp_nome, string emp_indice, string emp_qntdNotas, string emp_qntdDebitos)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Empresas (emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos) values ('" + emp_nome + "','" + emp_indice + "','" + emp_qntdNotas + "','" + emp_qntdDebitos + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterarEmpresa(string emp_id, string emp_nome, string novoIndice, string emp_qntdNotas, string emp_qntdDebitos)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update empresas set emp_nome = '" + emp_nome + "',emp_indice = '" + novoIndice + "',emp_qntdNotas = '" + emp_qntdNotas + "',emp_qntdDebitos = '" + emp_qntdDebitos + "' where emp_id = '" + emp_id + "';";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletarEmpresa(string emp_id)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from empresas where emp_id = '" + emp_id + "';";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Empresa> BuscarEmpresas()
        {
            try
            {
                var empresas = new List<Empresa>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select emp_id,emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos from empresas order by emp_indice desc;", connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Empresa emp = new Empresa();
                                emp.emp_id = dataReader["emp_id"].ToString();
                                emp.emp_nome = dataReader["emp_nome"].ToString();
                                emp.emp_indice = dataReader["emp_indice"].ToString();
                                emp.emp_qntdNotas = dataReader["emp_qntdNotas"].ToString();
                                emp.emp_qntdDebitos = dataReader["emp_qntdDebitos"].ToString();
                                empresas.Add(emp);
                            }
                        }
                        return empresas;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de empresas" + ex.Message);
            }
        }

        public int qntdBanco()
        {
            int qntd;

            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand("select count(*) from Empresas;", connection);
            command.CommandType = CommandType.Text;

            //Atribui os dados coletados para o dr
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            qntd = Convert.ToInt32(dataReader.GetString(0));

            command.Connection.Close(); //fecha conexão

            return qntd;
        }
    }
}
