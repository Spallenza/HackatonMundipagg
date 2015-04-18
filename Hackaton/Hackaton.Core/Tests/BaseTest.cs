using Hackaton.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Tests {
   public abstract class BaseTest : ITest {

       public string GetTestId() {
           throw new NotImplementedException();
       
       }

       public abstract TestResponse Execute(TestRequest testRequest);
   }
}
