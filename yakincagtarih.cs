using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yakincagtarih : MonoBehaviour
{
GameObject envanter1;
    public GameObject history_gameobject;
    public GameObject history_holder;
    public GameObject[] crted_historyhold = new GameObject[50];
    
    int sayac;
    // Start is called before the first frame update
    void Start()
    {
        sayac = 0;
        envanter1 = GameObject.FindGameObjectWithTag("Player");
    }
    public Text TimeTXT;

    public Text mesageTXT;
    float time = 1800;
    // Update is called once per frame
    void Update()
    {
        if (time < 2023)
        {
            time += Time.deltaTime;
            TimeTXT.text = Mathf.RoundToInt(time).ToString();

           
        }
        else
        {

            TimeTXT.text = "2023";
            SceneManager.LoadScene("kaybettin");

        }


        if (TimeTXT.text == "1800")
        {
            if (crted_historyhold[0] == null)
            {

                mesageTXT.text = "Alessandro Volta ilk elektrik bataryasını buldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Alessandro Volta ilk elektrik bataryasını buldu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1816")
        {
            if (crted_historyhold[1] == null)
            {

                mesageTXT.text = "RenéLaennec ilk stetoskopu icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "RenéLaennec ilk stetoskopu icat etti..";
                sayac++;
            }
        }
        if (TimeTXT.text == "1826")
        {
            if (crted_historyhold[2] == null)
            {

                mesageTXT.text = "JosephNicephoreNiepce ilk fotoğraf makinesini icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "JosephNicephoreNiepce ilk fotoğraf makinesini icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1830")
        {
            if (crted_historyhold[3] == null)
            {

                mesageTXT.text = "WilliamFothergillCooke ve Charles Wheatstone ilk elektrikli telgrafı icat ettiler.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "WilliamFothergillCooke ve Charles Wheatstone ilk elektrikli telgrafı icat ettiler.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1852")
        {
            if (crted_historyhold[4] == null)
            {

                mesageTXT.text = "ElishaGravesOtis ilk güvenli asansörü icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "ElishaGravesOtis ilk güvenli asansörü icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1876")
        {
            if (crted_historyhold[5] == null)
            {

                mesageTXT.text = "AlexanderGrahamBell telefonu icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "AlexanderGrahamBell telefonu icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1879")
        {
            if (crted_historyhold[5] == null)
            {

                mesageTXT.text = "Thomas Edison elektrik ampulünü icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Thomas Edison elektrik ampulünü icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1884")
        {
            if (crted_historyhold[6] == null)
            {

                mesageTXT.text = "HiramMaxim tam otomatik makineli tüfeği icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "HiramMaxim tam otomatik makineli tüfeği icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1885")
        {
            if (crted_historyhold[7] == null)
            {

                mesageTXT.text = "Karl Benz benzin motoruyla çalışan ilk otomobili icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Karl Benz benzin motoruyla çalışan ilk otomobili icat etti.";
                sayac++;
            }
        }

        if (TimeTXT.text == "1888")
        {
            if (crted_historyhold[8] == null)
            {

                mesageTXT.text = "StevenSasson ilk dijital fotoğraf makinesini icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "StevenSasson ilk dijital fotoğraf makinesini icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1895")
        {
            if (crted_historyhold[9] == null)
            {

                mesageTXT.text = "WillemEinthoven ilk elektrokardiyografi (EKG) kaydı almıştır.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "WillemEinthoven ilk elektrokardiyografi (EKG) kaydı almıştır.";
                sayac++;
            }
        }


        if (TimeTXT.text == "1903")
        {
            if (crted_historyhold[10] == null)
            {

                mesageTXT.text = "Wright kardeşler ilk motorlu uçağı icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Wright kardeşler ilk motorlu uçağı icat etti.";
                sayac++;
            }
        }

        if (TimeTXT.text == "1912")
        {
            if (crted_historyhold[11] == null)
            {

                mesageTXT.text = "Harry Brearly paslanmaz çeliği keşfetti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Harry Brearly paslanmaz çeliği keşfetti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1938")
        {
            if (crted_historyhold[12] == null)
            {

                mesageTXT.text = "Chester F. Carlson ilk fotokopi makinesini icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Chester F. Carlson ilk fotokopi makinesini icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1945")
        {
            if (crted_historyhold[13] == null)
            {

                mesageTXT.text = "J. Robert Oppenheimer ilk atom bombasını geliştirdi ve denedi.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "J. Robert Oppenheimer ilk atom bombasını geliştirdi ve denedi.";
                sayac++;
            }
        }

        if (TimeTXT.text == "1946")
        {
            if (crted_historyhold[14] == null)
            {

                mesageTXT.text = "ENIAC isimli ilk bilgisayar kullanıldı.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "ENIAC isimli ilk bilgisayar kullanıldı.";
                sayac++;
            }
        }

        if (TimeTXT.text == "1957")
        {
            if (crted_historyhold[15] == null)
            {

                mesageTXT.text = "SSCB, ilk yapay uydu Sputnik 1’i fırlattı.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "SSCB, ilk yapay uydu Sputnik 1’i fırlattı.";
                sayac++;
            }
        }

        if (TimeTXT.text == "1961")
        {
            if (crted_historyhold[16] == null)
            {

                mesageTXT.text = "YuriGagarin uzaya giden ilk insan oldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "YuriGagarin uzaya giden ilk insan oldu.";
                sayac++;
            }
        }


        if (TimeTXT.text == "1969")
        {
            if (crted_historyhold[17] == null)
            {

                mesageTXT.text = "Apollo 11 Ay’a ilk insanlı uçuşu gerçekleştirdi. Neil Armstrong ve EdwinAldrin Ay’a ayak basan ilk insanlar oldular.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "   Apollo 11 Ay’a ilk insanlı uçuşu gerçekleştirdi. Neil Armstrong ve EdwinAldrin Ay’a ayak basan ilk insanlar oldular.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1971")
        {
            if (crted_historyhold[18] == null)
            {

                mesageTXT.text = "FedericoFaggin ve ekibi tarafından mikroişlemci geliştirildi.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "FedericoFaggin ve ekibi tarafından mikroişlemci geliştirildi.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1975")
        {
            if (crted_historyhold[19] == null)
            {

                mesageTXT.text = "Microsoft yazılım şirketi kuruldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Microsoft yazılım şirketi kuruldu.";
                sayac++;
            }

        }
        if (TimeTXT.text == "1976")
        {
            if (crted_historyhold[20] == null)
            {

                mesageTXT.text = "Apple şirketi kuruldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Apple şirketi kuruldu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1984")
        {
            if (crted_historyhold[21] == null)
            {

                mesageTXT.text = "Apple, Macintosh isimli bilgisayarı satışa sundu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Apple, Macintosh isimli bilgisayarı satışa sundu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1985")
        {
            if (crted_historyhold[22] == null)
            {

                mesageTXT.text = "Microsoft, Windows işletim sistemini satışa sundu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Microsoft, Windows işletim sistemini satışa sundu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1998")
        {
            if (crted_historyhold[23] == null)
            {

                mesageTXT.text = "Google şirketi kuruldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Google şirketi kuruldu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "2005")
        {
            if (crted_historyhold[24] == null)
            {

                mesageTXT.text = "Video barındırma web sitesi YouTube kuruldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Video barındırma web sitesi YouTube kuruldu.";
                sayac++;
            }
        }
        if (TimeTXT.text == "2007")
        {
            if (crted_historyhold[25] == null)
            {

                mesageTXT.text = "Apple şirketinin ilk akıllı telefonu iPhone satışa sunuldu.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Apple şirketinin ilk akıllı telefonu iPhone satışa sunuldu.";
                sayac++;
            }
        }
    }
}
