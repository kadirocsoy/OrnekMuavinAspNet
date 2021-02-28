using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class DosyaGuncelleIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            var dosyaadi = "";
            var eskidosyaadi = "deneme.pdf";

            // Dosya güncelleme işlemini yapmadan önce dosyanın seçilip seçilmediğini kontrol ediyoruz.
            if (!string.IsNullOrEmpty(dosya.FileName))
            {
                dosyaadi = Muavin.DosyaGuncelle(dosya.PostedFile.InputStream, dosya.PostedFile.ContentType.Split('/')[1], Server.MapPath("/dosya/"), eskidosyaadi);
            }
            //  dosya.PostedFile.InputStream, FileUpload bize yüklemek istediğimiz dosyanın stream formatını veriyor.
            //  dosya.PostedFile.ContentType.Split('/')[1], dosyanın uzantısını alabiliyoruz. İsterseniz 'Path.GetExtension(dosya.PostedFile.FileName)' methodu ile de dosyanızın uzantısını alabilirsiniz.
            //  Server.MapPath("/dosya/") methodu ile de dosyamızın yüklemesini istediğimiz klasörün dosya yolunu belirtiyoruz.
            //  eskidosyaadi, güncelleme işlemi sırasında eski dosyanız varsa onu silmeniz için yazabilirsiniz. yok ise boş geçebilirsiniz.

            //  Eğer dosya ekleme işlemi başarılı olursa Guid methodu ile rastgele 40 karakterlik string adında dosyanızı kayıt eder ve size o string adını döndürür. Eğer başarısız olursa eski dosya ismini geri döndürür.
        }
    }
}