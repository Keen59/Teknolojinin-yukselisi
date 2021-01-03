using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Arayuz : MonoBehaviour
{
    public GameObject esc;
    public bool tutorial = false;
    public GameObject oyunkontrol;
    public Sprite[] durdurbaslatimages;
    public Image durdurbaslatimage;
    public GameObject tutorialanlatimi;
    public GameObject history_holder;
    public GameObject envanter;
    public GameObject quest;
    GameObject gameobject;
    int historyscript;
    public AudioClip[] audios;
    AudioSource source;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        kontrolquest = false;
        player = GameObject.FindGameObjectWithTag("Player");

        gameobject = GameObject.FindGameObjectWithTag("GameController");
        historyscript = tutorialanlatimi.GetComponent<history>().hiz;
    }
    public void envanteropen_close()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && esc.active != true && player.GetComponent<characterproperty>().cameracraftanim == false && oyunkontrol.GetComponent<Animator>().GetBool("ac") != true && history_holder.active == false && oyunkontrol.GetComponent<Animator>().GetBool("ac") != true)
        {
            if (envanter.active == false)
            {
                Debug.Log("afa");

                gameobject.GetComponent<stopeverythin>().durdur();
                envanter.SetActive(true);
            }
            else
            {
                Debug.Log("afa");

                gameobject.GetComponent<stopeverythin>().baslat();
                envanter.SetActive(false);
            }

        }
    }
    public void escmenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            source.GetComponent<AudioSource>().clip = audios[1];
            source.Play();
            if (esc.active == true && player.GetComponent<characterproperty>().cameracraftanim == true)
            {
                esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", false);
            }
            else if (esc.active == false && player.GetComponent<characterproperty>().cameracraftanim == true)
            {
                esc.SetActive(true);
            }
            else if (esc.active == false && player.GetComponent<characterproperty>().cameracraftanim == false)
            {
                esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", true);
                gameobject.GetComponent<stopeverythin>().durdur();
                esc.SetActive(true);
                envanter.active = false;
                GameObject.Find("zamandb").transform.GetChild(0).transform.GetComponent<Animator>().SetBool("ac", false);
                history_holder.GetComponent<Animator>().SetBool("ac", false);
            }
            else if (esc.active == true && player.GetComponent<characterproperty>().cameracraftanim == false)
            {

                gameobject.GetComponent<stopeverythin>().baslat();
                esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", false);

            }
            //if (esc.active == true && player.GetComponent<characterproperty>().cameracraftanim == true)
            //{

            //    esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", false);
            //}
            //else if (esc.active == true && player.GetComponent<characterproperty>().cameracraftanim == false)
            //{
            //    gameobject.GetComponent<stopeverythin>().baslat();
            //    esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", false);

            //}
            //else if (esc.active == false)
            //{
            //    esc.transform.GetChild(0).GetComponent<Animator>().SetBool("ac", true);
            //    gameobject.GetComponent<stopeverythin>().durdur();
            //    esc.SetActive(true);
            //    envanter.GetComponent<Animator>().SetBool("envanteropen", false);
            //    GameObject.Find("zamandb").transform.GetChild(0).transform.GetComponent<Animator>().SetBool("ac", false);
            //    history_holder.GetComponent<Animator>().SetBool("ac", false);
            //}
        }


    }
    public void oyundancik()
    {
        Application.Quit();

    }
    public void Onclickmouse()
    {

        nameofbutton = EventSystem.current.currentSelectedGameObject.GetComponent<Transform>().name;

    }
    string nameofbutton;
    public void open_history()
    {

        if (Input.GetKeyDown(KeyCode.H) || nameofbutton == "history" && quest.GetComponent<Animator>().GetBool("ac") == false && esc.active != true && player.GetComponent<characterproperty>().cameracraftanim == false && envanter.active != true)
        {
            nameofbutton = "";
            source.GetComponent<AudioSource>().clip = audios[1];
            source.Play();
            if (oyunkontrol.GetComponent<Animator>().GetBool("ac") != true)
            {
                if (history_holder.GetComponent<Animator>().GetBool("ac") == false)
                {
                    history_holder.SetActive(true);
                    gameobject.GetComponent<stopeverythin>().durdur();
                    history_holder.GetComponent<Animator>().SetBool("ac", true);
                }
                else
                {
                    history_holder.GetComponent<Animator>().SetBool("ac", false);
                    gameobject.GetComponent<stopeverythin>().baslat();

                }
            }
            else
            {
                if (history_holder.GetComponent<Animator>().GetBool("ac") == false)
                {
                    history_holder.SetActive(true);

                    history_holder.GetComponent<Animator>().SetBool("ac", true);
                }
                else
                {
                    history_holder.GetComponent<Animator>().SetBool("ac", false);


                }
            }
        }
    }
    public void yavaslat()
    {
        if (tutorial != true)
        {
            if (historyscript > 0)
            {
                historyscript--;
            }
        }



    }
    public void hizlandir()
    {
        if (tutorial != true)
        {

            if (historyscript < 10)
            {
                historyscript++;
            }
        }




    }
    public void oynkont()
    {



        if (Input.GetKeyDown(KeyCode.P) || nameofbutton == "stopplaybutton" && esc.active != true && player.GetComponent<characterproperty>().cameracraftanim == false && envanter.active != true)
        {
            nameofbutton = "";
            source.GetComponent<AudioSource>().clip = audios[2];
            source.Play();
            if (oyunkontrol.GetComponent<Animator>().GetBool("ac") == true)
            {
                GameObject.Find("zamandb").transform.GetChild(0).transform.GetComponent<Animator>().SetBool("ac", false);
                durdurbaslatimage.sprite = durdurbaslatimages[0];
                gameobject.GetComponent<stopeverythin>().baslat();
                if (history_holder.GetComponent<Animator>().GetBool("ac") == true)
                {
                    history_holder.GetComponent<Animator>().SetBool("ac", false);
                }
                if (quest.GetComponent<Animator>().GetBool("ac") == true)
                {
                    quest.GetComponent<Animator>().SetBool("ac", false);
                }
            }
            else
            {
                durdurbaslatimage.sprite = durdurbaslatimages[1];
                gameobject.GetComponent<stopeverythin>().durdur();
                GameObject.Find("zamandb").transform.GetChild(0).transform.GetComponent<Animator>().SetBool("ac", true);
            }


        }

    }
    public void yapincagöster()
    {

        if (player.GetComponent<Envanter>().balta >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == false)
        {
            quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(0).GetComponent<Image>().color = Color.white;
            quest.SetActive(true);
            quest.transform.GetComponent<Animator>().SetBool("ac", true);
            kontrolquest = true;
            Debug.Log("aaaafff");

        }
        else if (player.GetComponent<Envanter>().balta >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == true)
        {
            quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(0).GetComponent<Image>().color = Color.white;

            kontrolquest = true;
        }
       else if (player.GetComponent<Envanter>().kazma >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == false)
        {
            quest.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(1).GetComponent<Image>().color = Color.white;
            quest.SetActive(true);
            quest.transform.GetComponent<Animator>().SetBool("ac", true);
            kontrolquest = true;
            Debug.Log("aaaafff");

        }
        else if (player.GetComponent<Envanter>().kazma >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == true)
        {
            quest.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(1).GetComponent<Image>().color = Color.white;

            kontrolquest = true;
        }
        else if (player.GetComponent<Envanter>().tekerlek >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == false)
        {
            quest.transform.GetChild(0).GetChild(2).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(2).GetComponent<Image>().color = Color.white;
            quest.SetActive(true);
            quest.transform.GetComponent<Animator>().SetBool("ac", true);
            kontrolquest = true;
            Debug.Log("aaaafff");

        }
        else if (player.GetComponent<Envanter>().tekerlek >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == true)
        {
            quest.transform.GetChild(0).GetChild(2).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(2).GetComponent<Image>().color = Color.white;

            kontrolquest = true;
        }
        else if (player.GetComponent<Envanter>().campfire >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == false)
        {
            quest.transform.GetChild(0).GetChild(3).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(3).GetComponent<Image>().color = Color.white;
            quest.SetActive(true);
            quest.transform.GetComponent<Animator>().SetBool("ac", true);
            kontrolquest = true;
            Debug.Log("aaaafff");

        }
        else if (player.GetComponent<Envanter>().campfire >= 1 && quest.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.activeSelf == false && quest.GetComponent<Animator>().GetBool("ac") == true)
        {
            quest.transform.GetChild(0).GetChild(3).GetChild(1).gameObject.SetActive(true);
            quest.transform.GetChild(0).GetChild(3).GetComponent<Image>().color = Color.white;

            kontrolquest = true;
        }
    }
    public void questop()
    {
        if (Input.GetKeyDown(KeyCode.Q) || nameofbutton == "quest" && esc.active != true && envanter.active != true && history_holder.active == false)
        {
            nameofbutton = "";
            if (oyunkontrol.GetComponent<Animator>().GetBool("ac") != true)
            {
                if (player.GetComponent<characterproperty>().cameracraftanim == false)
                {
                    if (quest.GetComponent<Animator>().GetBool("ac") == false)
                    {
                        quest.SetActive(true);
                        quest.transform.GetComponent<Animator>().SetBool("ac", true);
                        gameobject.GetComponent<stopeverythin>().durdur();

                    }
                    else
                    {

                        gameobject.GetComponent<stopeverythin>().baslat();
                        quest.transform.GetComponent<Animator>().SetBool("ac", false);
                    }
                }
                else
                {


                    if (quest.GetComponent<Animator>().GetBool("ac") == false)
                    {
                        quest.SetActive(true);
                        quest.transform.GetComponent<Animator>().SetBool("ac", true);


                    }
                    else
                    {


                        quest.transform.GetComponent<Animator>().SetBool("ac", false);
                    }
                }
            }
            else
            {
                if (quest.GetComponent<Animator>().GetBool("ac") == false)
                {
                    quest.SetActive(true);
                    quest.transform.GetComponent<Animator>().SetBool("ac", true);


                }
                else
                {


                    quest.transform.GetComponent<Animator>().SetBool("ac", false);
                }
            }
        }

    }

   


   
    public void anamenudon()
    {
        SceneManager.LoadScene(1);


    }
    bool kontrolquest;
    float bekle = 0;
    // Update is called once per frame
    void Update()
{
    if (tutorial != true)
    {
          
        oynkont();
            questop();
            open_history();
        envanteropen_close();
            escmenu();
            yapincagöster();
           
    }
        if (kontrolquest==true)
        {
            bekle += Time.deltaTime;
            if (bekle >= 3)
            {
                quest.transform.GetComponent<Animator>().SetBool("ac", false);
                kontrolquest = false;
                bekle = 0;
                Debug.Log("aaaaff2f");
            }
        }
       
    }
}
