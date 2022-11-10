extern alias MySqlConnectorAlias; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorraGirona.BussinesLayer
{
    class GestioSQL
    {
        static string connectionString = "Data Source=localhost;Initial Catalog=porragirona;User ID=root;Password=";
        static MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlConnection ConnexioBD = new MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlConnection(connectionString);
        public static string ErrorMessage;
        static public bool ConectarBD()
        {
            bool connexioEstablerta = true;
            try
            {
                ConnexioBD.Open();
            }
            catch(Exception ex)
            {
                connexioEstablerta = false;
                ErrorMessage = ex.Message;
            }
            return connexioEstablerta;
        }
        static public void DesconectarBD()
        {
            ConnexioBD.Close();
        }
        static public Boolean DBExisteixUsuari(String nom, String password)
        {
            Boolean existeix = false;
            if (ConectarBD())
                {
                    MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand sqlcommand = ConnexioBD.CreateCommand();
                    sqlcommand.CommandText = "SELECT * FROM penyistes WHERE alias=@alias AND password=@password";
                    sqlcommand.Parameters.AddWithValue("@alias", nom);
                    sqlcommand.Parameters.AddWithValue("@password", password);
                    sqlcommand.Prepare(); //Compila la consulta per també evitar SQLInjection
                    var reader = sqlcommand.ExecuteReader();
                    if (reader.Read())
                    {
                        existeix = true;
                    }
                    else
                    {
                        ErrorMessage = "Usuari o Contraseña Incorrecte";
                    }
                    reader.Close();
                    DesconectarBD();
            }
            return (existeix);
        }
        static public bool InserirUsuari(string nom,string cognoms, string nif, string numsoci, string rol,string alias ,DateTime dataalta, string password, byte[] pic_array)
        {
            bool inserciocorrecte = false;
            try
            {
                MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand sqlcommand = ConnexioBD.CreateCommand();
                sqlcommand.CommandText = "INSERT INTO PENYISTES(nom,cognoms,nif,numsoci,rol,alias,password,dataalta,imatge) " +
                    "VALUES(@nom,@cognoms,@nif,@numsoci,@rol,@alias,@password,@dataalta,@imatge)";
                sqlcommand.Parameters.AddWithValue("@nom", nom);
                sqlcommand.Parameters.AddWithValue("@cognoms", cognoms);
                sqlcommand.Parameters.AddWithValue("@nif", nif);
                sqlcommand.Parameters.AddWithValue("@numsoci", numsoci);
                sqlcommand.Parameters.AddWithValue("@alias", alias);
                sqlcommand.Parameters.AddWithValue("@rol", rol);
                sqlcommand.Parameters.AddWithValue("@dataalta", dataalta);
                sqlcommand.Parameters.AddWithValue("@password", password);
                sqlcommand.Parameters.Add("@imatge", MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlDbType.MediumBlob);
                sqlcommand.Parameters["@imatge"].Value = pic_array;
                int res=sqlcommand.ExecuteNonQuery();
                if(res!=0)inserciocorrecte = true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return inserciocorrecte;
        }
        static public DataTable LoadDataOnDataTable()
        {
            MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            string query = "SELECT nom, cognoms, nif, numsoci, rol, imatge, alias, password, dataalta FROM penyistes";
            try
            {
                MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand commandDatabase = new MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand(query, ConnexioBD);
                adapter = new MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlDataAdapter(commandDatabase);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return table;
        }
        static public bool CalculaPuntuacionsEntity()
        {
            bool procCorrect = false;
            if (ConectarBD())
            {
                MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand sqlcommandDelete = ConnexioBD.CreateCommand();
                sqlcommandDelete.CommandText = "TRUNCATE TABLE PUNTUACIONS";
                sqlcommandDelete.Prepare(); //Compila la consulta per també evitar SQLInjection
                sqlcommandDelete.ExecuteNonQuery();

                MySqlConnectorAlias::MySql.Data.MySqlClient.MySqlCommand sqlcommandQuery = ConnexioBD.CreateCommand();
                sqlcommandDelete.CommandText = "SELECT";
                DesconectarBD();
            }
            return procCorrect;
        }
    }
}
