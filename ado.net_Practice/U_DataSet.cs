using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ado.net_Practice
{
    internal class U_DataSet
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;

        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            #region Employee DataTable

            #endregion
            return dt;
        }

        DataTable GetDepartmentTable()
        {
            dt = new DataTable("Department");
            #region Department DataTable
            #endregion
            return dt;
        }

    }
}
