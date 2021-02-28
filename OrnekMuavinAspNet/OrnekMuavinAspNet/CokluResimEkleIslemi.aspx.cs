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
    public partial class CokluResimEkleIslemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            // Resimleri eklemeden önce dosya seçilip seçilmediğini kontrol ediyoruz.
            if (!string.IsNullOrEmpty(resimler.FileName))
            {
                // Birden fazla resim yükleme işlemi için yeni bir stream listesi ve resim uzantıları için yeni bir string listesi oluşturuyoruz.
                List<Stream> stResimListesi = new List<Stream>();
                List<string> resimuzantilari = new List<string>(); // Eğer seçili resimler ortak uzantı ise bunu oluşturmanıza gerek yok.

                // Seçilen resimleri döngüye sokup tek tek stream listesine ve uzantı listesine ekliyoruz.
                foreach (var item in resimler.PostedFiles)
                {
                    stResimListesi.Add(item.InputStream);
                    resimuzantilari.Add(item.ContentType.Split('/')[1]);
                }

                // Eğer seçili resimlerin hepsi aynı uzantıda ise bu işlemi kullanabilirsiniz.
                var dosyaisimleri1 = Muavin.CokluDosyaEkle(stResimListesi, ".jpg", Server.MapPath("/images/"));

                // Eğer seçili resimlerin uzantıları birbirinden farklı ise işlemi uygulayabilirsiniz.
                var dosyaisimleri2 = Muavin.CokluDosyaEkle(stResimListesi, resimuzantilari, Server.MapPath("/images/"));

                // stResimListesi, seçili resimlerin stream listesi
                // ".jpg", eğer ortak uzantı ise tek bir uzantı adı yazabilirsiniz.
                // resimuzantilari, eğer uzantılar farklı ise string listesi halinde verebilirsiniz.
                // Server.MapPath("/images/") methodu ile de resmin yüklemesini istediğimiz klasörün dosya yolu.
            }
        }
    }
}