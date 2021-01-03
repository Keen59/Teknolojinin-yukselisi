using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using System;

public class history : MonoBehaviour
{
    public GameObject history_gameobject;
    public GameObject history_holder;
    public GameObject[] crted_historyhold=new GameObject[50];
    int sayac;
    public GameObject tarihianlatim;
    public GameObject questmarker;
    GameObject player;
    public GameObject crafttabledokunulmaz;
    public GameObject background;
    public GameObject Mouse;
    public GameObject tuslar;
    public Text timer1;
    public Text timerwithinfo;
    public Text tarih;
    Animator anim;
    Animator anim2;
    float time = 0;
    float time2 = 0;
   public int hiz;
    public bool questmarker_ready;
    bool kontrol;
    float bekleme;
    bool kontrol2;
    bool tutorialends;
    GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        tutorialends = false;
        gameobject = GameObject.FindGameObjectWithTag("GameController");
        questmarker_ready = false;
        kontrol = false;
        player = GameObject.FindGameObjectWithTag("Player");
        sayac = 0;
        hiz = 2;
        bekleme = 0;
        kontrol2 = false;
        gameobject.GetComponent<stopeverythin>().durdur();
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
        gameobject.GetComponent<Arayuz>().tutorial = true;
    }
   
  
 
    // Update is called once per frame
    void Update()
    {
        if (kontrol!=true&&tutorialends==false)
        {
            time += Time.deltaTime * hiz;
           
            timer1.text = Math.Abs((int)time).ToString();

        }



        if (timer1.text == "0")
        {
            if (crted_historyhold[0] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Teknoloji'nin yükselişine hoş geldin.";

                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Teknoloji'nin yükselişine hoş geldin.";
                sayac++;
            }
        }
        else if (timer1.text == "10")
        {
            anim.SetBool("startkayma", false);

        }
        else if (timer1.text == "12")
        {
            if (crted_historyhold[1] == null)
            {//SCROOL layoutları incele, 



                timerwithinfo.text = "Arayüz hakkında bilgi vermek istiyorum.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Arayüz hakkında bilgi vermek istiyorum.";
                sayac++;
                anim.SetBool("startkayma", true);
            }
        }
        else if (timer1.text == "20")
        {
            anim.SetBool("startkayma", false);

        }
        else if (timer1.text == "22")
        {
            if (crted_historyhold[2] == null)
            {//SCROOL layoutları incele, 


                GameObject.Find("tarih").GetComponent<Canvas>().sortingOrder = 5;
                timerwithinfo.text = "Bu tarih akışının yazdığı saat.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Bu tarih akışının yazdığı saat.";
                sayac++;
                anim.SetBool("startkayma", true);
            }
        }
        else if (timer1.text == "30")
        {
            GameObject.Find("tarih").GetComponent<Canvas>().sortingOrder = 0;
            anim.SetBool("startkayma", false);

        }
        else if (timer1.text == "32")
        {
            if (crted_historyhold[3] == null)
            {//SCROOL layoutları incele, 
                timerwithinfo.text = "Şimdi biraz oyuna göz atalım.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Şimdi biraz oyuna göz atalım.";
                sayac++;
                anim.SetBool("startkayma", true);
            }
        }
        else if (timer1.text == "40")
        {

            anim.SetBool("startkayma", false);

            anim2.SetBool("yerinegit", true);
        }
        else if (timer1.text == "42")
        {
            if (crted_historyhold[4] == null)
            {//SCROOL layoutları incele, 

                tuslar.SetActive(true);
                tuslar.GetComponent<Canvas>().sortingOrder = 4;
                timerwithinfo.text = "W-A-S-D Tuşlarıyla biraz hareket et bakalım Left-Shift tuşuyla koşabilirsin,Boşluk tuşuylada zıplayabilirsin.";
                GameObject.Find("Canvas1").transform.GetChild(3).GetComponent<Canvas>().sortingOrder=2;
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);

                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "W-A-S-D Tuşlarıyla biraz hareket et bakalım Left-Shift tuşuyla koşabilirsin,Boşluk tuşuylada zıplayabilirsin.";
                sayac++;
                anim.SetBool("startkayma", true);
                kontrol = true;

            }
            bekleme += Time.deltaTime * 2;
            if (bekleme > 10)
            {
                tuslar.SetActive(false);
                background.SetActive(false);
                gameobject.GetComponent<stopeverythin>().baslat();
                kontrol = false;
                bekleme = 0;
            }
        }
        else if (timer1.text == "50")
        {

            anim.SetBool("startkayma", false);
            gameobject.GetComponent<Arayuz>().tutorial = true;
       
        }
        else if (timer1.text == "52")
        {
            if (crted_historyhold[5] == null)
            {//SCROOL layoutları incele, 

                for (int i = 0; i < GameObject.FindGameObjectsWithTag("agac").Length; i++)
                {

                    Instantiate(questmarker, GameObject.FindGameObjectsWithTag("agac")[i].transform.position, Quaternion.identity);

                }
                background.SetActive(true);
                kontrol = true;

                gameobject.GetComponent<stopeverythin>().durdur();
                player.GetComponent<Rigidbody>().isKinematic = true;
                timerwithinfo.text = "Şimdi ise işaretli alanlardan herhangi birine git.";
       
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Şimdi ise işaretli alanlardan herhangi birine git.";
                sayac++;
               
                anim.SetBool("startkayma", true);
            }
            bekleme += Time.deltaTime * 2;
            if (bekleme > 10)
            {

                gameobject.GetComponent<Arayuz>().tutorial = false;
                background.SetActive(false);
                gameobject.GetComponent<stopeverythin>().baslat();
                bekleme = 0;
            }
        }
        if (questmarker_ready)
        {
            anim.SetBool("startkayma", false);
             kontrol = false;
        }
        if (timer1.text == "54")
        {
            if (crted_historyhold[6] == null)
            {//SCROOL layoutları incele, 

                kontrol = true;
               
                timerwithinfo.text = "Ağaçlara 8 kez vur kırdığında yere düşen eşyaları topla!";
                gameobject.GetComponent<stopeverythin>().baslat();
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Ağaçlara 8 kez vur kırdığında yere düşen çubukları topla!";
                sayac++;
                anim.SetBool("startkayma", true);
                questmarker_ready = false;
            }
            bekleme += Time.deltaTime ;
            if (bekleme>10)
            {
                kontrol = false;
               
                anim.SetBool("startkayma", false);

                bekleme = 0;
            }
        }
         else if (timer1.text == "56")
        {
            if (crted_historyhold[7] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Ağaçlara vurmak için mouse'nin sol tıklama tuşunu kullan ve eşyaları envanterine alabilmek yakınına gitmen yeterli.";
                Mouse.GetComponent<Canvas>().sortingOrder = 2;
                Mouse.SetActive(true);
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Ağaçlara vurmak için mouse'nin sol tıklama tuşunu kullan ve eşyaları envanterine alabilmek için mouseni eşya'nın üzerine getirerek 'e' tuşuna bas.";
                sayac++;
              
                anim.SetBool("startkayma", true);
                kontrol = true;
            }
            bekleme += Time.deltaTime;
            if (bekleme>=5)
            {
               
                Mouse.SetActive(false);
                kontrol2 = true;
                background.SetActive(false);
                bekleme = 0;
            }
        }
        if (player.GetComponent<Envanter>().cubuk>0 && kontrol2 == true)
        {
            kontrol = false;
            kontrol2 = false;
            anim.SetBool("startkayma", false);
        }
        else if (timer1.text == "60")
        {
            if (crted_historyhold[8] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Tebrikler aldığın çubukları TAB tuşuna basarak envanterinde görebilirsin.";
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Tebrikler aldığın çubukları TAB tuşuna basarak envanterinde görebilirsin.";
                sayac++;
         
                anim.SetBool("startkayma", true);
         
            }
           
        }
         if (timer1.text == "68")
        {
       


            bekleme += Time.deltaTime*2;
            if (bekleme>=10)
            {
                bekleme= 0;
                kontrol = true;
                anim.SetBool("startkayma", false);
            }
        }
         if (Input.GetKeyDown(KeyCode.Tab)&& player.GetComponent<Envanter>().cubuk > 0)
        {
          
            if (crted_historyhold[9] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Envanterindeki itemleri tıklayarak eline alabilirsin tabi alınabiliyorsa.";
        
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Envanterindeki itemleri tıklayarak eline alabilirsin tabi alınabiliyorsa.";
                sayac++;
                anim.SetBool("startkayma", true);
                kontrol = false;
            }
            bekleme += Time.deltaTime * 2;
            if (bekleme >= 5)
            {
                bekleme = 0;
                kontrol = false;
                anim.SetBool("startkayma", false);
            }
        }
        else if (timer1.text == "78")
        {

            anim.SetBool("startkayma", false);

        }
        else if (timer1.text == "80")
        {
            if (crted_historyhold[10] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Şimdi biraz taş topla.";

               
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Şimdi biraz taş topla.";
                sayac++;
                kontrol = true;
                anim.SetBool("startkayma", true);
        
            }
      
            if (player.GetComponent<Envanter>().tas > 0)
            {
                bekleme = 0;
                kontrol = false;
                anim.SetBool("startkayma", false);
            }

        }
       else if (timer1.text == "82")
        {

            if (crted_historyhold[11] == null)
            {//SCROOL layoutları incele, 

                timerwithinfo.text = "Cadırın önündeki masaya git ve e tuşuna tıkla.";
                Instantiate(questmarker, GameObject.Find("craftingtable").transform.position, Quaternion.identity);
                crted_historyhold[sayac] = Instantiate(history_gameobject);
                crted_historyhold[sayac].transform.SetParent(history_holder.transform.GetChild(0).GetChild(1), false);
                crted_historyhold[sayac].transform.GetChild(0).GetComponent<Text>().text = "Cadırın önündeki masaya git ve e tuşuna tıkla.";
                sayac++;
                crafttabledokunulmaz.SetActive(false);
                anim.SetBool("startkayma", true);
                kontrol = false;
               tarihianlatim.SetActive(true);
                tutorialends = true;
            }

        }
    }
    // Update is called once per frame

}
