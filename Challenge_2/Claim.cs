using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public enum ClaimType { Car, Home, Theft }

    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim() { }

        public Claim(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfAccident, DateTime dateOfClaim)
        {

            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = DateOfAccident - DateOfClaim < TimeSpan.FromDays(30);
        }

        public Claim(int v, ClaimType claimType)
        {
            ClaimType = claimType;
        }
    }
}
