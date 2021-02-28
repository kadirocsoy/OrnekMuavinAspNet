using MuavinCode;
using OrnekMuavinAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class ListeDonustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // Tabi bu kısma yeni bir DataTable değil, select sorgusu sonucu verileriniz gelecek.

            var ogrenciler = Muavin.ListeDonustur<Ogrenci>(dt);
            // '<' ve '>' işaretleri arasındaki Ogrenci kısım DataTable'dan gelen verilerinizin dönüştürülmesini istediğiniz sınıf.
            // dt, DataTable'daki verileriniz.

            //İşlem başarılı olduğunda List<Ogrenci> tipinde öğrenci listesini size döndürecektir.
        }
    }
}