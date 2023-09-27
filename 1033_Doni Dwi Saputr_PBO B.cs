using System;

class Processor
{
    public string merk { get; set; }
    public string tipe { get; set; }

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel() : base("Intel", "Unknown") { }
}

class CoreI3 : Intel
{
    public CoreI3() : base() { tipe = "Core i3"; }
}

class CoreI5 : Intel
{
    public CoreI5() : base() { tipe = "Core i5"; }
}

class CoreI7 : Intel
{
    public CoreI7() : base() { tipe = "Core i7"; }
}

class AMD : Processor
{
    public AMD() : base("AMD", "Unknown") { }
}

class Ryzen : AMD
{
    public Ryzen() : base() { tipe = "Ryzen"; }
}

class Athlon : AMD
{
    public Athlon() : base() { tipe = "Athlon"; }
}

class VGA
{
    public string merk { get; set; }

    public VGA(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : VGA
{
    public Nvidia() : base("Nvidia") { }
}

class AMDGPU : VGA
{
    public AMDGPU() : base("AMD") { }
}

class Laptop
{
    public string merk { get; set; }
    public string tipe { get; set; }
    public VGA vga { get; set; }
    public Processor processor { get; set; }

    public Laptop(string merk, string tipe, VGA vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) { }
}

class ROG : ASUS
{
    public ROG() : base("ASUS", "ROG", new Nvidia(), new CoreI5()) { }
}

class Vivobook : ASUS
{
    public Vivobook() : base("ASUS", "Vivobook", new Nvidia(), new CoreI3()) { }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) { }
}

class Predator : ACER
{
    public Predator() : base("ACER", "Predator", new VGA("AMD"), new Processor("AMD", "Core i7")) { }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) { }
}

class IdeaPad : Lenovo
{
    public IdeaPad() : base("Lenovo", "IdeaPad", new AMDGPU(), new Ryzen()) { }
}

class Legion : Lenovo
{
    public Legion() : base("Lenovo", "Legion", new Nvidia(), new CoreI7()) { }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1, laptop2;

        Predator predator;

        laptop1 = new Vivobook();

        laptop2 = new IdeaPad();

        predator = new Predator();

        //1
        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();  

        //2
        //laptop1.Ngoding();

        //3
        // Menampilkan spesifikasi laptop1
        //Console.WriteLine("Spesifikasi Laptop 1:");
        //Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
        //Console.WriteLine($"Merk Processor: {laptop1.processor.merk}");
        //Console.WriteLine($"Tipe Processor: {laptop1.processor.tipe}");

        //4
        //predator.BermainGame();

        //5
        // Buat variabel acer bertipe data ACER, kemudian masukkan objek Predator sebagai nilainya
        //ACER acer = new Predator();
        //((Predator)acer).BermainGame();


    }
}
