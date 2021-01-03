using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craftingtable : MonoBehaviour
{
    public GameObject[] forcrafting;




    // Start is called before the first frame update
    void Start()
    {
    
        gameobject = GameObject.FindGameObjectWithTag("Player");

    }
    GameObject gameobject;


    public void craftsystem()
    {
        if (gameobject.GetComponent<characterproperty>().cameracraftanim == true)
        {


            for (int i = 0; i < gameobject.GetComponent<Envanter>().envanterslots.Length; i++)
            {
                if (gameobject.GetComponent<Envanter>().envanterslots[i]!=null)
                {
                    if (gameobject.GetComponent<Envanter>().envanterslots[i].name=="odunslot"&&transform.Find("oduns").Find("craftodun") == null&& transform.Find("odunsorta").Find("craftodun") == null)
                    {
                        GameObject child = Instantiate(forcrafting[0],gameObject.transform.Find("oduns").position, Quaternion.identity);
                
                        child.transform.SetParent(gameObject.transform.Find("oduns").transform);
                        child.transform.localScale = new Vector3(1,1,1);
                        child.name = "craftodun";
                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "tasslot" && transform.Find("crafttas") == null)
                    {

                        GameObject child = Instantiate(forcrafting[1], transform.Find("tass").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("tass").localScale;
                        child.name = "crafttas";
                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "cubukslot" && transform.Find("craftcubuk") == null)
                    {

                        GameObject child = Instantiate(forcrafting[2], gameObject.transform.Find("cubuks").position, Quaternion.Euler(0, 43, -90));
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("cubuks").localScale;
                        child.name = "craftcubuk";
                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "kazmaslot" && transform.Find("craftkazma") == null)
                    {

                        GameObject child = Instantiate(forcrafting[4], gameObject.transform.Find("kazmas").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("kazmas").localScale;
                        child.transform.rotation = gameObject.transform.Find("kazmas").rotation;
                        child.name = "craftkazma";
                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "baltaslot" && transform.Find("craftbalta") == null)
                    {

                        GameObject child = Instantiate(forcrafting[3], GameObject.Find("craftingtable").transform.Find("baltas").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("baltas").localScale;
                        child.transform.rotation = gameObject.transform.Find("baltas").rotation;
                        child.name = "craftbalta";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "tekerlekslot" && transform.Find("crafttekerlek") == null)
                    {

                        GameObject child = Instantiate(forcrafting[5], gameObject.transform.Find("tekerleks").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("tekerleks").localScale;
                        child.transform.rotation = gameObject.transform.Find("tekerleks").rotation;
                        child.name = "crafttekerlek";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "campfireslot" && transform.Find("craftcampfire") == null)
                    {

                        GameObject child = Instantiate(forcrafting[6], gameObject.transform.Find("campfires").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("campfires").localScale;
                        child.name = "craftcampfire";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "ipslot" && transform.Find("craftip") == null)
                    {

                        GameObject child = Instantiate(forcrafting[5], gameObject.transform.Find("ips").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("ips").localScale;
                        child.name = "craftip";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "makaraslot" && transform.Find("craftmakara") == null)
                    {

                        GameObject child = Instantiate(forcrafting[6], gameObject.transform.Find("makaras").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("makaras").localScale;
                        child.name = "craftmakara";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "kalasslot" && transform.Find("craftkalas") == null)
                    {

                        GameObject child = Instantiate(forcrafting[7], gameObject.transform.Find("kalass").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("kalass").localScale;
                        child.transform.rotation = gameObject.transform.Find("kalass").rotation;
                        child.name = "craftkalas";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "vincslot" && transform.Find("craftvinc") == null)
                    {

                        GameObject child = Instantiate(forcrafting[8], gameObject.transform.Find("vinc").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("vinc").localScale;
                        child.name = "craftvinc";

                    }

                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "hasirslot" && transform.Find("crafthasir") == null)
                    {

                        GameObject child = Instantiate(forcrafting[0], gameObject.transform.Find("hasirs").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("hasirs").localScale;
                        child.transform.rotation= gameObject.transform.Find("hasirs").rotation;
                        child.name = "crafthasir";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "balonslot" && transform.Find("craftbalon") == null)
                    {

                        GameObject child = Instantiate(forcrafting[3], gameObject.transform.Find("balons").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = GameObject.Find("craftingtable").transform.Find("balons").localScale;
                        child.transform.rotation = GameObject.Find("craftingtable").transform.Find("balons").rotation;
                        child.name = "craftbalon";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "kumasslot" && transform.Find("craftkumas") == null)
                    {

                        GameObject child = Instantiate(forcrafting[1], gameObject.transform.Find("kumass").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("kumass").localScale;
                        child.name = "craftkumas";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "balonmotorslot" && transform.Find("craftbalonmotor") == null)
                    {

                        GameObject child = Instantiate(forcrafting[2], gameObject.transform.Find("balonmotors").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = GameObject.Find("craftingtable").transform.Find("balonmotors").localScale;
                        child.name = "craftbalonmotor";

                    }/**/  ///*craftpervane/craftgovde/craftucaktekerlek/craftucakmotor/craftkanat*/
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "pervaneslot" && transform.Find("craftpervane") == null)
                    {

                        GameObject child = Instantiate(forcrafting[3], gameObject.transform.Find("pervanes").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("pervanes").localScale;
                        child.transform.rotation = gameObject.transform.Find("pervanes").rotation;
                        child.name = "craftpervane";

                    }

                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "govdeslot" && transform.Find("craftgovde") == null)
                    {

                        GameObject child = Instantiate(forcrafting[0], gameObject.transform.Find("govdes").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("govdes").localScale;
                        child.transform.rotation = gameObject.transform.Find("govdes").rotation;
                        child.name = "craftgovde";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "ucaktekerlekslot" && transform.Find("craftucaktekerlek") == null)
                    {

                        GameObject child = Instantiate(forcrafting[2], gameObject.transform.Find("ucaktekerleks").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("ucaktekerleks").localScale;
                        child.transform.rotation = gameObject.transform.Find("ucaktekerleks").rotation;
                        child.name = "craftucaktekerlek";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "ucakmotorslot" && transform.Find("craftucakmotor") == null)
                    {

                        GameObject child = Instantiate(forcrafting[4], GameObject.Find("craftingtable").transform.Find("ucakmotors").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("ucakmotors").localScale;
                        child.transform.rotation = gameObject.transform.Find("ucakmotors").rotation;
                        child.name = "craftucakmotor";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "kanatslot" && transform.Find("craftkanat") == null)
                    {

                        GameObject child = Instantiate(forcrafting[1], gameObject.transform.Find("kanats").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("kanats").localScale;
                        child.transform.rotation = gameObject.transform.Find("kanats").rotation;
                        child.name = "craftkanat";

                    }
                    else if (gameobject.GetComponent<Envanter>().envanterslots[i].name == "ucakslot" && transform.Find("craftucak") == null)
                    {

                        GameObject child = Instantiate(forcrafting[5], gameObject.transform.Find("ucaks").position, Quaternion.identity);
                        child.transform.SetParent(gameObject.transform);
                        child.transform.localScale = gameObject.transform.Find("ucaks").localScale;
                        child.transform.rotation = gameObject.transform.Find("ucaks").rotation;
                        child.name = "craftucak";

                    }
                }
            }
        }
        else
        {
            if (transform.Find("craftodun") != null)
            {
                Destroy(transform.Find("craftodun").gameObject);
            }
            else if ( transform.Find("crafttas") != null)
            {

                Destroy(transform.Find("crafttas").gameObject);
            }
            else if (transform.Find("craftcubuk") != null)
            {

                Destroy(transform.Find("craftcubuk").gameObject);
            }
            else if ( transform.Find("craftkazma") != null)
            {


                Destroy(transform.Find("craftkazma").gameObject);
            }
            else if (transform.Find("craftbalta") != null)
            {

                Destroy(transform.Find("craftbalta").gameObject);

            }
            else if (transform.Find("crafttekerlek") != null)
            {

                Destroy(transform.Find("crafttekerlek").gameObject);

            }
            else if (transform.Find("craftcampfire") != null)
            {

                      Destroy(transform.Find("craftcampfire").gameObject);
            }
            else if (transform.Find("craftbalta") != null)
            {

                Destroy(transform.Find("craftbalta").gameObject);

            }
            else if (transform.Find("crafttekerlek") != null)
            {

                Destroy(transform.Find("crafttekerlek").gameObject);

            }
            else if (transform.Find("craftcampfire") != null)
            {

                Destroy(transform.Find("craftcampfire").gameObject);
            }
            else if (transform.Find("craftmakara") != null)
            {

                Destroy(transform.Find("craftmakara").gameObject);

            }
            else if (transform.Find("craftip") != null)
            {

                Destroy(transform.Find("craftip").gameObject);

            }
            else if (transform.Find("craftkalas") != null)
            {

                Destroy(transform.Find("craftkalas").gameObject);
            }
            else if (transform.Find("craftvinc") != null)
            {

                Destroy(transform.Find("craftvinc").gameObject);
            }

            else if (transform.Find("craftkumas") != null)
            {

                Destroy(transform.Find("craftkumas").gameObject);

            }
            else if (transform.Find("craftbalonmotor") != null)
            {

                Destroy(transform.Find("craftbalonmotor").gameObject);

            }
            else if (transform.Find("crafthasir") != null)
            {

                Destroy(transform.Find("crafthasir").gameObject);
            }
            else if (transform.Find("craftbalon") != null)
            {

                Destroy(transform.Find("craftbalon").gameObject);
            }/**/
            else if (transform.Find("craftucaktekerlek") != null)
            {

                Destroy(transform.Find("craftucaktekerlek").gameObject);
            }

            else if (transform.Find("craftucakmotor") != null)
            {

                Destroy(transform.Find("craftucakmotor").gameObject);

            }
            else if (transform.Find("craftkanat") != null)
            {

                Destroy(transform.Find("craftkanat").gameObject);

            }
            else if (transform.Find("craftpervane") != null)
            {

                Destroy(transform.Find("craftpervane").gameObject);
            }
            else if (transform.Find("craftgovde") != null)
            {

                Destroy(transform.Find("craftgovde").gameObject);
            }
            else if (transform.Find("craftucak") != null)
            {

                Destroy(transform.Find("craftucak").gameObject);
            }
           
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        craftsystem();
    }
}
