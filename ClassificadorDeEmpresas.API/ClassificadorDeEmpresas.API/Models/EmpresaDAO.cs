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

        public bool cadastrarEmpresa(string emp_nome, string indice, string qntdNotas, string qntdDebitos)
        {
            try
            {
                var emp_indice = Convert.ToInt32(indice);
                var emp_qntdNotas = Convert.ToInt32(qntdNotas);
                var emp_qntdDebitos = Convert.ToInt32(qntdDebitos);

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Empresas (emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos) values ('" + emp_nome + "'," + emp_indice + "," + emp_qntdNotas + "," + emp_qntdDebitos + ");";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterarEmpresa(string id, string emp_nome, string nvIndice, string qntdNotas, string qntdDebitos)
        {
            try
            {
                var emp_id = Convert.ToInt32(id);
                var novoIndice = Convert.ToInt32(nvIndice);
                var emp_qntdNotas = Convert.ToInt32(qntdNotas);
                var emp_qntdDebitos = Convert.ToInt32(qntdDebitos);

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update empresas set emp_nome = '" + emp_nome + "',emp_indice = " + novoIndice + ",emp_qntdNotas = " + emp_qntdNotas + ",emp_qntdDebitos = " + emp_qntdDebitos + " where emp_id = " + emp_id + ";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Deleta um empresa na base da dados através do id.
        /// </summary>
        /// <param name="emp_id"></param>
        /// <returns></returns>
        public bool deletarEmpresa(string id)
        {
            try
            {
                var emp_id = Convert.ToInt32(id);

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from empresas where emp_id = " + emp_id + ";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Busca todas as empresas na base de dados, ordenando tal lista pelo id.
        /// </summary>
        /// <returns></returns>
        public List<Empresa> BuscarEmpresas()
        {
            try
            {
                var empresas = new List<Empresa>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select emp_id,emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos from empresas order by emp_id asc;", connection))
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
        /// <summary>
        /// Busca todas as empresas na base de dados, ordenando tal lista pelo indice.
        /// </summary>
        /// <returns></returns>
        public List<Empresa> BuscarEmpresasIndices()
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
        /// <summary>
        /// Busca todas as empresas na base de dados, ordenando tal lista pelas notas.
        /// </summary>
        /// <returns></returns>
        public List<Empresa> BuscarEmpresasNotas()
        {
            try
            {
                var empresas = new List<Empresa>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select emp_id,emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos from empresas order by emp_qntdNotas desc;", connection))
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
        /// <summary>
        /// Busca todas as empresas na base de dados, ordenando tal lista pelos debitos.
        /// </summary>
        /// <returns></returns>
        public List<Empresa> BuscarEmpresasDebitos()
        {
            try
            {
                var empresas = new List<Empresa>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select emp_id,emp_nome,emp_indice,emp_qntdNotas,emp_qntdDebitos from empresas order by emp_qntdDebitos desc;", connection))
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
    }
}
