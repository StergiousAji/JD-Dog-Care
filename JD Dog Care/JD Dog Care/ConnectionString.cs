using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Dog_Care
{
    class ConnectionString
    {
        private string myConnection;
        public ConnectionString()
        {
            this.myConnection = $@"Data Source =.; Initial Catalog = JD Dog Care; Integrated Security = True";
        }

        public string MyConnection
        {
            get { return myConnection; }
            set { myConnection = value; }
        }
    }
}
