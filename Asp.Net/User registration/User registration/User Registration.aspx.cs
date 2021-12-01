using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_registration
{
	public partial class User_Registration : System.Web.UI.Page
	{
		string gender;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void rbtnmale_CheckedChanged(object sender, EventArgs e)
		{
			gender = "Male";
		}

		protected void rbtnfemale_CheckedChanged(object sender, EventArgs e)
		{
			gender = "Female";
		}

		protected void rbtnothers_CheckedChanged(object sender, EventArgs e)
		{
			gender = "Others";
		}

		protected void btnregister_Click(object sender, EventArgs e)
		{
			
		}
	}
}