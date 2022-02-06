using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using VideoRentalStore;
namespace VideoRentalStoreUnitTest
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void AddFilm()
        {
            // Arrange
            int expected = 1;

            CInventory inventory = new CInventory();
            CNewReleaseFilm film = new CNewReleaseFilm() {Title="Matrix",Copies=1 };

            inventory.AddFilm(film);

            // Assert
            int actual = inventory.CurrentDataset.Count;
            Assert.AreEqual(expected, actual,0, "Film is not added");
        }


        [TestMethod]
        public void RemoveFilm()
        {
            // Arrange
            int expected = 1;
            
            CInventory inventory = new CInventory();
            CNewReleaseFilm film = new CNewReleaseFilm() { Title = "Matrix", Copies = 1 };

            inventory.AddFilm(film);
            int actual = inventory.CurrentDataset.Count;
            // Assert
            Assert.AreEqual(expected, actual, 0, "Film is not added");
            expected = 0;
            inventory.RemoveFilm(film);
           
            // Assert
            actual = inventory.CurrentDataset.Count;
            Assert.AreEqual(expected, actual, 0, "Film is not removed");
        }

        [TestMethod]
        public void ChangeTypeOfFilm()
        {
            // Arrange
            string expected = "Old";

            CInventory inventory = new CInventory();
            CNewReleaseFilm film = new CNewReleaseFilm() { Title = "Matrix", Copies = 1 };

            inventory.AddFilm(film);
            CFilm newFilm = inventory.ChangeTypeOfFilm(film, FilmType.OldFilm);

            // Assert
            string actual = newFilm.FilmTypeText;
            Assert.AreEqual(expected, actual,  "Film type is not changed");
        }

        [TestMethod]
        public void SelectFilms()
        {
            // Arrange
            int expected = 2;

            CInventory inventory = new CInventory();
            CNewReleaseFilm film = new CNewReleaseFilm() { Title = "Matrix", Copies = 1 };
            CNewReleaseFilm film2 = new CNewReleaseFilm() { Title = "Matrix 2", Copies = 0 };
            inventory.AddFilm(film);
            inventory.AddFilm(film2);

            inventory.ListAllFilm();
            int actual = inventory.CurrentDataset.Count;
            Assert.AreEqual(expected, actual, "ListAllFilm is not work");

            expected = 1;
            inventory.ListAllFilmInStore();
            actual = inventory.CurrentDataset.Count;
            Assert.AreEqual(expected, actual, "ListAllFilmInStore is not work");
        }

        [TestMethod]
        public void OpenCloseOrder()
        {
            // Arrange
            string expected = @"Matrix(New release) 1 days 4 EURTotal price : 4 EURRemaining Bonus points: 2";
            BindingList<CCustomer>  customers = new BindingList<CCustomer>() { new CCustomer("James") { BonusPonts = 0 }, new CCustomer("Robert"), new CCustomer("Mary") };

            //check New Release film
            CFilm film = new CNewReleaseFilm() { Title = "Matrix", Copies = 1 };
            COrder order = new COrder(customers[0], new BindingList<CFilm>() { film}) ;

            string bill = order.StartRent(1).Replace(Environment.NewLine,"");

            Assert.AreEqual(expected, bill, "StartRent is not work");

            bill = order.EndRent().Replace(Environment.NewLine, "");

            expected = "Total price : 0 EUR";
            Assert.AreEqual(expected, bill, "EndRent is not work");

            //check bonus paid
            customers[0].BonusPonts = 25;
            order = new COrder(customers[0], new BindingList<CFilm>() { film });
            expected = "Matrix(New release) 1 days (Paid with 25 Bonus points)Total price : 0 EURRemaining Bonus points: 2";
            bill = order.StartRent(1).Replace(Environment.NewLine, "");
            Assert.AreEqual(expected, bill, "EndRent is not work");

            //When returning films late 
            order = new COrder(customers[0], new BindingList<CFilm>() { film });
            order.StartDate = DateTime.Now.AddDays(-3);
            order.PlanningRentDays = 1;
            bill = order.EndRent().Replace(Environment.NewLine, "");

            expected = "Matrix(New release) 2 extra days 8 EURTotal price : 8 EUR";
            Assert.AreEqual(expected, bill, "EndRent is not work");

            //check old film
            film = new COldFilm() { Title = "Out of africa", Copies = 1 };
            order = new COrder(customers[0], new BindingList<CFilm>() { film });
            expected = "Out of africa(Old) 1 days 3 EURTotal price : 3 EURRemaining Bonus points: 3";
            bill = order.StartRent(1).Replace(Environment.NewLine, "");

            Assert.AreEqual(expected, bill, "StartRent is not work");

            bill = order.EndRent().Replace(Environment.NewLine, "");

            expected = "Total price : 0 EUR";
            Assert.AreEqual(expected, bill, "EndRent is not work");

           
        }
    }
}
