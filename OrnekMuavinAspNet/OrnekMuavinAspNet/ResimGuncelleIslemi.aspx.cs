using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class ResimGuncelleIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            string eskiresimadi = "deneme.jpg";
            // Resmin seçili olup olmadığını kontrol ediyoruz.
            if (!string.IsNullOrEmpty(resim.FileName))
            {
                var resimadi = Muavin.ResimGuncelle(resim.PostedFile.InputStream, resim.PostedFile.ContentType.Split('/')[1], Server.MapPath("/images/"), eskiresimadi, true, 1000);

                // resim.PostedFile.InputStream, HttpPostedFileBase bize yüklemek istediğimiz resmimizin stream formatını veriyor.
                // resim.PostedFile.ContentType.Split('/')[1], resmin uzantısını alabiliyoruz. İsterseniz 'Path.GetExtension(dosya.FileName)' methodu ile de resmin uzantısını alabilirsiniz.
                //  Server.MapPath("/images/") methodu ile de resmin yüklemesini istediğimiz klasörün dosya yolunu belirtiyoruz.
                // eskiresimadi, güncelleme işlemi sırasında eski resminiz varsa onu silmeniz için yazabilirsiniz. yok ise boş geçebilirsiniz.
                // true, yüklenecek resmin dosya boyutunda küçülme işlemi yaptırmanızı sağlar. Eğer orjinal boyutu olsun isterseniz false yazınız.
                //ÖNEMLİ NOT: Eğer yüklemek istediğiniz resim arka planı transparan ise arka planı siyah renk yapacaktır.
                // 1000, Resmin olmasını istediğiniz genişliği belirtiyoruz. Yüksekliği orantı işlemi hesaplanacaktır. Eğer orjinal genişlikte kalmasını isterseniz "0" sıfır yazınız.

                // Eğer resim ekleme işlemi başarılı olursa Guid methodu ile rastgele 40 karakterlik string adında resmi kayıt eder ve size o string adını döndürür. Başarısız olduğu durumda boş bir string değer döndürür.
            }
        }
    }
}