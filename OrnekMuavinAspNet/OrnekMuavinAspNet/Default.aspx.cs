using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  1-) UrlDonustur();
            //    Geri size döndüreceği string değer "her-hangi-bir-haber-basligi" şeklinde olacaktır.
            var deger = Muavin.UrlDonustur("Her Hangi Bir HaBer BAŞLIĞI");
        }
    }
}