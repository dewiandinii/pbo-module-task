using System;

class program
{
        static void Main()
        {
            KebunBinatang zoo = new KebunBinatang();

            Singa singa = new Singa("Singa aslan", 5, 4);
            Gajah gajah = new Gajah("Gajah afrika", 10, 4);
            Ular ular = new Ular("Ular piton", 3, 6);
            Buaya buaya = new Buaya("Buaya darat", 18, 1.7);

            zoo.TambahHewan(singa);
            zoo.TambahHewan(gajah);
            zoo.TambahHewan(ular);
            zoo.TambahHewan(buaya);

        //Console.WriteLine("*DAFTAR HEWAN*");
        //Console.WriteLine("Berikut ini beberapa hewan yang ada di kebun binatang :");
        //Console.WriteLine();
        //zoo.DaftarHewan();

        //Console.WriteLine("*DEMONSTRASI POLYMORPHISM*");
        //Console.WriteLine($"Suara Singa: {singa.Suara()}");
        //singa.Mengaum();
        //Console.WriteLine($"Suara Ular: {ular.Suara()}");
        //ular.Merayap();
        //Console.WriteLine($"Suara Gajah: {gajah.Suara()}");
        //Console.WriteLine($"Suara Buaya: {buaya.Suara()}");

        //singa.InfoMamalia();

        Reptil reptil = new Buaya("Buaya darat", 18, 1.7);
        Console.WriteLine(reptil.Suara());
    }
}




public class Hewan
{
    private string nama;
    private int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }
    public void InfoHewan()
    {
        Console.WriteLine($"Nama hewan ini yaitu {nama}, {nama} berumur {umur} tahun");
    }
}

class Mamalia : Hewan
{
    private int jumlahKaki;

    public Mamalia (string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public void InfoMamalia()
    {
        InfoHewan();
        Console.WriteLine($"Jumlah kaki: {jumlahKaki}");
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "grrr auumm";
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum ganas");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "trooeett";
    }
}

class Reptil : Hewan
{
    private double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public void InfoReptil()
    {
        InfoHewan();
        Console.WriteLine($"Panjang tubuh: {panjangTubuh} meter");
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "sssss ssss";
    }

    public void Merayap()
    {
        Console.WriteLine("Awas! ular sedang merayap");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "kalo aku chat ada yg marah ngga";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (Hewan hewan in koleksiHewan)
        {
            if (hewan is Singa)
            {
                Singa singa = (Singa)hewan;
                singa.InfoMamalia();
                Console.WriteLine($"Suara: {singa.Suara()}");
            }
            else if (hewan is Gajah)
            {
                Gajah gajah = (Gajah)hewan;
                gajah.InfoMamalia();
                Console.WriteLine($"Suara: {gajah.Suara()}");
            }
            else if (hewan is Ular)
            {
                Ular ular = (Ular)hewan;
                ular.InfoReptil();
                Console.WriteLine($"Suara: {ular.Suara()}");
            }
            else if (hewan is Buaya)
            {
                Buaya buaya = (Buaya)hewan;
                buaya.InfoReptil();
                Console.WriteLine($"Suara: {buaya.Suara()}");
            }
            Console.WriteLine();
        }
    }
}

