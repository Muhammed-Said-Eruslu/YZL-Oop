using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_İnheritance
{
    internal class MobilePhone : Phone // Phoneden miras aldı 
      // private olarak tanımlanan bir şey miras alsa bile kullanamaz
    {
        public MobilePhone(bool hastCamera, bool ısTouched, string brand, string connectionType ):base(brand,connectionType)
            // bu sınıfan nesne üretceksen parametreleri girmek zorunda // ne zaman nesne üretirse Phone ctoru tetikler
            // base brand olduğu için atasından aldı 
        {
            // base atası 
            base.Brand = brand; // atasından aldığı değerleri kendi değişkenime atadım
            base.ConnectionType = connectionType;
            this.HasCamera = hastCamera;
            this.IsTouched = ısTouched;
            base.PhoneType = "Mobile Phone"; // base nın phone typenı ezdim
           

              
        }
        //public MobilePhone()
        //{
        //    PhoneType = "Mobile Phone";
        //}
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public string TakeFoto()
        {
            return HasCamera ? "You can take a photo" : "There is no cam"; // ternary if
        }

        public override string Call() // override ettiğim metodu bu sınıfn içinde tekrar kullanamam
            // override üzerine yazım // ama atası izin vermezse override yapılmaz
        {
            return "Polifonik Müzik Cender Cendere";
        }
        public override string ConnectionStatus()
        {
            return "3G Bağlantı";
        }
    }
}
// protected bir uyeye türeyen sınıfta erişebilirim ama instas'ı alınırsa erimemem