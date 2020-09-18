using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Fee.DataContracts.FeeRegistration.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServiceController : ControllerBase
    {
        [HttpGet]

        [ProducesResponseType(typeof(List<OrderStatus>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.TooManyRequests)]
        [ProducesResponseType((int)HttpStatusCode.MultipleChoices)]
        [Route("GetOrderStatusWithRemit")]
        public  ActionResult GetOrderStatusWithRemit(string RemitNumber, string OrderDate)
        {
            List<OrderStatus> retVal=new List<OrderStatus>() ;
            OrderStatus obj = new OrderStatus();
            obj.OrderDate = System.DateTime.Now.ToShortDateString();
            obj.OrderNumber = "F123456";
            obj.RecordType = "Birth";
            obj.RequestorFirstName = "Tome";
            obj.RequestorLastName = "Ponting";
            obj.Status = "Completed";
               // retVal = null;// channel.GetOrderStatus(RemitNumber, OrderDate);
            if (retVal == null || retVal.Count == 0)
                {
                    return NotFound("No Order found");
                }
                return Ok(retVal);
            
           

        }
        public  async Task<int> Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    
                }
            });
            return 100;
        }


        public async Task<int> Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                
            }
            return 100;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<OrderStatus>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.TooManyRequests)]
        [ProducesResponseType((int)HttpStatusCode.MultipleChoices)]
        [Route("GetOrderStatusNoRemit")]
        public ActionResult GetOrderStatusNoRemit(OrderInput order)
        {
            List<OrderStatus> retVal = new List<OrderStatus>();



            // retVal = null;// channel.GetOrderStatus(RemitNumber, OrderDate);
            if (retVal == null || retVal.Count == 0)
            {
                return NotFound("No Order found");
            }
            return Ok(retVal);

        }
    }
}
