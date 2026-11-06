// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public abstract class Pembayaran
{
    public abstract void ProsesPembayaran();

    public void Info()
    {
        Console.WriteLine("Ini adalah kendaraan");
    }
}

public class Tunai : Pembayaran
{
    public override void ProsesPembayaran()
    {

    }

    public void Coba()
    {

    }
}

public class Qris : Pembayaran
{
    public override void ProsesPembayaran()
    {
        Qris pembayaran = new Qris();
    }
}