using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer
{
    public class EmpVO
    {
        public EmpVO()
        {
            StaticLogger.LogInfo(this.GetType(), "Instance created");
        }
    }
}
