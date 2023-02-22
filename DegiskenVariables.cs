using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//pascal case her kelime büyük YeniBirMethod, DegiskenVariables, MonoBeheviour gibi.
public class DegiskenVariables : MonoBehaviour
{

    //global alanimiz.
    //snake case yazim kurali: baslangicta _ gelir ilk kelime kucuk sonraki kelimelerin ilk harfi buyuk.
    //global variable, private field denilir.
    int _sayi;
    int _sayiDegiskeni;

    void Start()
    {
        //camel case yazim kurali kelimenin ilk harfi kucuk sonraki kelime buyuk harfle baslar ve genelde local degiskenler icin kullanilir.
        //local degiskenimiz.
        //int birinciSayi = 20;
        //int sayi = 10;
        string deger1 = "Ekonomi Panda";

        string yeniVeri = deger1 + " eklendi";

        
    }

    public void YeniBirMethod()
    {

        //Local alan

    }
    
  
}
 