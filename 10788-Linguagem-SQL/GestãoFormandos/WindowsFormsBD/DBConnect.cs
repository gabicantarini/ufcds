using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;
        private string port;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {                             // Uso com Xampp
            server = "192.168.1.64"; // localhost
            database = "gestaoformandos"; //
            username = "Gabriela"; //"root"
            password = "Passw0rd"; //""
            port = "3306";

            string connectionString = "Server = " + server + ";Port = " + port + ";Database = " +
                database + "; Uid = " + username + "; Pwd = " + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Open Db Connection - button On/OFF at Form1
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Close Db Connection - button On/OFF at Form1
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Return our connection status
        public string StatusConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) //verify if our Initialize connectiong string is closed
                {
                    connection.Open(); //If it is closed. We can open it.
                }
                else
                {
                    connection.Close(); // If it is open. We can close it.
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection.State.ToString();
        }

        //Return
        public int Count()
        {
            int count = -1;
            string query = "select count(*) from formando";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
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

        public void Insert_old()
        {
            string query = "Insert into formando (nome, id_formando, morada, nacionalidade, contacto, iban, sexo, data_nascimento) values " +
                " ('Pinto da Costa','10099', 'Rua do Porto', NULL, '0000000000000000000000000', 'M', '1950-06-22')";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                CloseConnection();

            }
        }

        public void Insert()
        {
            string query = "Insert into formando (nome, id_formando, morada, nacionalidade, contacto, iban, sexo, data_nascimento) values " +
                " ('Pinto da Costa','10099', 'Rua do Porto', NULL, '0000000000000000000000000', 'M', '1950-06-22')";

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
            }
            finally
            {
                CloseConnection();
            }

        }

        public bool Insert(string ID, string nome, string morada, string nacionalidade, string contacto, string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            string query = "insert into formando (id_formando, nome, morada, nacionalidade, contacto, iban, sexo, data_nascimento, id_nacionalidade) values ('" +
               ID + "', '" + nome + "', '" + morada + "', '"+ nacionalidade +"', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "' + '" + id_nacionalidade + "');";

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

        public bool Update(string ID, string nome, string morada, string nacionalidade, string contacto, string iban, char sexo, string data_nascimento)
        {
            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento, nacionalidade) values ('" +
               ID + "', '" + nome + "', '" + morada + "', '"+ nacionalidade +"'', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "');";

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

        public bool Delete()
        {
            string query = "delete from formando where id_formando = '34738'";

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

        public bool Delete(string id)
        {
            string query = "delete from formando where id_formando = '" + id + "'";

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

        public bool Update(string id, string nome)
        {
            string query = "update formando set nome = '" + nome + "' where id_formando = '" + id + "'";

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

        public bool PesquisaFormando(
            string ID_pesquisa, 
            ref string nome, 
            ref string morada,
            ref string nacionalidade,
            ref string contacto,
            ref string iban, 
            ref char sexo, 
            ref string data_nascimento){

            bool flag = false;

            string query = "select nome, morada, nacionalidade, contacto, iban, sexo, data_nascimento from formando " +
                 "where id_formando = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nome = dataReader[0].ToString();
                        morada = dataReader["morada"].ToString();
                        nacionalidade = dataReader["nacionalidade"].ToString();
                        contacto = dataReader[2].ToString();
                        iban = dataReader[3].ToString();
                        sexo = dataReader["sexo"].ToString()[0];
                        data_nascimento = dataReader[5].ToString();
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

        public int DevolveUltimoID()
        {
            int ultimoID = 0;

            string query = "select max(id_formando) from formando";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //ultimoID = int.Parse(cmd.ExecuteScalar().ToString());
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //catch 
            //{
            //    //MessageBox.Show("ERRO!");
            //}
            finally
            {
                CloseConnection();
            }

            return ultimoID;
        }

        public void PreencherDataGriedViewFormandos(ref DataGridView dgv, char genero, string nome, string id_nacionalidade)
        {
            string query = "select id_formando, nome, iban, id_nacionalidade, nacionalidade sexo from formando ";

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
        public bool UpdateNacionalidade(string nova_nacionalidade)
        {
            bool flag = true;
            string query = "UPDATE Nacionalidade SET id_nacionalidade = " + nova_nacionalidade;


            try
            {
                if (this.OpenConnection())
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
        public bool UpdateNacionalidade(string id_nacionalidade, string ALF2, string nacionalidade)
        {
            string query = "update nacionalidade set alf2 = '" + ALF2 + "', nacionalidade = '" + nacionalidade + "'" + " where id_nacionalidade = '" + id_nacionalidade + "'";

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

            string query = "SELECT alf2, nacionalidade from nacionalidade where id_nacionalidade = '" + id_nacionalidade + "'";

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

        public bool InsertArea(int id_area, string area)
        {
            // Define a consulta SQL para inserir um novo registro na tabela "formando"
            string query = "Insert into area (id_area, area) values (" + id_area + ",'" + area + "')";
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

    }

    
}
