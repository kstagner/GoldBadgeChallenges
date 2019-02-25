using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenge_2
{
    public class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();
        Queue<Claim> _claims = new Queue<Claim>();
        bool running = true;

        public void Run()
        {
            SeedList();

            while (running)
            {
                Console.Clear();
                Claim();
            }
        }

        private void SeedList()
        {
            Claim claim = new Claim(1, ClaimType.Car, "Fire", 1000000000, new DateTime(2019, 02, 20), new DateTime(2018, 12, 20));
            Claim claimTwo = new Claim(2, ClaimType.Home, "Tornado", 200000, new DateTime(2018, 10, 31), new DateTime(2018, 11, 20));
            Claim claimThree = new Claim(3, ClaimType.Theft, "Socks", 5000000, new DateTime(2019, 01, 01), new DateTime(2019, 01, 21));

            _claimRepo.AddNewClaim(claim);
            _claimRepo.AddNewClaim(claimTwo);
            _claimRepo.AddNewClaim(claimThree);
        }

        private void Claim()
        {
            Console.WriteLine("Choose a menu item: \n" +
                "1. See all claims\n" +
                "2. Take care of next claim\n" +
                "3. Enter a new claim");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SeeAllClaims();
                    break;
                case 2:
                    TakeCareOfNextClaim();
                    break;
                case 3:
                    EnterNewClaim();
                    break;
                case 4:
                    running = false;
                    break;
                default:

                    break;
            }
        }

        private void SeeAllClaims()
        {
            Queue<Claim> claims = _claimRepo.GetClaimsList();

            foreach (Claim claim in claims)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}");
                Console.WriteLine($"Claim Type: {claim.ClaimType}");
                Console.WriteLine($"Description: {claim.Description}");
                Console.WriteLine($"Claim Amount: {claim.ClaimAmount}");
                Console.WriteLine($"Date of Accident: {claim.DateOfAccident}");
                Console.WriteLine($"Date of Claim: {claim.DateOfClaim}");
                Console.WriteLine($"Is Valid: {claim.IsValid}");

            }
            Console.ReadKey();
        }

        public void TakeCareOfNextClaim()
        {
            Claim claim = _claimRepo.NextClaim();
            Console.WriteLine("Here are the details for the next claim to be handled:");
            Console.WriteLine($"Claim ID: {claim.ClaimID}");
            Console.WriteLine($"Claim Type: {claim.ClaimType}");
            Console.WriteLine($"Description: {claim.Description}");
            Console.WriteLine($"Claim Amount: {claim.ClaimAmount}");
            Console.WriteLine($"Date of Accident: {claim.DateOfAccident}");
            Console.WriteLine($"Date of Claim: {claim.DateOfClaim}");
            Console.WriteLine($"Is Valid: {claim.IsValid}");

            Console.WriteLine("Would you like to remove a claim? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
                _claimRepo.RemoveClaim();

            Console.ReadLine();
        }

        private void EnterNewClaim()
        {
            Console.Clear();

            Console.WriteLine("Enter the claim id: ");
            string idAsString = Console.ReadLine();
            int id = int.Parse(idAsString);

            Console.WriteLine("Enter the claim type: \n" +
                "1.Car\n" +
                "2.Home\n" +
                "3.Theft\n");
            int input = int.Parse(Console.ReadLine());

            ClaimType type;
            switch (input)
            {
                default:
                case 1:
                    type = ClaimType.Car;
                    break;
                case 2:
                    type = ClaimType.Home;
                    break;
                case 3:
                    type = ClaimType.Theft;
                    break;

            }
            Console.WriteLine("Enter a claim description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter amount of damage here: ");
            string damageAmountAsString = Console.ReadLine();
            decimal damageamount = decimal.Parse(damageAmountAsString);

            Console.WriteLine("Enter date of accident here: ");
            string accidentDateAsString = Console.ReadLine();
            DateTime accidentdate = DateTime.Parse(accidentDateAsString);

            Console.WriteLine("Enter date of claim here: ");
            string claimDateAsString = Console.ReadLine();
            DateTime claimdate = DateTime.Parse(claimDateAsString);

            Console.WriteLine("Claim is valid.");
            string isvalid = Console.ReadLine();


            Claim claim = new Claim(id, type, description, damageamount, accidentdate, claimdate);

            _claimRepo.AddNewClaim(claim);
        }

    }
}
