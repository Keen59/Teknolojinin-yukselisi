using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craft : MonoBehaviour
{
    public GameObject craftingtable;
    public Transform content;
    public GameObject craftbut;
    public GameObject craftcanvas;

    public GameObject[] craftbuttons;
   public int ortaodun;
    public int ortacubuk;
    public int ortatas;
    public int ortakazma;
    public int ortamakara;
    public int ortakalas;
    public int ortaip;
    public int ortabalonmotor;
    public int ortahasir;
    public int ortakumas;

    public int ortaucaktekerlek;
    public int ortagovde;
    public int ortaucakmotor;
    public int ortakanat;
    public int ortapervane;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "craftpervane")
        {
            ortapervane = 1;

        }


        if (other.tag == "craftgovde")
        {
            ortagovde = 1;
        }


        if (other.tag == "craftucaktekerlek")
        {
            ortaucaktekerlek = 1;
        }

        if (other.tag == "craftucakmotor")
        {
            ortaucakmotor = 1;

        }


        if (other.tag == "craftkanat")
        {
            ortakanat = 1;
        }
        //
        if (other.tag == "craftkumas")
        {
            ortakumas = 1;

        }


        if (other.tag == "crafthasir")
        {
            ortahasir = 1;
        }


        if (other.tag == "craftbalonmotor")
        {
            ortabalonmotor = 1;
        }

        if (other.tag == "craftodun")
        {
            ortaodun = 1;

        }


        if (other.tag == "crafttas")
        {
            ortatas = 1;
        }


        if (other.tag == "craftkazma")
        {
            ortakazma = 1;
        }


        if (other.tag == "craftcubuk")
        {
            ortacubuk = 1;
        }

        if (other.tag == "craftip")
        {
            ortaip = 1;
        }


        if (other.tag == "craftmakara")
        {
            ortamakara = 1;
        }


        if (other.tag == "craftkalas")
        {
            ortakalas = 1;
        }

    }

    public void craftbutton()
    {
       
        if (ortagovde == 1 && ortapervane == 1 && ortakanat== 1 && ortaucakmotor == 1 && ortaucaktekerlek== 1)
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int i = 0; i < 1; i++)
            {
               
                GameObject newButtons = Instantiate(craftbuttons[i], content.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0).transform);

            }
        }
        if (ortahasir == 1 && ortakumas== 1 && ortabalonmotor== 1)
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int i = 0; i < 1; i++)
            {

                GameObject newButtons = Instantiate(craftbuttons[0], content.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0).transform);

            }
        }
        if (ortaip == 1 && ortakalas== 1&& ortamakara== 1&&ortacubuk==0&&ortatas==0&&ortaodun==0&&ortakazma==0)
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int i = 0; i <1; i++)
            {
               
                GameObject newButtons = Instantiate(craftbuttons[4], content.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0).transform);

            }
        }
        if (ortacubuk==1&&ortatas==1&&ortaodun==0&&ortakazma==0)
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int i = 0; i <= 1; i++)
            {
               
                GameObject newButtons = Instantiate(craftbuttons[i], content.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0).transform);

            }
        }
        if (ortakazma == 1 && ortatas == 1 && ortacubuk==0&&ortaodun==0)
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            GameObject newButtons = Instantiate(craftbuttons[2], content.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0));


        }
        if (ortaodun == 1 && ortatas == 1&& ortacubuk==0&& ortakazma==0)
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            for (int j = 0; j < content.GetChild(0).GetChild(0).GetChild(0).childCount; j++)
            {
                Destroy(content.GetChild(0).GetChild(0).GetChild(0).GetChild(j).gameObject);
            }
            GameObject newButtons = Instantiate(craftbuttons[3], content.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.GetChild(0).GetChild(0).GetChild(0));
            

        }
     
     
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "craftpervane")
        {
            ortapervane = 0;

        }


        if (other.tag == "craftgovde")
        {
            ortagovde = 0;
        }


        if (other.tag == "craftucaktekerlek")
        {
            ortaucaktekerlek = 0;
        }

        if (other.tag == "craftucakmotor")
        {
            ortaucakmotor = 0;

        }


        if (other.tag == "craftkanat")
        {
            ortakanat = 0;
        }
        if (other.tag == "craftodun")
        {
            ortaodun = 0;

        }
        if (other.tag == "craftkumas")
        {
            ortakumas = 0;

        }


        if (other.tag == "crafthasir")
        {
            ortahasir = 0;
        }


        if (other.tag == "craftbalonmotor")
        {
            ortabalonmotor = 0;
        }

        if (other.tag == "crafttas")
        {
            ortatas = 0;
        }
       

        if (other.tag == "craftkazma")
        {
            ortakazma = 0;
        }
       

        if (other.tag == "craftcubuk")
        {
            ortacubuk = 0;
        }

        if (other.tag == "craftip")
        {
            ortaip = 0;
        }


        if (other.tag == "craftmakara")
        {
            ortamakara = 0;
        }


        if (other.tag == "craftkalas")
        {
            ortakalas = 0;
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        if (ortaodun==0&& ortatas==0&& ortakazma==0&& ortacubuk==0&&ortaip==0 && ortakalas == 0 && ortamakara == 0 && ortakumas == 0 && ortabalonmotor == 0 && ortahasir == 0/**/&& ortaucaktekerlek == 0 && ortaucakmotor== 0 && ortapervane== 0 && ortakanat == 0 && ortagovde== 0)
        {
            craftbut.SetActive(false);
        }
        else if (ortaodun == 1 || ortatas == 1 || ortakazma == 1 || ortacubuk == 1 || ortaip == 1 || ortakalas == 1 || ortamakara == 1 || ortakumas == 1 || ortabalonmotor == 1 || ortahasir == 1 || ortaucaktekerlek == 1 || ortaucakmotor == 1 || ortapervane == 1 || ortakanat == 1 || ortagovde == 1)
        {
            craftbut.SetActive(true);
        }
        
        if (player.GetComponent<characterproperty>().cameracraftanim == false)
        {

            ortaodun = 0;
            ortatas = 0;
            ortakazma = 0;
            ortacubuk = 0;
             ortamakara = 0;
            ortakalas =0;
            ortakumas = 0;
            ortabalonmotor = 0;
            ortahasir = 0;
            ortaip = 0;
            ortaucaktekerlek= 0;
            ortaucakmotor = 0;
            ortapervane = 0;
            ortakanat = 0;
            ortagovde = 0;
            
            content.gameObject.SetActive(false);
        }
        for (int i = 0; i < craftingtable.transform.childCount; i++)
        {
            if (craftingtable.transform.GetChild(i).name=="craftodun"&&player.GetComponent<Envanter>().odun<=0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "crafttas" && player.GetComponent<Envanter>().tas <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftcubuk" && player.GetComponent<Envanter>().cubuk <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftkazma" && player.GetComponent<Envanter>().kazma <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftbalta" && player.GetComponent<Envanter>().balta <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "crafttekerlek" && player.GetComponent<Envanter>().tekerlek <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftvinc" && player.GetComponent<Envanter>().vinc <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftkalas" && player.GetComponent<Envanter>().kalas <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftmakara" && player.GetComponent<Envanter>().makara<= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftip" && player.GetComponent<Envanter>().ip <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftvinc" && player.GetComponent<Envanter>().vinc <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }

            else if (craftingtable.transform.GetChild(i).name == "craftkumas" && player.GetComponent<Envanter>().kumas <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftbalonmotor" && player.GetComponent<Envanter>().balonmotor <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftbalon" && player.GetComponent<Envanter>().balon <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "crafthasir" && player.GetComponent<Envanter>().hasir <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
          
            else if (craftingtable.transform.GetChild(i).name == "craftpervane" && player.GetComponent<Envanter>().pervane <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }

            else if (craftingtable.transform.GetChild(i).name == "craftgovde" && player.GetComponent<Envanter>().govde <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftucaktekerlek" && player.GetComponent<Envanter>().ucaktekerlek <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftucakmotor" && player.GetComponent<Envanter>().ucakmotor <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
            else if (craftingtable.transform.GetChild(i).name == "craftkanat" && player.GetComponent<Envanter>().kanat <= 0)
            {
                Destroy(craftingtable.transform.GetChild(i).gameObject);
            }
        }
    }
}
