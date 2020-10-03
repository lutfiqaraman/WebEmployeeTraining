using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer
{
    public class EmpVO : ApplicationBase
    {
        public EmpVO() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            Log.Info("Instance created");
        }
    }
}
