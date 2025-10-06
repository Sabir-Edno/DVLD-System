using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClsConnectionStringLayer;
using System.Data;

namespace ClsPeopleDataAccessLayer
{
    public class ClsPersonData
    {
        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByPersonID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByNationalNo(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByFirstName(ref int PersonID, ref string NationalNo, string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE FirstName = @FirstName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonBySecondName(ref int PersonID, ref string NationalNo, ref string FirstName, string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE SecondName = @SecondName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByThirdName(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE ThirdName = @ThirdName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByLastName(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE LastName = @LastName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", LastName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByDateOfBirth(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE DateOfBirth = @DateOfBirth";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByGendor(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE Gendor = @Gendor";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByAddress(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE Address = @Address";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Address", Address);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByPhone(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE Phone = @Phone";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByEmail(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE Email = @Email";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByNationalityCountryID(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE NationalityCountryID = @NationalityCountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";


                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetPersonByImagePath(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE ImagePath = @ImagePath";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                NationalityCountryID = (int)reader["NationalityCountryID"];
                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                            VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (ThirdName != "")
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        else
                            command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (Email != "")
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return PersonID;
        }
        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;
            string query = @"UPDATE People  
                                        SET 
                                        NationalNo = @NationalNo, 
                            FirstName = @FirstName, 
                            SecondName = @SecondName, 
                            ThirdName = @ThirdName, 
                            LastName = @LastName, 
                            DateOfBirth = @DateOfBirth, 
                            Gendor = @Gendor, 
                            Address = @Address, 
                            Phone = @Phone, 
                            Email = @Email, 
                            NationalityCountryID = @NationalityCountryID, 
                            ImagePath = @ImagePath
                            WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {

            }

            return (rowsAffected > 0);
        }
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            string query = @"Delete People 
                                where PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
            return (rowsAffected > 0);
        }
        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByPersonID(int PersonID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByFirstName(string FirstName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE FirstName = @FirstName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistBySecondName(string SecondName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE SecondName = @SecondName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByThirdName(string ThirdName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE ThirdName = @ThirdName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByLastName(string LastName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE LastName = @LastName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", LastName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByDateOfBirth(DateTime DateOfBirth)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE DateOfBirth = @DateOfBirth";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByGendor(byte Gendor)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE Gendor = @Gendor";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByAddress(string Address)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE Address = @Address";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Address", Address);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByPhone(string Phone)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE Phone = @Phone";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByEmail(string Email)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE Email = @Email";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByNationalityCountryID(int NationalityCountryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE NationalityCountryID = @NationalityCountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsPersonExistByImagePath(string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM People WHERE ImagePath = @ImagePath";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM People";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return dt;
        }
    }
}
