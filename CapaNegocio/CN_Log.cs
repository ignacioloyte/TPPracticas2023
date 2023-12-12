using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    public class CN_Log
    {
        private LogData logData;

        public CN_Log(string connectionString)
        {
            logData = new LogData(connectionString);
        }

        public void LogAction(string user, string action, string details)
        {
            LogEntry logEntry = new LogEntry
            {
                Timestamp = DateTime.Now,
                User = user,
                Action = action,
                Details = details
            };

            logData.InsertLog(logEntry);
        }
    }
}

