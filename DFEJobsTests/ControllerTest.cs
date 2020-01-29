using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using DFEJobs;
using DFEJobs.Controllers;
using System.Data.SqlClient;

namespace DFEJobsTests
{
    [TestClass]
    public class ControllerTest
    {
        // HomeController

        [TestMethod]
        public void HomeIndex()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Government Job Portal", result.ViewBag.Message);
        }

        // JobsController

        /*
        [TestMethod]
        public void JobsIndex()
        {
            //Arrange
            JobsController controller = new JobsController();

            //Act
            ViewResult result2 = controller.Index("Education") as ViewResult;
            //ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Education Vacancies", result2.ViewBag.Message);
        }
        */

        [TestMethod]
        public void JobsCreate()
        {
            //Arrange
            JobsController controller = new JobsController();

            //Act
            ViewResult result = controller.Create() as ViewResult;

            //Assert
            Assert.AreEqual("Create a new job vacancy", result.ViewBag.Message);
        }

        [TestMethod]
        public void JobsDetailsZero()
        {
            //Arrange
            JobsController controller = new JobsController();

            //Act
            ViewResult result = controller.Details(0) as ViewResult;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void JobsDetailsNegative()
        {
            //Arrange
            JobsController controller = new JobsController();

            //Act
            ViewResult result = controller.Details(-1) as ViewResult;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void JobsDetailsOne()
        {
            //Arrange
            JobsController controller = new JobsController();

            //Act
            ViewResult result = controller.Details(1) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
