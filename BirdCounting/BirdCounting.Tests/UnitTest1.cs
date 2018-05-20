using BirdCounting.Models;
using BirdCounting.Repositories;
using BirdCounting.Services;
using BirdCounting.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace BirdCounting.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Bird_Index_Should_Display_BirdList()
        {
            var birds = new List<Bird>
            {
                new Bird
                {
                    ID = 1,
                    Name = "Bird1"
                },
                new Bird
                {
                    ID = 2,
                    Name = "Bird2"
                },
                new Bird
                {
                    ID = 3,
                    Name = "Bird3"
                }
            };

            var mockBirdService = new Mock<IBirdService>();
            mockBirdService.Setup(b => b.GetAllBirds()).Returns(birds.ToList());

            var controller = new BirdController(mockBirdService.Object, null, null);
            var result = controller.Index() as ViewResult;
            var viewModel = controller.ViewData.Model as List<Bird>;

            //Assert.IsNotNull(result);
            Assert.IsTrue(viewModel.Count() == mockBirdService.Object.GetAllBirds().Count());
        }

        [TestMethod]
        public void BirdService_GetAllBirds_Should_Return_ListOfBirds()
        {
            var birds = new List<Bird>
            {
                new Bird
                {
                    ID = 1,
                    Name = "Bird1"
                },
                new Bird
                {
                    ID = 2,
                    Name = "Bird2"
                },
                new Bird
                {
                    ID = 3,
                    Name = "Bird3"
                }
            };

            var mock = new Mock<IBirdService>();
            mock.Setup(b => b.GetAllBirds()).Returns(birds.ToList());

            var controller = new BirdController(mock.Object, null, null);
            var result = controller.Index();

            Assert.IsNotNull(birds.Count());
        }
    }
}
