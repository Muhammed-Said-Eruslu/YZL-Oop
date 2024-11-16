using System;

namespace _10_OOP_AbstractLab;

public abstract class MüzikAleti
{
    public string Name { get; set; }
    public string Descriptıon { get; set; }
    public abstract string Music(); // Abstract metotun boddy'si olmaz
}
