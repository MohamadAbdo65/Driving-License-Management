﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConnectionSettings;

namespace DVLD_DataAccessLayer
{
    public class clsCountryDTO
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountryDTO(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
    }

    public static class clsDataCountries
    {
        public static List<clsCountryDTO> GetAllCountries()
        {
            List<clsCountryDTO> countries = new List<clsCountryDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_SelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countries.Add(new clsCountryDTO(
                                    (int)reader["CountryID"],
                                    (string)reader["CountryName"]
                                ));
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return countries;
        }

        public static clsCountryDTO FindCountryByName(string CountryName)
        {
            clsCountryDTO country = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_Select_ByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                country = new clsCountryDTO(
                                    (int)reader["CountryID"],
                                    (string)reader["CountryName"]
                                );
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return country;
        }

        public static clsCountryDTO FindCountryById(int CountryID)
        {
            clsCountryDTO country = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_Select_ByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                country = new clsCountryDTO(
                                    (int)reader["CountryID"],
                                    (string)reader["CountryName"]
                                );
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return country;
        }
    }
}