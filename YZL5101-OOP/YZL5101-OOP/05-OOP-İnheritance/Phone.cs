using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_İnheritance
{
    internal class Phone
    {
        private string _brand;
		private string _phoneType;
		private string _connectionType;

   //     public phone()
   //     {
			//_phonetype = "ahizeli telefon";
   //     }
		public Phone(string brand,string connectiıonType) // yapıcı
		{
			_brand = brand;
			_connectionType = connectiıonType;
		}

        public string Brand
		{
			get { return _brand; }
			set { _brand = value; }
		}
	
		public string PhoneType
		{
			get { return _phoneType; }
			set { _phoneType = value; }
		}

        public string ConnectionType
		{
			get { return _connectionType; }
			set { _connectionType = value; }
		}
		public virtual string Call() // virtual keywordu cocukların ezmesini izin verir ezilebilir demek
		{
			return "Ahizeli Telefon Çalıyor";
		}
		public virtual string ConnectionStatus()
		{
			return "Kablolu Bağlantısı Mevcut";
		}
	}
}
