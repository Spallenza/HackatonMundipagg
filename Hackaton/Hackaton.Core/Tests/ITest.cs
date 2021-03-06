﻿using Hackaton.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Tests {
    public interface ITest {

        string GetTestId();

        TestResponse Execute(TestRequest testRequest);
    }
}
