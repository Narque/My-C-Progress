using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SartYapilari : MonoBehaviour
{
    //private int sayi; gizlidir deðiþtirilemez.
    //public int sayi; herkese açýktýr deðiþtirebilir.

    public int sayi;
    [SerializeField] string gun;
    [SerializeField] bool ternaryIfDegisken;

    private void IfElseGiris()
    {
        if (sayi < 10) // parantez icine sart ister ve bu sart sonucu bize true yada false bool tipini döner.
        {
            Debug.Log("Verilen sayi 10'dan kucuktur.");
        }
        
        else if (sayi > 10)//if saglaniyormu bakar saglanmiyosa else bakar 2 si de saðlanmýyorsa bu komut calisir.
        {
            Debug.Log("Verilen sayi 10'dan buyuktur.");
        }

        else
        {
            Debug.Log("hic bir sart saglanmiyorsa else calisir.");
        }

            Debug.Log("Sart saglansin veya saglanmasin if else if else'ten sonra bu kisim calisir.");



    }

    private void IfElseVeIliskiselOperatorler()
    {
        if (sayi > 10)
        {
            if (sayi > 5)
            {
                Debug.Log("Girilen sayi 10'dan kucuk ve 5'ten buyuktur");
            }
            else
            {
                Debug.Log("Girilen sayi 10'dan kucuk ve 5'ten kucuk veya 5'e esittir");
            }
        }
        //  == esit mi diye sorar.
        //  >=(buyuk esit mi?) <=(kucuk esit mi?)  <(kucuk mu?) >(buyuk mu?) ==(esit mi?) !=(esit degilse) iliskisel operatorer
        if (sayi >= 10)// sayi 10'dan buyuk veya 10'a esit ise bize true don ve if sarti icinde ne isteniyorsa onu yap.
        {

        }
    }

    private void IfElseVeMantikOperatorleri()
    {
        /* 
        1. if else
        2. switch case
        3. ternary if
        */

        //mantik operatorleri
        // ve &&
        // veya ||

        // ve && de 2 sartta saglanmasi gerekiyor.
        /* if (sayi > 10 && sayi < 20)
         {
             Debug.Log("Girilen sayi 10'dan buyuk ve 20'den kucuktur");

         }
        */

        //veya || da herhangi 2 sarttan biri saglansa yetiyor.
        if (sayi < 10 || sayi > 20)
        {
            Debug.Log("Sayi 10 dan kücük veya 20 den buyuk.");
        }
    }

    private void IfElseTernaryIf()
    {
        //normal if else
        // sart () icindeki.
        if (ternaryIfDegisken)
        {
            Debug.Log("True dondu");
        }
        else
        {
            Debug.Log("False dondu");
        }
        // ternary if denir.
        //             sart               true          false burdaki sart soru isaretenin solundaki deger.
        Debug.Log(ternaryIfDegisken ? "True dondu" : "False dondu");
    }

    private void IfElseSwitch()
    {
        //Switch Case -- Esitlik olmasi gerekiyor.
        /*    if (gun == "Pazartesi")
        {
            Debug.Log("Bugun gunlerden pazartesi");
        }
        else if(gun == "Sali")
        {
            Debug.Log("Bugun gunlerden sali");
        }
        else if (gun == "Carsamba")
        {
            Debug.Log("Bugun gunlerden carsamba");
        }
        else
        {
            Debug.Log("yazdiginiz gun haftanin ilk 3 gununden biri degil!");
        }
        */

        switch (gun)
        {
            case "Pazartesi":
                //gun pazartesi case'ine esitse case ve break arasindaki kodlari calistirir.
                Debug.Log("Bugun gunlerden pazartesi");
                break;
            case "Sali":
                Debug.Log("Bugun gunlerden sali");
                break;
            case "Carsamba":
                Debug.Log("Bugun gunlerden carsamba");
                break;
            default:
                Debug.Log("yazdiginiz gun haftanin ilk 3 gununden biri degil!");
                break;
        }
    }

    private void Start()
    {
        


    }   
}
