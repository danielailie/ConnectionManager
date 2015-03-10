using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionManager
{
    class ConnectionManager
    {
        Connection connection=new Connection();
        static List<Connection> connections= new List<Connection>();

        public static void GetConnections()
        {
            foreach (var c in connections)
            {
                
            }
        }
    }
}
