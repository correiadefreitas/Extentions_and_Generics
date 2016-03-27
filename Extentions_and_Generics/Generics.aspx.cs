using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Extentions_and_Generics
{
    public partial class Generics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtInt.Attributes.Add("style", "border: 1px solid black;");
                txtDecimal.Attributes.Add("style", "border: 1px solid black;");
            }
        }

        protected T GetValue<T>(TextBox txt)
        {
            var t = typeof(T);

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                t = Nullable.GetUnderlyingType(t);
            }

            T s;
            try
            {
                s = (T)Convert.ChangeType(txt.Text.Replace(".", ","), t);
                txt.Attributes.Add("style", "border: 1px solid black;");
            }
            catch
            {
                s = default(T);
                txt.Attributes.Add("style", "border: 1px solid red;");
            }
            return s;
        }

        protected void txtInt_TextChanged(object sender, EventArgs e)
        {
            litInt.Text = "Returned value: " + GetValue<int>(txtInt);
        }

        protected void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            litDecimal.Text = "Returned value: " + GetValue<decimal>(txtDecimal);
        }

    }
}