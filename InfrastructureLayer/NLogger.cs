using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using NLog.Web;

namespace InfrastructureLayer
{
    public class NLogger
    {
        public void LoggerConfig()
        {
            Logger logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            try
            {
                logger.Debug("init main function");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in init");
                throw;
            }
            finally
            {
                LogManager.Shutdown();
            }
        }
    }
}
