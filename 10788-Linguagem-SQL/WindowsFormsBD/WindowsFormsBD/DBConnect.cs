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
        {
            server = "192.168.1.64"; // "192.168.1.157"; //localhost "192.168.1.86" Máquina local: 192.168.1.74
            database = "gestaoformandos"; //
            username = "Gabriela"; //"root"
            password = "Passw0rd"; //""
            port = "3306";

            string connectionString = "Server = " + server + ";Port = " + port + ";Database = " +
                database + "; Uid = " + username + "; Pwd = " + password + ";";

            connection = new MySqlConnection(connectionString);
        }

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

        public string StatusConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection.State.ToString();
        }

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
            string query = "Insert into formando (nome, id_formando, morada, contacto, iban, sexo, data_nascimento) values " +
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
            string query = "Insert into formando (nome, id_formando, morada, contacto, iban, sexo, data_nascimento) values " +
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

        public bool Insert(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento)
        {
            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values ('" +
               ID + "', '" + nome + "', '" + morada + "', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "');";

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

        public bool Update(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento)
        {
            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values ('" +
               ID + "', '" + nome + "', '" + morada + "', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "');";

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
            ref string contacto,
            ref string iban, 
            ref char sexo, 
            ref string data_nascimento){

            bool flag = false;

            string query = "select nome, morada, contacto, iban, sexo, data_nascimento from formando " +
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

        public bool InsertNacionalidade(string ALF2, string nacionalidade)
        {
            string query = "insert into Nacionalidade (id_nacionalidade, alf2, nacionalidade) values (0, '" + ALF2 + "', '" + nacionalidade + "');";

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

        public bool UpdateNacionalidade(string ALF2, string Nacionalidade)
        {
            string query = "update Nacionalidade set alf2 = '" + ALF2 + "', nacionalidade = '" + Nacionalidade;

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

        public bool PesquisaNacionalidade(ref string ALF2, ref string Nacionalidade)
        {
            bool flag = false;

            string query = "select alf2, nacionalidade from Nacionalidade ";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ALF2 = dataReader["alf2"].ToString();
                        Nacionalidade = dataReader["nacionalidade"].ToString();
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
    }

}
