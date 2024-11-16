using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_İnheritance
{
    internal class SmartPhone : MobilePhone
    {
        public SmartPhone(bool frontCam,bool hastCamera, bool ısTouched, string brand, string connectionType) : base(hastCamera, ısTouched, brand, connectionType)
        {
            this.FrontCam = frontCam;
            PhoneType = "Apple";
        }
        public bool FrontCam { get; set; }

        public override string Call()
        {
            return "Apple Müziği";
        }
        public override string ConnectionStatus()
        {
            return $"Marka:{Brand} Bağlantı Tipi:{ConnectionType} Ön Kamera: {FrontCam} Arka Kamera: {HasCamera} Dokunmatik: {IsTouched}";
        }

    }
}
