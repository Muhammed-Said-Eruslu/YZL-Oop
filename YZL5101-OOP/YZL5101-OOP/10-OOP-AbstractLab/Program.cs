using _10_OOP_AbstractLab; // proeje dahil edilen sınıflara erişim sağlanır

Keman keman = new Keman();
Müzisyen müzisyen = new Müzisyen();

Müzisyen müzisyen1 = new Müzisyen()
{ // burada kullanılan initialization block(başlatma bloğudur)
    Adı = "Muhammed Said",
    SoyAdı = "Eruslu",
    müzikAleti = new Keman(), // çaldığı alet keman
    müzikAletis = new List<MüzikAleti>() // müzisyenin çaldığı birden fazla aleti tutmak için
    {
        new Keman(),
        new Batari(),
    }
};