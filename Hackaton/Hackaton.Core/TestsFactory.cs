using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackaton.Core.Tests;
using Hackaton.Core.DataContracts;

namespace Hackaton.Core {
    public class TestsFactory {

        public TestsFactory() {
            IocFactory.Register(Component.For<ITest>().ImplementedBy<AuthOnlyTest>("1"));
            IocFactory.Register(Component.For<ITest>().ImplementedBy<AuthAndCaptureTest>("2"));
            IocFactory.Register(Component.For<ITest>().ImplementedBy<CaptureTest>("3"));
            IocFactory.Register(Component.For<ITest>().ImplementedBy<VoidTest>("4"));
            IocFactory.Register(Component.For<ITest>().ImplementedBy<RefundTest>("5"));

        }

        public TestResponse TestProcessor(TestRequest testRequest) {

            ITest test = IocFactory.ResolveByName<ITest>(testRequest.TestId);

            TestResponse response = new TestResponse();
            
            return test.Execute();


        }
    }
}
