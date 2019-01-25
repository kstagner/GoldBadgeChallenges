using System;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class ClaimRepository_Tests
    {
        [TestMethod]
        public void ClaimRepository_AddAllClaimsToList_ShouldBeCorrectCount()
        {
            //Arrange
            ClaimRepository _claimsRepo = new ClaimRepository();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            _claimsRepo.AddNewClaim(claim);
            _claimsRepo.AddNewClaim(claimTwo);
            _claimsRepo.AddNewClaim(claimThree);

            //Act
            int actual = _claimsRepo.GetClaimQueue().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_AddNewClaimToList_ShouldBeCorrect()
        {
            //Arrange
            ClaimRepository _claimsRepo = new ClaimRepository();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            _claimsRepo.AddNewClaim(claim);
            _claimsRepo.AddNewClaim(claimTwo);
            _claimsRepo.AddNewClaim(claimThree);

            //Act
            int actual = _claimsRepo.GetClaimQueue().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_RemoveClaim_ShouldBeCorrectCount()
        {
            ClaimRepository _claimsRepo = new ClaimRepository();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            _claimsRepo.AddNewClaim(claim);
            _claimsRepo.AddNewClaim(claimTwo);
            _claimsRepo.AddNewClaim(claimThree);

            _claimsRepo.RemoveClaim();

            //Act
            int actual = _claimsRepo.GetClaimQueue().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);

        }

       

        

      
        
    }

}
