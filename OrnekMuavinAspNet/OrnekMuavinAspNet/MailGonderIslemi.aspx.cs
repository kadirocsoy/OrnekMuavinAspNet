using MuavinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class MailGonderIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Öncelikle MuavinCode'dan türüyen KaynakMail sınıfı oluşturuyoruz. Bu sınıfın amacı mail gönderimi yapılacak e-mail adresinin giriş bilgilerini yazmak. İsterseniz bunu bir sınıf içerisinde tanımlayıp farklı sayfalarda da kullanabilirsiniz.
            KaynakMail km = new KaynakMail
            {
                girisemail = "gonderici@kadirocsoy.com",// Gönderim yapılacak e-mail adresi.
                girissifresi = "Deneme123",             // E-mail adresinin şifresi.
                hostadres = "mail.kadirocsoy.com",      // E-mail adresinin giriş yapıldığı host adresi.
                port = 587,                             // Port adresi. Genellikle 587 oluyor.
                kimdenisim = "Abdulkadir Öçsoy",        // Gönderici adı soyadı.
                kimdenmailadres = "info@kadirocsoy.com" // Gönderici e-mail adresi.
            };

            var sonuc1 = Muavin.MailGonder(km, "E-Mail Konusu", "E-Mail İçeriği", "alici1@kadirocsoy.com");
            var sonuc2 = Muavin.MailGonder(km, "E-Mail Konusu", "E-Mail İçeriği", "alici1@kadirocsoy.com", "alici2@kadirocsoy.com");
            var sonuc3 = Muavin.MailGonder(km, "E-Mail Konusu", "E-Mail İçeriği", "alici1@kadirocsoy.com", "alici2@kadirocsoy.com", "alici3@kadirocsoy.com");
            // E-Mail İçeriğinden sonra bir veya birden fazla e-mail adresi ekleyip daha fazla kişiye mail gönderebilirsiniz.
            // E-mail gönderim işlemi başarılı sonuçlandığında geriye true değerini başarısız olduğunda ise false değerini döndürür.

        }
    }
}