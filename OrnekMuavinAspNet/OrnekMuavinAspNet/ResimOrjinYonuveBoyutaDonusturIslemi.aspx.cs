using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class ResimOrjinYonuIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            var img = Muavin.ResimOrjinYonu(resim.PostedFile.InputStream);
            // resim.InputStream, resim dosyasının stream formatı

            // Geriye Image tipinde resminizi döndürür.


            var dosyaboyutu = Muavin.BoyutaDonustur(resim.PostedFile.ContentLength);
            //Geriye örneğin 786.5KB, 10.2MB gibi değerler döndürür.
        }
    }
}