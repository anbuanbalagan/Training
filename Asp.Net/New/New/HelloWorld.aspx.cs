using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New
{
	public partial class HelloWorld : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void lkbutton(object sender, EventArgs e)
		{
			lbtnsubmit.Text = "Saved";

		}
	}
}