using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ortacaghistory : MonoBehaviour
{
    GameObject envanter1;
    // Start is called before the first frame update
    void Start()
    {
        envanter1 = GameObject.FindGameObjectWithTag("Player");
    }
    public GameObject history_gameobject;
    public GameObject history_holder;
    public GameObject[] crted_historyhold = new GameObject[50];

    int sayac;
    public Text TimeTXT;

    public Text mesageTXT;
    float time=345;
    // Update is called once per frame
    void Update()
    {
        if (time < 1453)
        {
            time += Time.deltaTime * 2;
            TimeTXT.text = Mathf.RoundToInt(time).ToString();

            if (envanter1.GetComponent<Envanter>().vinc >= 1)
            {
                SceneManager.LoadScene("yenicag");
            }
        }
        else
        {

            TimeTXT.text = "1453";
            SceneManager.LoadScene("kaybettin");

        }


   
        if (TimeTXT.text == "350")
        {

          
            if (crted_historyhold[0] == null)
            {

                mesageTXT.text = "KAVİMLER GÖÇÜ.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "KAVİMLER GÖÇÜ.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1280")
        {

            if (crted_historyhold[1] == null)
            {
                mesageTXT.text = " İtalyan fizikçi Armatigözlüğü icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = " İtalyan fizikçi Armatigözlüğü icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1400")
        {

                if (crted_historyhold[2] == null)
                {
                    mesageTXT.text = "İtalya’da palangalı tasarlandı.";
                    crted_historyhold[sayac] = Instantiate(history_gameobject);
                    crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                    crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "İtalya’da palangalı tasarlandı.";
                sayac++;
                }
            }
        if (TimeTXT.text == "1450")
        {

                    if (crted_historyhold[3] == null)
                    {
                        mesageTXT.text = "Johannes Gutenberg matbaayı icat etti.";
                        crted_historyhold[sayac] = Instantiate(history_gameobject);
                        crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                        crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Johannes Gutenberg matbaayı icat etti.";
                sayac++;
                    }
                }
        if (TimeTXT.text == "1453")
        {

                        if (crted_historyhold[4] == null)
                        {
                            mesageTXT.text = "OSMANLI DEVLETİ KONSTANTİNOPOLİS’İ ELEGEÇİRDİ.";
                            crted_historyhold[sayac] = Instantiate(history_gameobject);
                            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "OSMANLI DEVLETİ KONSTANTİNOPOLİS’İ ELEGEÇİRDİ.";
                sayac++;
                        }
                    }

    }
}
