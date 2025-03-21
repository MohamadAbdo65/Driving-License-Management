﻿using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
   


    public class clsLicenseClassDTO : IValidatable
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public int ClassFees { get; set; }


        public clsLicenseClassDTO(
            int licenseClassID,
            string className,
            string classDescription,
            byte minAllowedAge,
            byte defaultValidityLength,
            int classFees)
        {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }

        public bool IsValid(out string? ErrorMessage)
        {
            if (LicenseClassID <= 0)
            {
                ErrorMessage = "License Class ID is not valid";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ClassName))
            {
                ErrorMessage = "Class Name is required";
                return false;
            }

            if (MinimumAllowedAge < 1)
            {
                ErrorMessage = "Minimum Allowed Age must be at least 1";
                return false;
            }

            if (DefaultValidityLength < 1)
            {
                ErrorMessage = "Default Validity Length must be greater than zero";
                return false;
            }

            if (ClassFees < 0)
            {
                ErrorMessage = "Class Fees cannot be negative";
                return false;
            }

            ErrorMessage = null;
            return true;
        }

    }

    public static class clsDataLicensesClass
    {
        public static List<clsLicenseClassDTO> GetAllLicensesClass()
        {
            var AllClasses = new List<clsLicenseClassDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LicenseClasses_SelectAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllClasses.Add
                            (
                                new clsLicenseClassDTO
                                (
                                    (int)reader["LicenseClassID"],
                                    (string)reader["ClassName"],
                                    (string)reader["ClassDescription"],
                                    (byte)reader["MinimumAllowedAge"],
                                    (byte)reader["DefaultValidityLength"],
                                    (int)reader["ClassFees"]
                                )
                            );
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return AllClasses;
        }

        public static bool UpdateLicenseClassInfo(clsLicenseClassDTO licenseClass)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LicenseClasses_Update_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LicenseClassID", licenseClass.LicenseClassID);
                command.Parameters.AddWithValue("@ClassName", licenseClass.ClassName);
                command.Parameters.AddWithValue("@ClassDescription", licenseClass.ClassDescription);
                command.Parameters.AddWithValue("@MinimumAllowedAge", licenseClass.MinimumAllowedAge);
                command.Parameters.AddWithValue("@DefaultValidityLength", licenseClass.DefaultValidityLength);
                command.Parameters.AddWithValue("@ClassFees", licenseClass.ClassFees);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static clsLicenseClassDTO FindByLicenseClassID(int licenseClassID)
        {
            clsLicenseClassDTO licenseClass = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LicenseClasses_Select_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            licenseClass = new clsLicenseClassDTO(
                                (int)reader["LicenseClassID"],
                                (string)reader["ClassName"],
                                (string)reader["ClassDescription"],
                                (byte)reader["MinimumAllowedAge"],
                                (byte)reader["DefaultValidityLength"],
                                (int)reader["ClassFees"]
                            )
                            {
                                LicenseClassID = licenseClassID
                            };
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return licenseClass;
        }
    }



}
