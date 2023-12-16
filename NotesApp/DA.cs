using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AdminTools.Properties;
using Dapper;

namespace AdminTools
{
    public class DA
    {

        public BO.User AuthorizedUser(string userid)
        {
            BO.User user = null;
            try
            {
                using (var con = new SqlConnection(Settings.Default.MYDB))
                {
                    user = con.Query<BO.User>(Queries.GET_USER, new
                    {
                        userid = userid
                    }).FirstOrDefault();
                }
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertUser(BO.User user)
        {
            try
            {
                using (var con = new SqlConnection(Settings.Default.MYDB))
                {
                    con.Execute(Queries.INSERT_USER, new BO.User
                    {
                        UserID = user.UserID,
                        UserType = "USER",
                        CreatedOn = DateTime.Now,
                        CreatedBy = "SYSTEM"
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BO.User> getAllUsers()
        {
            List<BO.User> users = null;
            try
            {
                using (var con = new SqlConnection(Settings.Default.MYDB))
                {
                    users = con.Query<BO.User>(Queries.GET_ALL_USER).ToList();
                }
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool UpdateUser(BO.User user)
        {
            try
            {
                using (var con = new SqlConnection(Settings.Default.MYDB))
                {
                    con.Execute(Queries.UPDATE_USER, new BO.User
                    {
                        UserID = user.UserID,
                        UserType = user.UserType,
                        Active = user.Active,
                        UpdatedOn = DateTime.Now,
                        UpdatedBy = Session.UserID
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UploadImage(string userid, byte[] imagedata)
        {
            try
            {
                using (var con = new SqlConnection(Settings.Default.MYDB))
                {
                    con.Execute(Queries.UPLOAD_IMAGE, new
                    {
                        UserID = userid,
                        ImageData = imagedata
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        #region HCLAB QUERIES
        public BO.User Auth(string userid, string password)
        {
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", "WES"));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;
            BO.User user = null;

            try
            {
                cmd.CommandText = @"
                SELECT 
                user_id,
                password,
                user_name 
                FROM
                user_account
                WHERE suspend = 'N' 
                AND user_id = :p0 
                AND password = :p1
                ";


                cmd.Parameters.Add("", userid);

                cmd.Parameters.Add("", password);

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new BO.User
                        {
                            UserID = reader["user_id"] + "",
                            Username = reader["user_name"] + "",
                        };
                    }
                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return user;
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public DataTable ConvertListToDataTable(List<BO.Package> packages)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("TEST CODE", typeof(string));
            dataTable.Columns.Add("TEST DESC", typeof(string));
            dataTable.Columns.Add("PRICE 1", typeof(string));
            dataTable.Columns.Add("PRICE 2", typeof(string));
            dataTable.Columns.Add("PRICE 3", typeof(string));
            dataTable.Columns.Add("UPDATED ON", typeof(string));

            foreach (var package in packages)
            {
                dataTable.Rows.Add(package.code, package.desc, package.price1, package.price2, package.price3, package.updatedOn);
            }

            return dataTable;
        }

        public List<BO.Package> GenerateReport(string from, string to, string branch, string type)
        {
            List<BO.Package> packages = new List<BO.Package>();
            string _connectionString = string.Format("data source = {0}; user id = hclab; password=hclab", branch);
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                if (type == "P")
                {
                    cmd.CommandText = @"
                    SELECT
                        imh_code,
                        imh_desc,
                        imh_curr_p1,
                        imh_curr_p2,
                        imh_curr_p3,
                        imh_update_on
                    FROM 
                        item_masterh
                    WHERE 
                        imh_rec_flag = 'N' AND 
                        imh_type = 'P' AND 
                        imh_update_on BETWEEN TO_DATE(:p0, 'MM/DD/YYYY') AND TO_DATE(:p1, 'MM/DD/YYYY')
                    ORDER BY imh_update_on
                ";
                }
                else
                {
                    cmd.CommandText = @"
                    SELECT
                        imh_code,
                        imh_desc,
                        imh_curr_p1,
                        imh_curr_p2,
                        imh_curr_p3,
                        imh_update_on
                    FROM 
                        item_masterh
                    WHERE 
                        imh_rec_flag = 'N' AND 
                        imh_type = 'S' AND 
                        imh_update_on BETWEEN TO_DATE(:p0, 'MM/DD/YYYY') AND TO_DATE(:p1, 'MM/DD/YYYY')
                    ORDER BY imh_update_on
                ";
                }

                cmd.Parameters.Add("", from);

                cmd.Parameters.Add("", to);


                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        packages.Add(new BO.Package
                        {
                            code = reader["imh_code"] + "",
                            desc = reader["imh_desc"] + "",
                            price1 = reader["imh_curr_p1"] + "",
                            price2 = reader["imh_curr_p2"] + "",
                            price3 = reader["imh_curr_p3"] + "",
                            updatedOn = reader["imh_update_on"] + "",
                        });
                    }

                }
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return packages;

            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public List<BO.Package> GenerateReportStatus(string branch, string type)
        {
            List<BO.Package> packages = new List<BO.Package>();
            string _connectionString = string.Format("data source = {0}; user id = hclab; password=hclab", branch);
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                if (type == "P")
                {
                    cmd.CommandText = @"
                    SELECT
                        imh_code,
                        imh_desc,
                        imh_rec_flag
                    FROM 
                        item_masterh
                    WHERE 
                        imh_type = 'P'
                    ORDER BY imh_update_on
                ";
                }
                else
                {
                    cmd.CommandText = @"
                    SELECT
                        imh_code,
                        imh_desc,
                        imh_rec_flag
                    FROM 
                        item_masterh
                    WHERE 
                        imh_type = 'S'
                    ORDER BY imh_update_on
                ";
                }

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        packages.Add(new BO.Package
                        {
                            code = reader["imh_code"] + "",
                            desc = reader["imh_desc"] + "",
                            status = reader["imh_rec_flag"] + "" == "N" ? "ACTIVE" : "INACTIVE",
                        });
                    }
                }
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return packages;

            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }


        public BO.Clinician GetClinician(string code, string branch)
        {
            BO.Clinician clinician = null;
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        resource_code as code, 
                        resource_name as name, 
                        contact_telephone as telNo, 
                        email as faxNo, 
                        hphone_no as mobileNo, 
                        pager_no as pagerNo, 
                        contact_address1 as address1, 
                        contact_address2 as address2, 
                        contact_address3 as address3, 
                        contact_address4 as address4, 
                        update_by as updatedBy, 
                        update_on as updatedOn  
                    FROM hfresource 
                    WHERE 
                        resource_code = :code
                    ";

                cmd.Parameters.Add(":code", code);

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clinician = new BO.Clinician
                        {
                            code = reader["code"] + "",
                            name = reader["name"] + "",
                            telNo = reader["telNo"] + "",
                            faxNo = reader["faxNo"] + "",
                            mobileNo = reader["mobileNo"] + "",
                            pagerNo = reader["pagerNo"] + "",
                            address1 = reader["address1"] + "",
                            address2 = reader["address2"] + "",
                            address3 = reader["address3"] + "",
                            address4 = reader["address4"] + "",
                            updatedBy = reader["updatedBy"] + "",
                            updatedOn = string.IsNullOrEmpty(reader["updatedBy"] + "") ? null as DateTime? : reader.GetDateTime(reader.GetOrdinal("updatedOn"))
                        };
                    }

                }
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return clinician;

            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public List<BO.DispatchMode> GetDispatchModes()
        {
            List<BO.DispatchMode> dispatchModes = new List<BO.DispatchMode>();
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", "WES"));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        pp_code, 
                        pp_desc 
                    FROM pmi_para 
                    WHERE 
                        pp_type = '32'
                    ";

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dispatchModes.Add(new BO.DispatchMode
                        {
                            code = reader["pp_code"] + "",
                            desc = reader["pp_desc"] + ""
                        });
                    }

                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return dispatchModes;
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public List<BO.CustMaster> GetCustMasters()
        {
            List<BO.CustMaster> custMasters = new List<BO.CustMaster>();
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", "WES"));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        dbcode, 
                        dbname, 
                        dbterm, 
                        folder_id 
                    FROM cust_master 
                    WHERE REGEXP_LIKE(dbcode, '^[0-9]+$')
                ";

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        custMasters.Add(new BO.CustMaster
                        {
                            code = reader["dbcode"] + "",
                            name = reader["dbname"] + "",
                            term = reader["dbterm"] + "",
                            folder_id = reader["folder_id"] + ""
                        });
                    }
                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return custMasters;
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public List<BO.Term> GetTerms()
        {
            List<BO.Term> terms = new List<BO.Term>();
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", "WES"));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        terms_code, 
                        terms_desc 
                    FROM terms 
                ";

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        terms.Add(new BO.Term
                        {
                            code = reader["terms_code"] + "",
                            desc = reader["terms_desc"] + ""
                        });
                    }
                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return terms;
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public List<BO.DBGroup> GetDBGroup()
        {
            List<BO.DBGroup> dbGroups = new List<BO.DBGroup>();
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", "WES"));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        dbgroup_code, 
                        dbgroup_name 
                    FROM dbgroup 
                ";

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbGroups.Add(new BO.DBGroup
                        {
                            code = reader["dbgroup_code"] + "",
                            name = reader["dbgroup_name"] + ""
                        });
                    }
                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return dbGroups;
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public BO.Source GetSource(string code, string branch)
        {
            BO.Source source = null;
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        hfclinic.clinic_code as code, 
                        hfclinic.clinic_desc as c_desc, 
                        hfclinic_dtl.cd_telno as telNo, 
                        hfclinic_dtl.cd_faxno as faxNo, 
                        hfclinic_dtl.cd_email as email, 
                        hfclinic_dtl.cd_contact as contact, 
                        hfclinic_dtl.cd_dbcode as billingCode,
                        hfclinic_dtl.cd_rep_dpmode as dispatchMode,
                        hfclinic_dtl.cd_addr1 as address1, 
                        hfclinic_dtl.cd_addr2 as address2, 
                        hfclinic_dtl.cd_addr3 as address3, 
                        hfclinic_dtl.cd_addr4 as address4, 
                        hfclinic.update_by as updatedBy, 
                        hfclinic.update_on as updatedOn  
                    FROM hfclinic 
                    INNER JOIN hfclinic_dtl on hfclinic.clinic_code = hfclinic_dtl.cd_code 
                    WHERE 
                        clinic_code = :code
                    ";

                cmd.Parameters.Add(":code", code);

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        source = new BO.Source
                        {
                            code = reader["code"] + "",
                            desc = reader["c_desc"] + "",
                            telNo = reader["telNo"] + "",
                            faxNo = reader["faxNo"] + "",
                            email = reader["email"] + "",
                            contact = reader["contact"] + "",
                            billingCode = reader["billingCode"] + "",
                            dispatchMode = reader["dispatchMode"] + "",
                            address1 = reader["address1"] + "",
                            address2 = reader["address2"] + "",
                            address3 = reader["address3"] + "",
                            address4 = reader["address4"] + "",
                            updatedBy = reader["updatedBy"] + "",
                            updatedOn = string.IsNullOrEmpty(reader["updatedOn"] + "") ? null as DateTime? : reader.GetDateTime(reader.GetOrdinal("updatedOn"))
                        };
                    }
                }

                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return source;

            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public BO.Debtor GetDebtor(string code, string branch)
        {
            BO.Debtor debtor = null;
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            OracleDataReader reader = null;

            try
            {
                cmd.CommandText = @"
                    SELECT 
                        cust_master.dbcode as code, 
                        cust_master.dbname as name, 
                        cust_master.dbcontact as contact, 
                        cust_master.dbfax as faxNo, 
                        cust_master.dbtel1 as phoneNo,
                        cust_master.dbaddr1 as address1, 
                        cust_master.dbaddr2 as address2, 
                        cust_master.dbaddr3 as address3, 
                        cust_master.dbaddr4 as address4, 
                        cust_master.dbgroup as cusgroup, 
                        cust_master.dbpricegrp as pricegroup, 
                        cust_master.dbterm as term,
                        cust_master.dblimit as credlimit,
                        cust_master.folder_id as specialprice, 
                        cust_master.active_code as blacklist, 
                        cust_master.registration_date as created,
                        cust_master.db_update_by as updatedBy, 
                        cust_master.db_update_on as updatedOn  
                    FROM cust_master
                    WHERE 
                        cust_master.dbcode = :code
                    ";

                cmd.Parameters.Add(":code", code);

                con.Open();
                cmd.Connection = con;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        debtor = new BO.Debtor
                        {
                            code = reader["code"] + "",
                            name = reader["name"] + "",
                            phoneNo = reader["phoneNo"] + "",
                            faxNo = reader["faxNo"] + "",
                            contact = reader["contact"] + "",
                            address1 = reader["address1"] + "",
                            address2 = reader["address2"] + "",
                            address3 = reader["address3"] + "",
                            address4 = reader["address4"] + "",
                            cusgroup = reader["cusgroup"] + "",
                            pricegroup = reader["pricegroup"] + "",
                            term = reader["term"] + "",
                            credlimit = reader["credlimit"] + "",
                            specialprice = reader["specialprice"] + "",
                            blacklist = (reader["blacklist"] + "") == "X",
                            created = string.IsNullOrEmpty(reader["created"] + "") ? null as DateTime? : reader.GetDateTime(reader.GetOrdinal("created")),
                            updatedBy = reader["updatedBy"] + "",
                            updatedOn = string.IsNullOrEmpty(reader["updatedOn"] + "") ? null as DateTime? : reader.GetDateTime(reader.GetOrdinal("updatedOn"))
                        };
                    }
                }
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

                return debtor;

            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                throw ex;
            }
        }

        public BO.CBBranches CheckClinicianBranches(string code)
        {
            BO.CBBranches branches = new BO.CBBranches();

            try
            {
                if (GetClinician(code, "WES") != null) branches.wes = true;
                if (GetClinician(code, "DIAMOND") != null) branches.dia = true;
                if (GetClinician(code, "LILOAN") != null) branches.lil = true;
                if (GetClinician(code, "TABUNOK") != null) branches.tab = true;
                if (GetClinician(code, "MACTAN") != null) branches.llc = true;
                if (GetClinician(code, "NAGA") != null) branches.naga = true;
                if (GetClinician(code, "CONSO") != null) branches.con = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return branches;
        }

        public BO.CBBranches CheckSourceBranches(string code)
        {
            BO.CBBranches branches = new BO.CBBranches();

            try
            {
                if (GetSource(code, "WES") != null) branches.wes = true;
                if (GetSource(code, "DIAMOND") != null) branches.dia = true;
                if (GetSource(code, "LILOAN") != null) branches.lil = true;
                if (GetSource(code, "TABUNOK") != null) branches.tab = true;
                if (GetSource(code, "MACTAN") != null) branches.llc = true;
                if (GetSource(code, "NAGA") != null) branches.naga = true;
                if (GetSource(code, "CONSO") != null) branches.con = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return branches;
        }

        public BO.CBBranches CheckDebtorBranches(string code)
        {
            BO.CBBranches branches = new BO.CBBranches();

            try
            {
                if (GetDebtor(code, "WES") != null) branches.wes = true;
                if (GetDebtor(code, "DIAMOND") != null) branches.dia = true;
                if (GetDebtor(code, "LILOAN") != null) branches.lil = true;
                if (GetDebtor(code, "TABUNOK") != null) branches.tab = true;
                if (GetDebtor(code, "MACTAN") != null) branches.llc = true;
                if (GetDebtor(code, "NAGA") != null) branches.naga = true;
                if (GetDebtor(code, "CONSO") != null) branches.con = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return branches;
        }


        public void UpdateClinician(BO.Clinician clinician, string branch)
        {
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = @"
                    UPDATE  hfresource SET 
                        resource_name = :name, 
                        contact_telephone = :telNo, 
                        email = :faxNo, 
                        hphone_no = :mobileNo, 
                        pager_no = :pagerNo, 
                        contact_address1 = :address1, 
                        contact_address2 = :address2, 
                        contact_address3 = :address3, 
                        contact_address4 = :address4, 
                        update_by = :updatedBy, 
                        update_on = SYSDATE
                    WHERE 
                        resource_code = :code
                    ";

                cmd.Parameters.Add(new OracleParameter(":name", clinician.name));
                cmd.Parameters.Add(new OracleParameter(":telNo", clinician.telNo));
                cmd.Parameters.Add(new OracleParameter(":faxNo", clinician.faxNo));
                cmd.Parameters.Add(new OracleParameter(":mobileNo", clinician.mobileNo));
                cmd.Parameters.Add(new OracleParameter(":pagerNo", clinician.pagerNo));
                cmd.Parameters.Add(new OracleParameter(":address1", clinician.address1));
                cmd.Parameters.Add(new OracleParameter(":address2", clinician.address2));
                cmd.Parameters.Add(new OracleParameter(":address3", clinician.address3));
                cmd.Parameters.Add(new OracleParameter(":address4", clinician.address4));
                cmd.Parameters.Add(new OracleParameter(":updatedBy", clinician.updatedBy));
                cmd.Parameters.Add(new OracleParameter(":code", clinician.code));

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

            }
            catch (Exception ex)
            {
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                Console.WriteLine(ex);
                throw;
            }
        }

        public void UpdateSource(BO.Source source, string branch)
        {
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            OracleTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();

                cmd.CommandText = @"
                UPDATE hfclinic
                SET clinic_desc = :c_desc,
                    update_by = :updatedBy,
                    update_on = SYSDATE
                WHERE clinic_code = :code
                ";

                cmd.Parameters.Add(new OracleParameter(":c_desc", source.desc));
                cmd.Parameters.Add(new OracleParameter(":updatedBy", source.updatedBy));
                cmd.Parameters.Add(new OracleParameter(":code", source.code));

                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"
                UPDATE hfclinic_dtl
                SET cd_telno = :telNo,
                    cd_faxno = :faxNo,
                    cd_email = :email,
                    cd_contact = :contact,
                    cd_dbcode = :billingCode,
                    cd_rep_dpmode = :dispatchMode,
                    cd_addr1 = :address1,
                    cd_addr2 = :address2,
                    cd_addr3 = :address3,
                    cd_addr4 = :address4
                WHERE cd_code = :code
                ";

                // Clear previous parameters and add new ones for hfclinic_dtl update
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new OracleParameter(":telNo", source.telNo));
                cmd.Parameters.Add(new OracleParameter(":faxNo", source.faxNo));
                cmd.Parameters.Add(new OracleParameter(":email", source.email));
                cmd.Parameters.Add(new OracleParameter(":contact", source.contact));
                cmd.Parameters.Add(new OracleParameter(":billingCode", source.billingCode));
                cmd.Parameters.Add(new OracleParameter(":dispatchMode", source.dispatchMode));
                cmd.Parameters.Add(new OracleParameter(":address1", source.address1));
                cmd.Parameters.Add(new OracleParameter(":address2", source.address2));
                cmd.Parameters.Add(new OracleParameter(":address3", source.address3));
                cmd.Parameters.Add(new OracleParameter(":address4", source.address4));
                cmd.Parameters.Add(new OracleParameter(":code", source.code));

                cmd.ExecuteNonQuery();

                cmd.CommandText = @"
                    UPDATE cust_master
                    SET dbterm = :term
                    WHERE dbcode = :code
                ";

                cmd.Parameters.Clear();
                cmd.Parameters.Add(new OracleParameter(":term", source.term));
                cmd.Parameters.Add(new OracleParameter(":code", source.billingCode));

                cmd.ExecuteNonQuery();

                // If everything is successful, commit the transaction
                transaction.Commit();

                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                transaction?.Rollback();

                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                Console.WriteLine(ex);
                throw;
            }
        }

        public void UpdateDebtor(BO.Debtor debtor, string branch)
        {
            OracleConnection con = new OracleConnection(string.Format("data source = {0}; user id = hclab; password=hclab", branch));
            OracleCommand cmd = new OracleCommand();
            OracleTransaction transaction = null;
            try
            {
                cmd.CommandText = @"
                    UPDATE cust_master SET 
                        dbname = :name, 
                        dbcontact = :contact, 
                        dbfax = :faxNo, 
                        dbtel1 = :phoneNo, 
                        dbaddr1 = :address1, 
                        dbaddr2 = :address2, 
                        dbaddr3 = :address3, 
                        dbaddr4 = :address4, 
                        dbgroup = :cusgroup,
                        dbpricegrp = :pricegroup,
                        dbterm = :term,
                        dblimit = :credlimit,
                        folder_id = :specialprice,
                        active_code = :blacklist,
                        db_update_by = :updatedBy, 
                        db_update_on             = SYSDATE
                    WHERE 
                        dbcode = :code
                    ";

                string blcklst = debtor.blacklist ? "X" : "Y";
                cmd.Parameters.Add(new OracleParameter(":name", debtor.name));
                cmd.Parameters.Add(new OracleParameter(":contact", debtor.contact));
                cmd.Parameters.Add(new OracleParameter(":faxNo", debtor.faxNo));
                cmd.Parameters.Add(new OracleParameter(":phoneNo", debtor.phoneNo));
                cmd.Parameters.Add(new OracleParameter(":address1", debtor.address1));
                cmd.Parameters.Add(new OracleParameter(":address2", debtor.address2));
                cmd.Parameters.Add(new OracleParameter(":address3", debtor.address3));
                cmd.Parameters.Add(new OracleParameter(":address4", debtor.address4));
                cmd.Parameters.Add(new OracleParameter(":cusgroup", debtor.cusgroup));
                cmd.Parameters.Add(new OracleParameter(":pricegroup", debtor.pricegroup));
                cmd.Parameters.Add(new OracleParameter(":term", debtor.term));
                cmd.Parameters.Add(new OracleParameter(":credlimit", debtor.credlimit));
                cmd.Parameters.Add(new OracleParameter(":specialprice", debtor.specialprice));
                cmd.Parameters.Add(new OracleParameter(":blacklist", blcklst));
                cmd.Parameters.Add(new OracleParameter(":updatedBy", debtor.updatedBy));
                cmd.Parameters.Add(new OracleParameter(":code", debtor.code));

                con.Open();
                transaction = con.BeginTransaction();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();

                transaction.Commit();

                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();

            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                if (cmd != null) cmd.Dispose();
                if (con != null) con.Close();
                Console.WriteLine(ex);
                throw;
            }
        }

        #endregion
    }

    public class Queries
    {
        public static string GET_USER = @"SELECT * FROM AuthorizedUsers WHERE UserID = @userid;";

        public static string GET_ALL_USER = @"SELECT * FROM AuthorizedUsers ORDER BY Id DESC";

        public static string INSERT_USER = @"INSERT INTO AuthorizedUsers (UserID, UserType, CreatedOn, CreatedBy, Active) 
                                                VALUES (@UserId, @UserType, GETDATE(), @CreatedBy, 0);";

        public static string INSERT_USER_2 = @"INSERT INTO AuthorizedUsers (UserID, UserType, CreatedOn, CreatedBy, Active) 
                                                VALUES (@UserId, @UserType, GETDATE(), @CreatedBy, @Active);";

        public static string UPDATE_USER = @"UPDATE AuthorizedUsers SET Active = @Active, UserType = @UserType, UpdatedOn = GETDATE(), UpdatedBy = @UpdatedBy 
                                                    WHERE UserID = @UserID;";

        public static string UPLOAD_IMAGE = @"UPDATE AuthorizedUsers SET Picture = @ImageData WHERE UserID = @UserID";
    }
}
  