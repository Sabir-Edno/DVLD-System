using ClsConnectionStringLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDetainedLicenseDataAccessLayer
{
    public class ClsDetaineLicenseData
    {
        public static bool GetDetainByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByDetainDate(ref int DetainID, ref int LicenseID, DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE DetainDate = @DetainDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByFineFees(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE FineFees = @FineFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByCreatedByUserID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE CreatedByUserID = @CreatedByUserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByIsReleased(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE IsReleased = @IsReleased";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByReleaseDate(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE ReleaseDate = @ReleaseDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByReleasedByUserID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE ReleasedByUserID = @ReleasedByUserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleaseApplicationID"] != DBNull.Value)
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                else
                                    ReleaseApplicationID = -1;

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
        public static bool GetDetainByReleaseApplicationID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE ReleaseApplicationID = @ReleaseApplicationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != DBNull.Value)
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                else
                                    ReleaseDate = DateTime.MinValue;


                                if (reader["ReleasedByUserID"] != DBNull.Value)
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                else
                                    ReleasedByUserID = -1;

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
        public static int AddNewDetain(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;
            string query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                            VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);

                        if (ReleaseDate != DateTime.MinValue)
                            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        else
                            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

                        if (ReleasedByUserID != -1)
                            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        else
                            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

                        if (ReleaseApplicationID != -1)
                            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                        else
                            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DetainID = insertedID;
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

            return DetainID;
        }
        public static bool UpdateDetain(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE DetainedLicenses  
                                        SET 
                                        LicenseID = @LicenseID, 
                            DetainDate = @DetainDate, 
                            FineFees = @FineFees, 
                            CreatedByUserID = @CreatedByUserID, 
                            IsReleased = @IsReleased, 
                            ReleaseDate = @ReleaseDate, 
                            ReleasedByUserID = @ReleasedByUserID, 
                            ReleaseApplicationID = @ReleaseApplicationID
                            WHERE DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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
        public static bool DeleteDetain(int DetainID)
        {
            int rowsAffected = 0;
            string query = @"Delete DetainedLicenses 
                                where DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);
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
        public static bool IsDetainExist(int DetainID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);
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
        public static bool IsDetainExistByDetainID(int DetainID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainID = @DetainID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);
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
        public static bool IsDetainExistByLicenseID(int LicenseID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
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
        public static bool IsDetainExistByDetainDate(DateTime DetainDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainDate = @DetainDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
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
        public static bool IsDetainExistByFineFees(decimal FineFees)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE FineFees = @FineFees";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineFees", FineFees);
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
        public static bool IsDetainExistByCreatedByUserID(int CreatedByUserID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE CreatedByUserID = @CreatedByUserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
        public static bool IsDetainExistByIsReleased(bool IsReleased)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE IsReleased = @IsReleased";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
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
        public static bool IsDetainExistByReleaseDate(DateTime ReleaseDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE ReleaseDate = @ReleaseDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
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
        public static bool IsDetainExistByReleasedByUserID(int ReleasedByUserID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE ReleasedByUserID = @ReleasedByUserID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
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
        public static bool IsDetainExistByReleaseApplicationID(int ReleaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM DetainedLicenses WHERE ReleaseApplicationID = @ReleaseApplicationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM DetainedLicenses";
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
