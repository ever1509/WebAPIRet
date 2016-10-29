using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.API.Services;
using Test.API.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Test.API.Responses;
using Test.API.ViewModels;
using Test.Domain.EntityLayer;

namespace Test.API.Tests.Controllers
{
    [TestClass]
    public class PersonControllerTest
    {
        protected IBusinessObjectService service;
        [TestInitialize]
        public void Init()
        {
            service = new BusinessObjectService();
        }
        [TestMethod]
        public async Task GetPeople()
        {
            //Arrange
            var controller = new PersonController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var result = await controller.Get();

            //Assert
            var response = default(ComposedResponse<PersonViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model);
            Console.WriteLine(String.Format("Response: {0}", response.Model.ToString()));
        }
        [TestMethod]
        public async Task GetPerson()
        {
            //Arrange
            var controller = new PersonController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var result = await controller.Get(1);

            //Assert
            var response = default(SingleResponse<PersonViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model);
            Console.WriteLine(String.Format("Response: {0}", response.Model.ToString()));
        }
        [TestMethod]
        public async Task CreatePerson()
        {
            //Arrange
            var controller = new PersonController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var model = new Person(){
                Id=7,
                FirstName="Juan",
                LastName="Perez"
            };
            var result = await controller.Post(model);

            //Assert
            var response = default(SingleResponse<PersonViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model.id);
            Console.WriteLine(String.Format("Response: {0}", response.Model.ToString()));
        }
        [TestMethod]
        public async Task UpdatePerson()
        {
            //Arrange
            var controller = new PersonController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var model = new Person()
            {
                Id = 6,
                FirstName = "Juan",
                LastName = "Perez"
            };
            var result = await controller.Put(6,model);

            //Assert
            var response = default(SingleResponse<PersonViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsTrue(response.Message == "Record Updated Successfully!");
            Console.WriteLine(String.Format("Response: {0}", response.Message.ToString()));
        }
        [TestMethod]
        public async Task DeletePerson()
        {
            //Arrange
            var controller = new PersonController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act          
            var result = await controller.Delete(4);

            //Assert
            var response = default(SingleResponse<PersonViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsTrue(response.Message == "Record Deleted Successfully!");
            Console.WriteLine(String.Format("Response: {0}", response.Message.ToString()));
        }

    }
}
