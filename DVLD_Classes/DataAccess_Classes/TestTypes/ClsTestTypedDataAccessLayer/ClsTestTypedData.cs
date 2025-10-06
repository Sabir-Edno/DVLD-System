using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTestTypeDataAccessLayer
{
    public class ClsTestTypeData
    {
        public static bool GetTestTypeByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);
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
        public static bool GetTestTypeByTestTypeID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);
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
        public static bool GetTestTypeByTestTypeTitle(ref int TestTypeID, string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeTitle = @TestTypeTitle";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeID = (int)reader["TestTypeID"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);
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
        public static bool GetTestTypeByTestTypeDescription(ref int TestTypeID, ref string TestTypeTitle, string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeDescription = @TestTypeDescription";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeID = (int)reader["TestTypeID"];
                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);
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
        public static bool GetTestTypeByTestTypeFees(ref int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeFees = @TestTypeFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeID = (int)reader["TestTypeID"];
                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
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
        public static int AddNewTestType(string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int TestTypeID = -1;
            string query = @"INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                            VALUES (@TestTypeTitle, @TestTypeDescription, @TestTypeFees)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestTypeID = insertedID;
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

            return TestTypeID;
        }
        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowsAffected = 0;
            string query = @"UPDATE TestTypes  
                                        SET 
                                        TestTypeTitle = @TestTypeTitle, 
                            TestTypeDescription = @TestTypeDescription, 
                            TestTypeFees = @TestTypeFees
                            WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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
        public static bool DeleteTestType(int TestTypeID)
        {
            int rowsAffected = 0;
            string query = @"Delete TestTypes 
                                where TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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
        public static bool IsTestTypeExist(int TestTypeID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM TestTypes WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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
        public static bool IsTestTypeExistByTestTypeID(int TestTypeID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM TestTypes WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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
        public static bool IsTestTypeExistByTestTypeTitle(string TestTypeTitle)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM TestTypes WHERE TestTypeTitle = @TestTypeTitle";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
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
        public static bool IsTestTypeExistByTestTypeDescription(string TestTypeDescription)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM TestTypes WHERE TestTypeDescription = @TestTypeDescription";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
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
        public static bool IsTestTypeExistByTestTypeFees(decimal TestTypeFees)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM TestTypes WHERE TestTypeFees = @TestTypeFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TestTypes";
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
