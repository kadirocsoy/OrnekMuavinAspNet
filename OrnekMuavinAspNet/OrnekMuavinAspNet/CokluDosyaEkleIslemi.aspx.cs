using MuavinCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekMuavinAspNet
{
    public partial class CokluDosyaEkleIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            // Dosyaları eklemeden önce dosya seçilip seçilmediğini kontrol ediyoruz.
            if (!string.IsNullOrEmpty(dosyalar.FileName))
            {
                // Birden fazla dosya işlemi için yeni bir stream listesi ve dosya uzantıları için yeni bir string listesi oluşturuyoruz.
                List<Stream> stDosyaListesi = new List<Stream>();
                List<string> dosyauzantilari = new List<string>(); // Eğer seçili dosyalar ortak uzantı ise bunu oluşturmanıza gerek yok.

                // Seçilen dosyaları döngüye sokup tek tek stream listesine ve uzantı listesine ekliyoruz.
                foreach (var item in dosyalar.PostedFiles)
                {
                    stDosyaListesi.Add(item.InputStream);
                    dosyauzantilari.Add(item.ContentType.Split('/')[1]);
                }

                // Eğer seçili dosyalarınızın hepsi aynı uzantıda ise bu işlemi kullanabilirsiniz.
                var dosyaisimleri1 = Muavin.CokluDosyaEkle(stDosyaListesi, ".pdf", Server.MapPath("/dosya/"));

                // Eğer seçili dosyalarınızın uzantıları birbirinden farklı ise işlemi uygulayabilirsiniz.
                var dosyaisimleri2 = Muavin.CokluDosyaEkle(stDosyaListesi, dosyauzantilari, Server.MapPath("/dosya/"));

                // stDosyaListesi, seçili dosyalarınızın stream listesi
                // ".pdf", eğer ortak uzantı ise tek bir uzantı adı yazabilirsiniz.
                // dosyauzantilari, eğer uzantılar farklı ise string listesi halinde verebilirsiniz.
                // Server.MapPath("/dosya/") methodu ile de dosyamızın yüklemesini istediğimiz klasörün dosya yolu.
            }
        }
    }
}