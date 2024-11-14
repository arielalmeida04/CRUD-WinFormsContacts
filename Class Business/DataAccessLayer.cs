using Proyecto1Repositorio.Class_Business;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Repositorio
{
    public class DataAccessLayer
    {
        private SqlConnection _connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-45H79SP\\SQLEXPRESS");
        
        public void InsertContact(Contacts contacts)
        {
            
            try
            {
                //Abrimos la conexion 
                _connection.Open();
                string query = @"
                                 INSERT INTO Contacts( FirstName, LastName, Phone, Address)
                                 VALUES(@FirstName,@LastName,@Phone,@Adress)
                ";
                //Version larga de declarar la conexion entre la base de datos y el programa con los atributos del objeto
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@FirstName";
                parameter.Value = contacts.FirstName;
                parameter.DbType = System.Data.DbType.String;

                //Version corta de hacer el llamado de atributos
                SqlParameter lastname = new SqlParameter("@LastName", contacts.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contacts.Phone);
                SqlParameter adress = new SqlParameter("@Adress", contacts.Address);

                
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add(parameter);
                command.Parameters.Add(lastname);
                command.Parameters.Add(phone);
                command.Parameters.Add(adress);

                //Devuelve la cantidad de filas afectadas en este caso devuelve 1 nomas
                command.ExecuteNonQuery();

            }
            catch (Exception )
            {

                throw;
            }
            finally 
            { 
                //Cerramos la conexion 
                _connection.Close();
            }
        }

        
        /// Este metodo nos retorna todos los contactos que utilizamos para mostrar en el Grid
        
        public List<Contacts> GetContacts(string searchtext = null)
        {
            
            List<Contacts> contactsList = new List<Contacts>();
            try
            {
                _connection.Open();
                string query = @"
                                 SELECT Id, FirstName, LastName, Phone, Address
                                 FROM Contacts
                ";
                
                SqlCommand commaand = new SqlCommand();
               
                if (!string.IsNullOrEmpty(searchtext))
                {
                    query += @"WHERE FirstName LIKE @Search  OR LastName LIKE @Search OR Phone LIKE @Search OR Address LIKE @Search";
                    commaand.Parameters.Add(new SqlParameter("@Search",$"%{searchtext}%"));
                
                }
                commaand.CommandText = query;
                commaand.Connection = _connection;

                //commaand.ExecuteReader() es el que contiene toda las filas q cumplen con la que hayamos escrito
                SqlDataReader reader = commaand.ExecuteReader();

                //El metodo Read() de SqlDataReader solo puede leer de forma ascendente y no vuelve hacia la fila anterior
                while (reader.Read())
                {
                    contactsList.Add(new Contacts
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = (reader["FirstName"].ToString()),
                        LastName = (reader["LastName"].ToString()),
                        Phone = (reader["Phone"].ToString()),
                        Address = reader["address"].ToString()
                    });
                }
           
            }
            catch (Exception)
            {

                throw;
            }
            finally { _connection.Close(); }
            return contactsList;
        }

        public void UpdateContact(Contacts contact)
        {
            try
            {
                _connection.Open();
                string query = @"
                                            UPDATE Contacts 
                                            SET FirstName = @FirstName,
                                             LastName=@LastName,
                                             Phone=@Phone,
                                             Address=@Adress
                                             WHERE id = @id";


                SqlParameter id = new SqlParameter("@Id", contact.Id);
                SqlParameter firstname = new SqlParameter("@FirstName", contact.FirstName);
                SqlParameter lastname = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter adress = new SqlParameter("@Adress", contact.Address);

                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add(id);
                command.Parameters.Add(firstname);
                command.Parameters.Add(lastname);
                command.Parameters.Add(phone);
                command.Parameters.Add(adress);

                command.ExecuteNonQuery();
            }




            catch (Exception)
            {

                throw;
            }
            finally { _connection.Close();}
        }

        public void DeleteContact(int id)
        {
            try
            {
                _connection.Open();
                string query = @"DELETE FROM Contacts WHERE Id = @Id";
                
                SqlCommand command =new SqlCommand(query, _connection);
                command.Parameters.Add(new SqlParameter("@Id",id));
               
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        
            finally { _connection.Close(); }
        }

    }

}
