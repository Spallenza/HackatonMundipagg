using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models {
    public class SecondTest {
        public int TestId { get; set; }
        public string MerchantKey { get; set; }
        public List<AbstractQuestion> QuestionsList { get; set; }
    }
}