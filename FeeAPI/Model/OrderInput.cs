using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fee.DataContracts.FeeRegistration.Model
{
  public  class OrderInput
    {
        public DateTime? OrderDate { get; set; }
        public string RequestorFirstName { get; set; }
        public string RequestorLastName { get; set; }
        public string RequestorAddress { get; set; }
        public string Zip { get; set; }
        public string RecordType { get; set; }
        public string RegistrantFirstName { get; set; }

        public string RegistrantLastName { get; set; }
    }
}
