using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication13
{
    class Class1
    {
        SqlConnection cn;

        public Class1(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool isConnection
        {
            get
            {            
                    {
                        if (cn.State == System.Data.ConnectionState.Closed)
                            cn.Open();
                        return true; 
                    }
                }
            
            
                
                          
        }
    }
}
