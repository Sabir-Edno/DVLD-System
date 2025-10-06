using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLicenseClassDataAccessLayer
{
    public class ClsLicenseClassData
    {
        public static bool GetLicenseClassByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByLicenseClassID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByClassName(ref int LicenseClassID, string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByClassDescription(ref int LicenseClassID, ref string ClassName, string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE ClassDescription = @ClassDescription";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassName = (string)reader["ClassName"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByMinimumAllowedAge(ref int LicenseClassID, ref string ClassName, ref string ClassDescription, byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE MinimumAllowedAge = @MinimumAllowedAge";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByDefaultValidityLength(ref int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE DefaultValidityLength = @DefaultValidityLength";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
        public static bool GetLicenseClassByClassFees(ref int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE ClassFees = @ClassFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
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
        public static int AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int LicenseClassID = -1;
            string query = @"INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                            VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LicenseClassID = insertedID;
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

            return LicenseClassID;
        }
        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int rowsAffected = 0;
            string query = @"UPDATE LicenseClasses  
                                        SET 
                                        ClassName = @ClassName, 
                            ClassDescription = @ClassDescription, 
                            MinimumAllowedAge = @MinimumAllowedAge, 
                            DefaultValidityLength = @DefaultValidityLength, 
                            ClassFees = @ClassFees
                            WHERE LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);
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
        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            int rowsAffected = 0;
            string query = @"Delete LicenseClasses 
                                where LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool IsLicenseClassExist(int LicenseClassID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool IsLicenseClassExistByLicenseClassID(int LicenseClassID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool IsLicenseClassExistByClassName(string ClassName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE ClassName = @ClassName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);
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
        public static bool IsLicenseClassExistByClassDescription(string ClassDescription)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE ClassDescription = @ClassDescription";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
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
        public static bool IsLicenseClassExistByMinimumAllowedAge(byte MinimumAllowedAge)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE MinimumAllowedAge = @MinimumAllowedAge";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
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
        public static bool IsLicenseClassExistByDefaultValidityLength(byte DefaultValidityLength)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE DefaultValidityLength = @DefaultValidityLength";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
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
        public static bool IsLicenseClassExistByClassFees(decimal ClassFees)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM LicenseClasses WHERE ClassFees = @ClassFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);
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
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LicenseClasses";
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
