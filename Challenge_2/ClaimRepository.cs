using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace Challenge_2
   {
        public class ClaimRepository
        {
            Queue<Claim> _claims = new Queue<Claim>();

            public Queue<Claim> GetClaimsList()
            {
                return _claims;
            }
            public void AddNewClaim(Claim newClaim)
            {
                _claims.Enqueue(newClaim);
            }
            public void RemoveClaim()
            {
                _claims.Dequeue();
            }
            public Claim NextClaim()
            {
                Claim claim = _claims.Peek();
                return claim;
            }
        }
   }
