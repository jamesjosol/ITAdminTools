using System;

namespace AdminTools
{
    public class BO
    {
        public class User
        {
            public string UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class Package
        {
            public string code { get; set; }
            public string desc { get; set; }
            public string price1 { get; set; }
            public string price2 { get; set; }
            public string price3 { get; set; }
            public string updatedOn { get; set; }
            public string status { get; set; }
        }

        public class Clinician
        {
            public string code { get; set; }
            public string name { get; set; }
            public string telNo { get; set; }
            public string faxNo { get; set; }
            public string mobileNo { get; set; }
            public string pagerNo { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string address4 { get; set; }
            public string updatedBy { get; set; }
            public DateTime? updatedOn { get; set; }
        }

        public class Source
        {
            public string code { get; set; }
            public string desc { get; set; }
            public string telNo { get; set; }
            public string faxNo { get; set; }
            public string email { get; set; }
            public string contact { get; set; }
            public string billingCode { get; set; }
            public string term { get; set; }
            public string dispatchMode { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string address4 { get; set; }
            public string updatedBy { get; set; }
            public DateTime? updatedOn { get; set; }
        }

        public class Debtor
        {
            public string code { get; set; }
            public string name { get; set; }
            public string contact { get; set; }
            public string faxNo { get; set; }
            public string phoneNo { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string address4 { get; set; }
            public string cusgroup { get; set; }
            public string pricegroup { get; set; }
            public string term { get; set; }
            public string credlimit { get; set; }
            public string specialprice { get; set; }
            public bool blacklist { get; set; }
            public DateTime? created { get; set; }
            public string updatedBy { get; set; }
            public DateTime? updatedOn { get; set; }
        }

        public class DispatchMode
        {
            public string code { get; set; }
            public string desc { get; set; }
        }

        public class CustMaster
        {
            public string code { get; set; }
            public string name { get; set; }
            public string term { get; set; }
            public string folder_id { get; set; }
        }

        public class Term
        {
            public string code { get; set; }
            public string desc { get; set; }
        }

        public class DBGroup
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CBBranches
        {
            public bool wes { get; set; }
            public bool dia { get; set; }
            public bool llc { get; set; }
            public bool lil { get; set; }
            public bool tab { get; set; }
            public bool naga { get; set; }
            public bool con { get; set; }
        }
    }
}
