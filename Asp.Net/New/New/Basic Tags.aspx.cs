using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New
{
	public partial class Basic_Tags : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			txt1.Text = "You Clicked the Button";
		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			LinkButton1.Text = "Registred successfully";
		}

		protected void txt1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}