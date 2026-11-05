using System;


// no 1
public class Agen
{
    public string idAgen;
    public string namaAgen;
    int stokAgen;

    public Agen(string idAgen, string namaAgen, int stokAgen)
    {
        this.idAgen = idAgen;
        this.namaAgen = namaAgen;
        this.stokAgen = stokAgen;
    }

    public void TampilInfo()
    {
        Console.WriteLine($"ID Agen: {idAgen} \nNama Agen:{namaAgen} \nStok Agen:{stokAgen}");
    }
}

// no 2
public class ProdukGalon
{
    private string idProduk { get; set; }
    private string namaProduk { get; set; }
    private int stokGudang { get; set ; }


    public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        this.idProduk = idProduk;
        this.namaProduk = namaProduk;
        this.stokGudang = stokGudang;
    }
    public void KurangiStok(int jumlah)
    {
        stokGudang -= jumlah;
    }
    public virtual void HitungBiaya(int jumlah)
    {
        
    }

}


// no 3
public class GalonAkua : ProdukGalon
{

    public int harga;
    public GalonAkua(string idProduk, string namaProduk, int stokGudang) : base(idProduk, namaProduk, stokGudang)
    {
        this.harga = harga;
    }

    public void KurangiStokAqua(int jumlah)
    {
        KurangiStok(jumlah);
    }
    public override void HitungBiaya(int jumlah)
    {
        base.HitungBiaya(jumlah * 20000);
    }
}

public class GalonBerkeran : ProdukGalon
{
    int harga = 12000;
    public GalonBerkeran(string idProduk, string namaProduk, int stokGudang) : base(idProduk, namaProduk, stokGudang)
    {
        this.harga = harga;
    }

    public void KurangiStokBerkeran(int jumlah)
    {
        KurangiStok(jumlah);
    }
    public override void HitungBiaya(int jumlah)
    {
        base.HitungBiaya(jumlah * 12000);
    }
}

// no 6 

public class DistribusiGalon
{
    public void KirimPaket()
    {
        Console.WriteLine("Paket berhasil dikirimkan ke agen...");
    }
}
class Program
{
    static void Main()
    {
        Agen agen1 = new Agen("ag1", "Aji", 100);
        Agen agen2 = new Agen("ag2", "Asep", 50);
        agen1.TampilInfo();
        agen2.TampilInfo();
        Console.WriteLine();

        ProdukGalon galon1 = new ProdukGalon("gl1", "aqua", 100);
        ProdukGalon galon2 = new ProdukGalon("gl2", "entahlah", 500);
        galon1.HitungBiaya(10);
        galon2.HitungBiaya(4);
        galon1.KurangiStok(100);
    }
}

//nyawit semua😂