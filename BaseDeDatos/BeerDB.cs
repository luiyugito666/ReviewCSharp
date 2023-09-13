using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public  class BeerDB:DB
    {
        public BeerDB(string server, string db, string user, string password):base(server,db,user,password)
        {

         }



        public List<Beer> GetAll() {
            //primero conectamos
            Connect();
                //instancionamos una lista de Beer
            List<Beer> beers = new List<Beer>();
            //se enviara a traves de un SQL comand con la siguiente cadena
            string query = "SELECT Id,Name, BrandId FROM BEER";
            //el command para que se encargue de mandar comandos, el cual recibe en su constructor el quety y la connecion
            SqlCommand command= new SqlCommand(query,_connection);
            //ahora se debe realizar la ejecucion del comando
            SqlDataReader reader = command.ExecuteReader();
            //reader tiene lainformacion, pero se debe   llenar con la lista de cervezas, haciendo de la siguiente forma
            //Read(), se ejecuta siempre en caundo exista una fila 
            while (reader.Read())
            {
                //el reader regresa los elemento segun la posicion y se maneja como arreglos

                int     id       =   reader.GetInt32(0);
                string  name     =   reader.GetString(1);
                int     brandId  =   reader.GetInt32(2);
                //ahora agregamos los elementos en la lista
                beers.Add(new Beer(id, name, brandId));

            
            }

            Close();
            return beers;
        }


        public void Add(Beer beer) {

            Connect();
            string query = "INSERT INTO Beer (Name, BrandId) VALUES (@name,@brandId)";
            SqlCommand command = new SqlCommand(query,_connection);
            command.Parameters.AddWithValue("@name",beer.Name);
            command.Parameters.AddWithValue("@brandId",beer.BrandId);
            command.ExecuteNonQuery();
            
            Close();
            
        }

        public Beer Get(int id) {
            Connect();

            Beer beer = null;
            string query = "SELECT Id, Name, BrandId FROM BEER WHERE id=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader= command.ExecuteReader();

            while (reader.Read())
            {
                string name=reader.GetString(1);
                int brandId=reader.GetInt32(2);
                beer = new Beer(id, name, brandId);

            }

            Close();
            return beer;
        
        }

        public  void Edit(Beer beer) {
            Connect();

            string query = "UPDATE BEER SET name=@name, brandId=@brandId WHERE id=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.ExecuteNonQuery();

            Close();
          
        
        }

        public void Delete(int id) {
            Connect();
            string query = "DELETE FROM BEER WHERE ID=@id";
            SqlCommand command=  new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Close();

        
        }



    }
}
