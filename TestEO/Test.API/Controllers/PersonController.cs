using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Test.API.Responses;
using Test.API.Services;
using Test.API.ViewModels;
using Test.Domain.BusinessLayer.Contracts;
using Test.Domain.EntityLayer;

namespace Test.API.Controllers
{
    [RoutePrefix("api/persons")]
    public class PersonController : ApiController
    {
        protected ITestBusinessObject BusinessObject;
        public PersonController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/Person
        [Route("")]
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<PersonViewModel>();
            try
            {
                response.Model = await Task.Run(() =>
                {
                    return BusinessObject.GetPersons().Select(item => new PersonViewModel(item)).ToList();
                });

            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // GET: api/Person/5
        [Route("{id:int}")]
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<PersonViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetPerson(new Person(id));
                });
                response.Model = new PersonViewModel(entity);

            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // POST: api/Person
        [Route("")]
        public async Task<HttpResponseMessage> Post([FromBody]Person value)
        {
            var response = new SingleResponse<PersonViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreatePerson(value);
                });
                response.Model = new PersonViewModel(entity);

            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/Person/5
        [Route("{id:int}")]
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Person value)
        {
            var response = new SingleResponse<PersonViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdatePerson(value);
                });
                response.Model = new PersonViewModel(entity);
                response.Message = "Record Updated Successfully!";

            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/Person/5
        [Route("{id:int}")]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<PersonViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeletePerson(new Person(id));
                });
                response.Model = new PersonViewModel(entity);
                response.Message = "Record Deleted Successfully!";
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
