﻿using IntermediateToetsTwee.Advertisements;
using System.Security.Cryptography;

namespace IntermediateToetsTwee
{
    public class Company : ICompany
    {
/*        public Company(string companyName, List<IUser> users, List<IAdvertisement> advertisements)
        {
            CompanyName = companyName;
            Users = users;
            Advertisements = advertisements;
        }*/
        public Company(string companyName)
        {
            CompanyName = companyName;
   
        }

        public double CalculateCompanyTax(double value, Company company)
        {
            if (company == null)
            {
                throw new Exception("Company is null");
            }

            return value + (value / 100 * company.GetVAT());
        }
        public override string ToString() => $"[{CompanyName}] - [{ContactPerson.UserName}] - [{Location.StreetName} {Location.HouseNumber}]";

        public int GetVAT() => VAT;
        public string CompanyName { get ; set; }
        public List<IUser>? Users { get; set; }
        public Location Location { get; set; }
        public List<IAdvertisement>? Advertisements { get; set; }
        public IUser ContactPerson { get; set; }
        protected int VAT { get; set; }
    }

    public class NlCompany : Company
    {
        
        public NlCompany(string companyName)
            :base(companyName)
        {
            VAT = 21;
        }
    }

    public class BeCompany : Company
    {
        public BeCompany(string companyName)
            : base(companyName)
        {
            VAT = 19;
        }
    }
}