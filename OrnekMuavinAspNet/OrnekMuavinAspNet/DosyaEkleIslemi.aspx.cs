using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class DosyaEkleIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  1-) UrlDonustur();
            //    Geri size döndüreceği string değer "her-hangi-bir-haber-basligi" şeklinde olacaktır.
            var deger = Muavin.UrlDonustur("Her Hangi Bir HaBer BAŞLIĞI");
        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            var dosyaadi = "";

            // Dosya ekleme işlemini yapmadan önce dosyanın seçilip seçilmediğini kontrol ediyoruz.
            if (!string.IsNullOrEmpty(dosya.FileName))
            {
                dosyaadi = Muavin.DosyaEkle(dosya.PostedFile.InputStream, dosya.PostedFile.ContentType.Split('/')[1], Server.MapPath("/dosya/"));
            }
            //  dosya.PostedFile.InputStream, FileUpload bize yüklemek istediğimiz dosyanın stream formatını veriyor.
            //  dosya.PostedFile.ContentType.Split('/')[1], dosyanın uzantısını alabiliyoruz. İsterseniz 'Path.GetExtension(dosya.PostedFile.FileName)' methodu ile de dosyanızın uzantısını alabilirsiniz.
            //  Server.MapPath("/dosya/") methodu ile de dosyamızın yüklemesini istediğimiz klasörün dosya yolunu belirtiyoruz.

            //  Eğer dosya ekleme işlemi başarılı olursa Guid methodu ile rastgele 40 karakterlik string adında dosyanızı kayıt eder ve size o string adını döndürür.
        }
    }
}