using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VeriTipleri : MonoBehaviour
{//baslangic scope

    // 1. yazim kuralimiz codelar scopelar arasina yazilir.
    // 2. Methodlarinda ayni ac kapat scopelari vardir ve method olustururken normal parantez olusturmak
    // zorundayiz bu bir yazim kuralidir.
    // 3. codelar ; ile biter.
    // yazim hatalarina syntax error denilir.
    // "//"  koyuldugunda yorum satiridir, kod okunurken bu okunnmaz.

    /*
        bu      
        da
        coklu
        yorum
        satiridir.
    */


    // short, int, long sayi2 = Convert.ToInt16(sayi1); sayi2 yi sayi1'in degerini int16 yani short a cevirmesini sagliyor
    // Debug.Log(sayi2.GetType()); ise sayi2'nin veri tipini yazdiriyor.
    // String de karakter dizilimleri icin kullanilir.
    // string adim = "Emre blabla"; gibisinden


    private void Start()
    {
        Method6();
    }


    // "=" atama degeridir, esittir degildir. Sagdaki degerleri soldaki degere atariz.

    public void Method1()
    {//baslangic scope

        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

    }//kapanis scope
    public void Method2()
    {

        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

        string tcKimlik = "21526755379";
        string telNo = "05334255232";


        //Yazdirma tipleri.
        Debug.Log("Sonuc: " + sonuc);
        Debug.Log(string.Format("Sonuc: {0}", sonuc));
        Debug.Log($"Sonuc: {sonuc}");

        Debug.Log("TC KIMLIK:" + tcKimlik);
        Debug.Log("Tel No:" + telNo);




    }
    public void Method3()
    {

        float sayi1 = 10.5f;
        float sayi2 = 20.9f;

        float sonuc = sayi1 + sayi2;

        Debug.Log($"Sonuc:{sonuc}");




    }
    public void Method4()
    {

        bool value1 = true;
        //bool value2 = false;

        value1 = false;

        if(value1)
        {
            Debug.Log("Value1 true oldu");
        }
        else
        {
            Debug.Log("Value1 false oldu");
        }
        
        


    }
    public void Method5()
    {
        // object her degerin atasi oldugu icin istedigini atayabilirsin.
        object value1 = 10;
        object value2 = "string veri";
        object value3 = 55.25;

        //Convert degil Cast etme islemi.
        int sayi = (int)value1;
        string stringVeri = (string)value2;
    }
    public void Method6()
    {
        int sayi = 10;

        //      10  + 20
        //en uzun yazim
        //sayi = sayi + 20; // sonuc => 30
        // ayni islem ama daha kisa hali.
        // - hali de "-=" o da cikarma islemi.
        // sayi += 20;

        //hepsi sayiyi 1 artirir ama en kisasi sayi++; dir.
        sayi++;
        sayi = sayi + 1;
        sayi += 1;

        sayi--;

        Debug.Log(sayi);

        // string myString = "unity";

        // myString = myString + " ogreniyorum.";
        // ayni islem daha kisa hali.
        // myString += " ogreniyorum.";

        //Debug.Log(myString);

    }

}//kapanis scope
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            