using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fee.DataContracts.FeeRegistration.Model
{
   public class OrderStatus
    {
        public string OrderNumber { get; set; }
        public virtual string OrderDate { get; set; }
        public virtual string RequestorFirstName { get; set; }
        public virtual string RequestorLastName { get; set; }
        public string RecordType { get; set; }
       
        
        public virtual string Status { get; set; }
    }
}
