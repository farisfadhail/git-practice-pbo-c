class Matematika
{
    public static int Penjumlahan(int angka1, int angka2)
    {
        return angka1 + angka2;
    }

    public static double Penjumlahan(double angka1, double angka2)
    {
        return angka1 + angka2;
    }
}

class Hewan
{
    public virtual void Bersuara()
    {
        Console.WriteLine("Hewan bersuara");
    }
}

class Kucing : Hewan
{
    public override void Bersuara()
    {
        Console.WriteLine("Kucing Bersuara");
    }
}

class Sapi : Hewan
{
    public override void Bersuara()
    {
        Console.WriteLine("Sapi Bersuara");
    }
}

class Anggora : Kucing
{
    public override void Bersuara()
    {
        Console.WriteLine("Kucing Anggora Bersuara");
    }
}

//class Mahasiswa
//{
//    private string nama;

//    public void SetNama(string nama)
//    {
//        this.nama = nama;
//    }

//    public string GetNama()
//    {
//        return this.nama;
//    }
//}

class Mahasiswa
{
    private string nama;
    public string Nama
    {
        get { return this.nama; }
        set { this.nama = value; }
    }
}

class Persegi
{
    private int panjang;
    private int lebar;
    private int luas;

    public int Panjang
    {
        get { return this.panjang; }
        set
        {
            this.panjang = value;
            this.UpdateLuas();
        }
    }

    public int Lebar
    {
        get { return this.lebar; }
        set
        {
            this.lebar = value;
            this.UpdateLuas();
        }
    }

    public int Luas
    {
        get { return this.luas; }
    }

    private void UpdateLuas()
    {
        this.luas = this.panjang * this.lebar;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        //mahasiswa.nama = "Budi"; // Error
        //Console.WriteLine(mahasiswa.nama); // Error
        
        mahasiswa.Nama = "Budi";
        Console.WriteLine(mahasiswa.Nama);
        // ini changes baru

        Persegi persegi = new Persegi();
        persegi.Lebar = 12;
        persegi.Panjang = 20;
        Console.WriteLine(persegi.Luas); // Output: 240
                                         // persegi.Luas = 120; // Error, karena tidak memiliki fungsi setter

    }
}