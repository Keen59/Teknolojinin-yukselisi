using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yenicagtarih : MonoBehaviour
{
    public GameObject history_gameobject;
    public GameObject history_holder;
    public GameObject[] crted_historyhold = new GameObject[50];
    GameObject envanter1;
    int sayac;
    // Start is called before the first frame update
    void Start()
    {
        sayac = 0;
        envanter1 = GameObject.FindGameObjectWithTag("Player");
    }
    public Text TimeTXT;

    public Text mesageTXT;
    float time = 1450;
    // Update is called once per frame
    void Update()
    {
        if (time < 1799)
        {
            time += Time.deltaTime;
            TimeTXT.text = Mathf.RoundToInt(time).ToString();

            if (envanter1.GetComponent<Envanter>().balon >= 1)
            {
                
                SceneManager.LoadScene(4);
            }
        }
        else
        {

            TimeTXT.text = "1453";
            SceneManager.LoadScene("kaybettin");

        }


        //	Debug.Log (TimeTXT.text.ToString());

        if (TimeTXT.text == "1453")
        {
            if (crted_historyhold[0] == null)
            {//SCROOL layoutları incele, 


                mesageTXT.text = "OSMANLI DEVLETİ KONSTANTİNOPOLİS’İ ELEGEÇİRDİ.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "OSMANLI DEVLETİ KONSTANTİNOPOLİS’İ ELEGEÇİRDİ.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1569")
        {
            if (crted_historyhold[1] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "Gerardus Mercator merkatör projeksiyonu icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Gerardus Mercator merkatör projeksiyonu icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1589")
        {
            if (crted_historyhold[2] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "William Lee dokuma tezgahını icat etti.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "William Lee dokuma tezgahını icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1600")
        {

            if (crted_historyhold[3] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "Johannes Gutenberg matbaayı icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Johannes Gutenberg matbaayı icat etti.";
                sayac++;
        }
    }
        if (TimeTXT.text == "1642")
        {
            if (crted_historyhold[4] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "Blais Pascal hesap makinesini icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Blais Pascal hesap makinesini icat etti.";
                sayac++;
            }
        }
        if (TimeTXT.text == "1643")
        {
            if (crted_historyhold[5] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "EvangelistaToricelli barometreyi icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "EvangelistaToricelli barometreyi icat etti.";
                sayac++;
        }
       }
        if (TimeTXT.text == "1650   ")
        {
            if (crted_historyhold[6] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "Ottovon Guericke vakum pompasını icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Ottovon Guericke vakum pompasını icat etti.";
                sayac++;
        }
    }

       
        if (TimeTXT.text == "1698")
        {
            if (crted_historyhold[7] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "ThomasSavery ticari olarak satılan ilk buhar makinesini üretti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "ThomasSavery ticari olarak satılan ilk buhar makinesini üretti.";
                sayac++;
        }
    }
        if (TimeTXT.text == "1769")
        {

            if (crted_historyhold[8] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "JamesWattWatt makinesi olarak bilinen buhar makinesini icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "JamesWattWatt makinesi olarak bilinen buhar makinesini icat etti.";
                sayac++;
        }
    }
        if (TimeTXT.text == "1783")
        {
            if (crted_historyhold[9] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "JosephMichelMontgolfier ve JacquesEtienneMontgolfier kardeşler sıcak hava balonu ile ilk insanlı uçuşu gerçekleştirdiler.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "JosephMichelMontgolfier ve JacquesEtienneMontgolfier kardeşler sıcak hava balonu ile ilk insanlı uçuşu gerçekleştirdiler.";
                sayac++;
        }
    }
        if (TimeTXT.text == "1783")
        {
            if (crted_historyhold[10] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "EvangelistaToricelli barometreyi icat etti.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "EvangelistaToricelli barometreyi icat etti.";
                sayac++;
        }
    }
        if (TimeTXT.text == "1799")
        {
            if (crted_historyhold[11] == null)
            {//SCROOL layoutları incele, 

                mesageTXT.text = "Fransız Devrimi.";
            crted_historyhold[sayac] = Instantiate(history_gameobject);
            crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

            crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Fransız Devrimi.";
                sayac++;
        }
    }
    }
}
