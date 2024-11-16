using _05_OOP_İnheritance;

Phone basePhone = new Phone("AEG","Kablolu Bağlantı");

basePhone.Brand = "AEG";
basePhone.ConnectionType = "Kablolu Bağlantı";

Console.WriteLine(basePhone.Call());

Console.WriteLine($"{basePhone.PhoneType} {basePhone.ConnectionType} {basePhone.Brand}");

MobilePhone phone = new MobilePhone(true,true,"Nokia","3G");

//phone.Brand = "Nokia";
//phone.ConnectionType = "3G";
//phone.HasCamera = true;
//phone.IsTouched = true;



Console.WriteLine($"{phone.Brand}-{phone.PhoneType}-{phone.ConnectionType}-{phone.HasCamera}-{phone.IsTouched}");
Console.WriteLine(phone.Call());
Console.WriteLine(phone.ConnectionStatus());

SmartPhone smartPhone = new SmartPhone(true,true,true,"Apple","5G");
Console.WriteLine(smartPhone.ConnectionStatus());
