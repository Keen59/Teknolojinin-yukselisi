using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftscript : MonoBehaviour
{
    GameObject craftingtable1;
    public GameObject[] craftedgamesobjects;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        craftingtable1 = GameObject.Find("craftingtable");

    }

    public void crafter()
    {

        if (transform.name == "balta(Clone)")
        {
            if (player.GetComponent<Envanter>().cubuk >= 1 && player.GetComponent<Envanter>().tas >= 1)
            {
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().cubuk--;
                player.GetComponent<Envanter>().tas--;
                player.GetComponent<Envanter>().balta++;

                Destroy(gameObject);
 

            }
        }
        else if (transform.name == "kazma(Clone)")
        {
            if (player.GetComponent<Envanter>().cubuk >= 1 && player.GetComponent<Envanter>().tas >= 1)
            {
                player.GetComponent<Envanter>().kazma++;
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().cubuk--;
                player.GetComponent<Envanter>().tas--;
             
           
     
                Destroy(gameObject);
              
            }
        }
        else if (transform.name == "Ucanbalon(Clone)")
        {
            if (player.GetComponent<Envanter>().cubuk >= 1 && player.GetComponent<Envanter>().tas >= 1)
            {
                player.GetComponent<Envanter>().kazma++;
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().cubuk--;
                player.GetComponent<Envanter>().tas--;



                Destroy(gameObject);

            }
        }
        else if (transform.name == "tekerlek(Clone)")
        {
            if (player.GetComponent<Envanter>().kazma >= 1 && player.GetComponent<Envanter>().tas >= 10)
            {


                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);

                player.GetComponent<Envanter>().tas-=10;

                player.GetComponent<Envanter>().tekerlek++;
                Destroy(gameObject);
  
            }
        }
        else if (transform.name == "Kampatesi(Clone)")
        {
            if (player.GetComponent<Envanter>().odun >= 10 && player.GetComponent<Envanter>().tas >= 2)
            {
                player.GetComponent<Envanter>().campfire++;

                player.GetComponent<Envanter>().odun-=10;
                player.GetComponent<Envanter>().tas-=2;


                Destroy(gameObject);
               
            }
        }
        else if (transform.name == "Vinc(Clone)")
        {
            if (player.GetComponent<Envanter>().makara >= 1 && player.GetComponent<Envanter>().ip>= 3 && player.GetComponent<Envanter>().kalas >= 4)
            {
                player.GetComponent<Envanter>().vinc++;
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().makara -= 1;
                player.GetComponent<Envanter>().ip -=3;
                player.GetComponent<Envanter>().kalas -=4;

                Destroy(gameObject);

            }
        }
        else if (transform.name == "Balon(Clone)")
        {
            if (player.GetComponent<Envanter>().kumas >= 4 && player.GetComponent<Envanter>().hasir >= 10 && player.GetComponent<Envanter>().balonmotor >= 1)
            {
                player.GetComponent<Envanter>().balon++;
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().kumas -= 4;
                player.GetComponent<Envanter>().hasir -= 10;
                player.GetComponent<Envanter>().balonmotor-= 1;

                Destroy(gameObject);

            }
        }
        else if (transform.name == "Ucak(Clone)")
        {
            if (player.GetComponent<Envanter>().ucakmotor >= 1 && player.GetComponent<Envanter>().ucaktekerlek>= 1 && player.GetComponent<Envanter>().govde>= 1 && player.GetComponent<Envanter>().kanat >= 1 && player.GetComponent<Envanter>().pervane >= 1)
            {
                player.GetComponent<Envanter>().ucak++;
                craftingtable1.transform.Find("craft").GetChild(0).GetChild(0).gameObject.SetActive(false);

                craftingtable1.transform.Find("craft").GetChild(0).GetChild(1).gameObject.SetActive(false);
                player.GetComponent<Envanter>().pervane -= 1;
                player.GetComponent<Envanter>().kanat-= 1;
                player.GetComponent<Envanter>().ucakmotor -= 1;
                player.GetComponent<Envanter>().ucaktekerlek-= 1;
                player.GetComponent<Envanter>().govde-= 1;

                Destroy(gameObject);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
