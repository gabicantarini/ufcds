using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace GestaoFormandos
{
    internal class DBConnect
    {
        private MySqlConnection connection; //Objeto de conexão MySQL
        private string server; // Informações de conexão: servidor, usuário, senha, etc.
        private string username;
        private string password;
        private string database;
        private string port;

        public DBConnect() // Método construtor da classe
        {
            Initialize();// Inicializa os dados de conexão
        }
        private void Initialize() // Método para inicializar os dados de conexão
        {
            server = "192.168.221.128"; // Endereço do servidor MySQL
            database = "gestaoformandos";// Nome do banco de dados
            username = "programador";// Nome de usuário
            password = "Programador15";// Senha
            port = "3306";// Porta padrão do MySQL

            // Construção da string de conexão
            string connectionString = "Server = " + server + ";Port = " + port + ";Database = " + database + "; Uid = " + username + "; Pwd = " + password + ";";

            // Inicialização do objeto de conexão
            connection = new MySqlConnection(connectionString);
        }
        // Método para abrir a conexão com o banco de dados
        private bool OpenConnection()
        {
            try
            {
                connection.Open();// Abre a conexão
                return true;// Retorna verdadeiro se a conexão for aberta com sucesso
            }
            catch (MySqlException ex)// Captura exceções do MySQL
            {
                MessageBox.Show(ex.Message);// Exibe mensagem de erro em caso de exceção
                return false;// Retorna falso se ocorrer uma exceção ao fechar a conexão
            }
        }
        // Método para fechar a conexão com o banco de dados
        private bool CloseConnection()
        {
            try
            {
                connection.Close();// Fecha a conexão
                return true;// Retorna verdadeiro se a conexão for fechada com sucesso
            }
            catch (MySqlException ex)// Captura exceções do MySQL
            {
                MessageBox.Show(ex.Message);// Exibe mensagem de erro em caso de exceção
                return false; // Retorna falso se ocorrer uma exceção ao fechar a conexão
            }
        }
        //verificar o estado da conexão com o banco de dados
        public string StatusConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();// Abre a conexão se estiver fechada
                }
                else
                {
                    connection.Close();// Fecha a conexão se estiver aberta
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection.State.ToString();// Retorna o estado da conexão como uma string
        }
        //count statement
        public int Count()
        {
            int count = -1; // Inicializa a variável count com -1 como valor padrão, indicando um erro ou falha na contagem
            string query = "select count(*) from formando";// Consulta SQL para contar o número de registros na tabela "formando"
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);// Cria um novo objeto MySqlCommand com a consulta SQL e a conexão
                    count = int.Parse(cmd.ExecuteScalar().ToString());// Executa a consulta SQL e converte o resultado para um número inteiro
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
      
        public void Insert()
        {
            // Define a consulta SQL para inserir um novo registro na tabela "formando"
            string query = "Insert into formando (nome, id_formando, morada, contacto, iban, sexo, data_nascimento) values ('Pinto da Costa'," + "'10099', 'Rua do Porto', NULL, '000000000000000','M', '1950-06-22')";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                    //CloseConnection();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // O bloco finally é usado para garantir que o método CloseConnection()
            // seja chamado para fechar a conexão com o banco de dados, independentemente
            // de ocorrer uma exceção ou não durante a execução do código dentro do bloco
            // try.
            finally
            {
                CloseConnection();
            }

        }
        public bool InsertArea(int id_area, string area)
        {
            // Define a consulta SQL para inserir um novo registro na tabela "formando"
            string query = "Insert into area (id_area, area) values (" + id_area +",'"+ area +"')";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            // O bloco finally é usado para garantir que o método CloseConnection()
            // seja chamado para fechar a conexão com o banco de dados, independentemente
            // de ocorrer uma exceção ou não durante a execução do código dentro do bloco
            // try.
            finally
            {
                CloseConnection();
            }

        }
        public bool Delete()
        {
            // Define a consulta SQL para excluir o registro da tabela "formando" com o id_formando específico
            string query = "delete from formando where id_formando = '10099'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();// Executa a consulta SQL para excluir o registro da tabela

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool Delete(string id)
        {
            // Define a consulta SQL para excluir o registro da tabela "formando" com o id_formando específico passado como parâmetro
            string query = "delete from formando where id_formando = '" + id + "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool DeleteFormador(string id)
        {
            // Define a consulta SQL para excluir o registro da tabela "formador" com o id_formador específico passado como parâmetro
            string query = "delete from fomandor where id_formador = '" + id + "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool DeleteArea(string id)
        {
            // Define a consulta SQL para excluir o registro da tabela "formando" com o id_formando específico passado como parâmetro
            string query = "delete from area where id_area = '" + id + "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool Update(string id, string nome)
        {
            // Define a consulta SQL para atualizar o campo "nome" na tabela "formando" com o valor especificado
            string query = "update formando set nome = '" + nome + "' where id_formando = '" + id + "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                    //CloseConnection();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public int DevolveUltimoID()
        {
            int ultimoID = 0;
            // Define a consulta SQL para obter o maior ID da tabela "formando"
            string query = "select max(id_formando) from formando";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL para obter o maior ID e armazena
                    // o resultado na variável ultimoID
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    // Incrementa o último ID encontrado para obter o próximo ID disponível
                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return ultimoID;
        }
        public int DevolveUltimoIDArea()
        {
            int ultimoIDArea = 0;
            // Define a consulta SQL para obter o maior ID da tabela "formando"
            string query = "select max(id_area) from area";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL para obter o maior ID e armazena
                    // o resultado na variável ultimoID
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoIDArea);
                    // Incrementa o último ID encontrado para obter o próximo ID disponível
                    ultimoIDArea++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return ultimoIDArea;
        }

        public int DevolveUltimoIDFormador()
        {
            int ultimoID = 0;
            // Define a consulta SQL para obter o maior ID da tabela "formador"
            string query = "select max(id_formador) from formador";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL para obter o maior ID e armazena
                    // o resultado na variável ultimoID
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    // Incrementa o último ID encontrado para obter o próximo ID disponível
                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return ultimoID;
        }


        public bool Insert(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            // Monta a consulta SQL para inserir um novo registro na tabela "formando" com os valores fornecidos
            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento, id_nacionalidade) values ('" + ID + "', '" + nome + "', '" + morada + "', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "', '" + id_nacionalidade + "');";


            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool InsertFormador(string ID, string nome, string NIF, string data_nascimento, string id_area, string id_utilizador)
        {
            // Monta a consulta SQL para inserir um novo registro na tabela "formador" com os valores fornecidos
            string query = "insert into formador (id_formador, nome, nif, dataNascimento, id_area, id_utilizador) values ('" + ID + "','" + nome + "', '" + NIF + "', '" + data_nascimento + "', '" + id_area + "', '" + id_utilizador + "');";


            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool PesquisaFormando(string ID_pesquisa, ref string nome, ref string morada, ref string contacto, ref string iban, ref char sexo, ref string data_nascimento, ref string nacionalidade)
        {
            bool flag = false;

            // Define a consulta SQL para selecionar informações do formando com o ID fornecido
            string query = "select nome, morada, contacto, iban, sexo, data_nascimento, id_nacionalidade from formando" +
                " where id_formando = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL usando o método ExecuteReader() do objeto
                    // MySqlCommand e armazena o resultado em um objeto MySqlDataReader
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())// Itera sobre as linhas retornadas pela consulta SQL
                    {
                        nome = dataReader[0].ToString();// Obtém o valor da coluna 'nome' da linha atual e armazena em 'nome'
                        morada = dataReader["morada"].ToString();
                        contacto = dataReader[2].ToString();
                        iban = dataReader[3].ToString();
                        sexo = dataReader["sexo"].ToString()[0];
                        data_nascimento = dataReader[5].ToString();
                        nacionalidade = dataReader[6].ToString();
                        flag = true;
                    }
                    // Fecha o leitor de dados após a conclusão da leitura
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool PesquisaFormador(string ID_pesquisa, ref string nome, ref string nif, ref string dataNascimento, ref string idArea, ref string idUtilizador)
        {
            bool flag = false;

            // Define a consulta SQL para selecionar informações do formardor com o ID fornecido
            string query = "select nome, nif, dataNascimento, id_area, id_utilizador from formador" +
                " where id_formador = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL usando o método ExecuteReader() do objeto
                    // MySqlCommand e armazena o resultado em um objeto MySqlDataReader
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())// Itera sobre as linhas retornadas pela consulta SQL
                    {
                        nome = dataReader[0].ToString();// Obtém o valor da coluna 'nome' da linha atual e armazena em 'nome'
                        nif = dataReader[1].ToString();
                        dataNascimento = dataReader[2].ToString();
                        idArea = dataReader[3].ToString();
                        idUtilizador = dataReader[4].ToString();
                        flag = true;
                    }
                    // Fecha o leitor de dados após a conclusão da leitura
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }


        public bool PesquisaArea(string ID_pesquisa, ref string area)
        {
            bool flag = false;

            // Define a consulta SQL para selecionar informações da area com o ID fornecido
            string query = "select area from area where id_area = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Executa a consulta SQL usando o método ExecuteReader() do objeto
                    // MySqlCommand e armazena o resultado em um objeto MySqlDataReader
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        area = dataReader["area"].ToString(); // Obtém o valor da coluna 'area' da linha atual e armazena em 'area'
                        flag = true;
                    }
                    // Fecha o leitor de dados após a conclusão da leitura
                    dataReader.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public void PreencherDataGridViewNacionalidade(ref DataGridView dgv)
        {
            string query = "select nacionalidade, id_nacionalidade, alf2, nacionalidade from nacionalidade;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add(); // Adiciona uma nova linha ao DataGridView
                        dgv.Rows[idxLinha].Cells["ID"].Value = dr[0].ToString();// Define o valor da célula "ID" com o valor da primeira coluna da linha atual do MySqlDataReader
                        dgv.Rows[idxLinha].Cells["ALF2"].Value = dr["ALF2"].ToString();// Define o valor da célula "ALF2" com o valor da coluna "ALF2" da linha atual do MySqlDataReader
                        dgv.Rows[idxLinha].Cells["Nacionalidade"].Value = dr["Nacionalidade"].ToString();// Define o valor da célula "Nacionalidade" com o valor da coluna "Nacionalidade" da linha atual do MySqlDataReader


                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool Update(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            string query = "update formando set nome = '" + nome + "', morada = '" + morada + "', contacto = '" + contacto + "',iban = '" + iban + "',sexo = '" + sexo + "', data_nascimento = '" + data_nascimento + "', id_nacionalidade = " + id_nacionalidade + " where id_formando = " + ID;

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool UpdateArea(string ID, string area)
        {
            string query = "update area set area = '" + area + "' where id_area = " + ID;

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool UpdateFormador(string ID, string nome, string nif, string dataNascimento, string idArea, string idUtilizador)
        {
            string query = "update formador set id_formador = '" + ID + "', nome = '" + nome + "', nif = '" + nif + "', dataNascimento = '" + dataNascimento + "',id_area = '" + idArea + "', id_utilizador = '" + idUtilizador + "' where id_formador = " + ID;

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public void PreencherDataGriedViewFormandos(ref DataGridView dgv, char genero, string nome, string id_nacionalidade)
        {
            string query = "select id_formando, nome, iban, id_nacionalidade, nacionalidade sexo from vFormando ";

            bool flag = false;

            // Verifica se o parâmetro 'genero' é diferente de 'T' (que significa todos)
            if (genero != 'T')
            {
                // Adiciona cláusula WHERE para filtrar por gênero
                query = query + " where sexo = '" + genero + "'";
                flag = true;
            }
            if (nome.Length > 0 && genero != 'T')
            {
                // Se sim, adiciona cláusula AND para filtrar por nome
                query = query + " and nome like '%" + nome + "%'";
            }
            else if (nome.Length > 0)
            {
                // Se não, adiciona cláusula WHERE para filtrar por nome
                query = query + " where nome like '%" + nome + "%'";
                flag = true;
            }
            // Verifica se o parâmetro 'id_nacionalidade' tem algum valor e se algum filtro já foi aplicado
            if (id_nacionalidade.Length > 0 && flag == true)
            {
                // Se sim, adiciona cláusula AND para filtrar por nacionalidade
                query = query + " and id_nacionalidade = '" + id_nacionalidade + "'";
            }
            else if (id_nacionalidade.Length > 0)
            {
                // Se não, adiciona cláusula WHERE para filtrar por nacionalidade
                query = query + " where id_nacionalidade = '" + id_nacionalidade + "'";
            }
            // Adiciona a cláusula ORDER BY para ordenar os resultados por nome
            query = query + " order by nome;";

            try
            {
                if (OpenConnection())
                {
                    // Cria um novo comando MySQL com a consulta SQL e a conexão
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Executa a consulta e armazena o resultado em um leitor de dados
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;

                    // Percorre os resultados e preenche as linhas do DataGridView

                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["Nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr["id_nacionalidade"].ToString();
                        dgv.Rows[idxLinha].Cells["Genero"].Value = dr["sexo"].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void PreencherDataGriedViewFormador(ref DataGridView dgv)
        {
            string query = "select id_formador, nome, nif, dataNascimento, id_area, id_utilizador from formador ";

            try
            {
                if (OpenConnection())
                {
                    // Cria um novo comando MySQL com a consulta SQL e a conexão
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Executa a consulta e armazena o resultado em um leitor de dados
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;

                    // Percorre os resultados e preenche as linhas do DataGridView

                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells[0].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLinha].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr[3].ToString();
                        dgv.Rows[idxLinha].Cells[4].Value = dr[4].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void PreencherDataGriedViewArea(ref DataGridView dgv, string id_area, string area)
        {
            string query = "select id_area, area from area";

            bool flag = false;

            if (area.Length > 0)
            {
                query = query + " where area like '%" + area + "%'";
                flag = true;
            }

            if (id_area.Length > 0)
            {
                query = query + " where id_area = '" + id_area + "'";
            }
            query = query + " order by id_area;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["ID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["Area"].Value = dr[1].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public bool UpdateNacionalidade(string nova_nacionalidade)
        {
            bool flag = true;
            string query = "UPDATE Nacionalidade SET id_nacionalidade = " + nova_nacionalidade;


            try
            {
                if(this.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id_nacionalidade", nova_nacionalidade);

                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            this.CloseConnection();
            return flag;
        }

        public bool UpdateNacionalidade(string id_nacionalidade,string ALF2, string nacionalidade)
        {
            string query = "update nacionalidade set alf2 = '" + ALF2 + "', nacionalidade = '" + nacionalidade + "'" + " where id_nacionalidade = '" + id_nacionalidade+ "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool InsertNacionalidade(string ALF2, string Nacionalidade)
        {
            string query = "insert into Nacionalidade (id_nacionalidade,alf2,nacionalidade) values (0,'" + ALF2 + "', '" + Nacionalidade + "');";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(@query, connection);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool PesquisaNacionalidade(string ALF2, ref string nacionalidade)
        {
            bool flag = false;

            string query = "select alf2, Nacionalidade" +
                " where alf2 = '" + ALF2 + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ALF2 = dataReader[0].ToString();
                        nacionalidade = dataReader["nacionalidade"].ToString();
                  
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool PesquisaNacionalidade(string id_nacionalidade, ref string ALF2, ref string nacionalidade)
        {
            bool flag = false;

            string query = "SELECT alf2, nacionalidade from nacionalidade where id_nacionalidade = '"+ id_nacionalidade + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ALF2 = dataReader[0].ToString();
                        nacionalidade = dataReader[1].ToString();
                        flag = true;
                    }
                    dataReader.Close();       
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return flag;
        }



        public void PreencherComboNacionalidade(ref ComboBox combo)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from " +
                "Nacionalidade order by nacionalidade;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[2].ToString() + " - " +
                            dr["alf2"].ToString() + " - " + dr[0].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void PreencherComboIDArea(ref ComboBox combo)
        {
            string query = "select id_area, area from " +
                "area order by area;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[1].ToString() + " - " +
                            dr[0].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void PreencherComboIDUtilizador(ref ComboBox combo)
        {
            string query = "select id_utilizador, nome_utilizador from " +
                "utilizador order by nome_utilizador;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[1].ToString() + " - " +
                            dr[0].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public string DevolverNacionalidade(string id_nacionalidade)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from " +
                "Nacionalidade where id_nacionalidade = " + id_nacionalidade;

            string nacionalidade = "";
;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        nacionalidade = dr[2].ToString() + " - " +
                            dr["alf2"].ToString() + " - " + dr[0].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return nacionalidade;
        }
        public string DevolverIDArea(string idArea)
        {
            string query = "select id_area, area from " +
                "area where id_area = " + idArea;

            string area = "";
          
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        area = dr[1].ToString() + " - " +
                            dr[0].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return area;
        }
        public string DevolverIDUtilizador(string idUtilizador)
        {
            string query = "select id_utilizador, nome_utilizador from " +
                "utilizador where id_utilizador = " + idUtilizador;

            string utilizador = "";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        utilizador = dr[1].ToString() + " - " +
                            dr[0].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return utilizador;
        }
        public bool DeleteNacionalidade(string id_nacionalidade)
        {
            string query = "delete from nacionalidade where id_nacionalidade = '" + id_nacionalidade + "'";

            bool flag = true;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public bool ValidateUser(string userName, string passWord, ref string id_user)
        {

            bool flag = false;
            try
            {
                string query = "select userRole from users where binary uname = '" + userName + "' and pwd = " +
                    "sha2('" + passWord + "',512);";

                if(OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if(cmd.ExecuteScalar() != null)
                    {   
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
                    }
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                
                CloseConnection(); 
            }
            return flag;
        }

        public bool ValidateUser2(string userName, string passWord, ref string id_user)
        {

            bool flag = false;
            try
            {
                string query = "select id_utilizador from utilizador where binary nome_utilizador = '" + userName + "' and palavra_passe = " +
                    "sha2('" + passWord + "',512) and estado = 'A';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteScalar() != null)
                    {
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                CloseConnection();
                if (flag)
                {
                    PUSuccessLogin(userName, "S");
                }
                else
                {
                    PUSuccessLogin(userName, "U");
                }
            }
            return flag;
        }

        private void PUSuccessLogin(string userName, string result)
        {
            try
            {
                string query = "call pUSuccessLogin('" + userName + "', '" + result + "');";
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                CloseConnection(); 
            }
        }
        public bool ValidateUserStatus(string userName)
        {
            bool flag = false;

            try
            {
                string query = "select id_utilizador from utilizador where nome_utilizador = '" + userName + "' and estado = 'I';";
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand( query, connection); // cria um novo objeto MySqlCommand com a consulta SQL (query) e a conexão ao banco de dados (connection).
                    if (cmd.ExecuteScalar() != null )
                    {
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                CloseConnection(); 
            }  
            return flag;
        }

        public bool ValidateUserStatus(string userName, ref int nfalhas)
        {
            bool flag = false;

            try
            {
                string query = "select falhas from utilizador where nome_utilizador = '" + userName + "' and estado = 'I';";
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteScalar() != null)
                    {
                        nfalhas = int.Parse(cmd.ExecuteScalar().ToString());
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }




    }
}
