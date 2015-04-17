using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.DataContracts {
    public class TestResponse {

        public TestResponse() {
            this.ErrorReportCollection = new List<ErrorReport>();
        }

        public bool Success { get; set; }

        public List<ErrorReport> ErrorReportCollection { get; set; }
    }
}
