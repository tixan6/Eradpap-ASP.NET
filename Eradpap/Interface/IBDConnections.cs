using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eradpap.Interface
{
    interface IBDConnections
    {
    
        string ConnetcToBD { get; set; }
        string Request { get; set; }
        void ConnnectionOpen();
        void ConnnectionClose();
        object RequestExecution();
    }
}
