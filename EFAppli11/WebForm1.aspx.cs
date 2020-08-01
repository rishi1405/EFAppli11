using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFAppli11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmplDBContext employeeDBContext = new EmplDBContext();
            GridView1.DataSource = employeeDBContext.Empls.Select(emp => new
            {
                EmployeeName = emp.EmployeeName,
                ManagerName = emp.Manager == null ? "Super Boss"
                                : emp.Manager.EmployeeName
            }).ToList();
            GridView1.DataBind();
        }
    }
}