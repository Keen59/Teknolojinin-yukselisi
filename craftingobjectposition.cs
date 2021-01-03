using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craftingobjectposition : MonoBehaviour
{

    float maxX= 4.3f, minX= -4.747f, maxY=9, minY= 5.385f, maxZ= 2.88f, minZ= -3.18f;
    
    Vector3 posmos;
 
    Vector3 fisrtpos;
     
        public GameObject content;
    public GameObject content2;


    GameObject oduns;
    GameObject odunsorta;


    GameObject craftintablem;
    public GameObject abb;
   public GameObject[] craftintablesobject =new GameObject[50];
     GameObject craftcanvas;
    public GameObject[] crafterbuttons;
    void Start()
    {

        craftintablem = GameObject.Find("craftingtable");
       

        for (int i = 0; i < craftintablem.transform.childCount; i++)
        {
            craftintablesobject[i] = craftintablem.transform.GetChild(i).gameObject;
            if (craftintablesobject[i].name=="oduns")
            {
                oduns = craftintablesobject[i];
            }
            else if (craftintablesobject[i].name == "odunsorta")
            {
                odunsorta = craftintablesobject[i];
            }
        
        }
        
        GameObject[] a= Resources.FindObjectsOfTypeAll<GameObject>();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].name=="craftlist")
            {
                content = a[i];

            }
            if (a[i].name == "Content2")
            {
                content2 = a[i];

            }
        }

       // content = craftintablem.GetComponent<craftingtable>().content.gameObject;
        craftcanvas = GameObject.FindGameObjectWithTag("craftcanvas");
        control = false;
    }
    bool control;
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag=="crafttermerkez")
    //    {
    //        control = true;
    //    }  
        
    //}
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "crafttermerkez")
    //    {
    //        control = false;
    //    }
    //}
    void OnMouseExit()
    {
        
        content.gameObject.SetActive(false);

        for (int i = 0; i < content2.transform.childCount; i++)
        {
           
            Destroy(content2.transform.GetChild(i).gameObject);
        }
       
     
    }
    void OnMouseEnter()
    {
    
        for (int i = 0; i < content2.transform.childCount; i++)
        {

            Destroy(content2.transform.GetChild(i).gameObject);

        }
        if (transform.name == "craftgovde")
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));

        }
        if (transform.name == "craftkanat")
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));

        }
      
        if (transform.name == "craftpervane")
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));

        }
        if (transform.name == "craftucakmotor")
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));

        }
        if (transform.name == "craftucaktekerlek")
        {

            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
            newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));

        }
        if (transform.name == "craftodun" )
        {
          
          craftcanvas.SetActive(true);
          content.gameObject.SetActive(true);
          GameObject newButtons = Instantiate(crafterbuttons[0], content.transform.GetChild(0).GetChild(0).GetChild(0));
          newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
          
        }
        if (transform.name == "crafttas" )
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
    
        }
        if (transform.name == "craftcubuk") 
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftmakara")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftkalas")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftip")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftkazma" )
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftbalta" )
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "crafttekerlek") 
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftcampfire" )
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }

        if (transform.name == "craftkumas")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "crafthasir")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }
        if (transform.name == "craftbalonmotor")
        {
            craftcanvas.SetActive(true);
            content.gameObject.SetActive(true);
            for (int i = 0; i < crafterbuttons.Length; i++)
            {
                GameObject newButtons = Instantiate(crafterbuttons[i], content.transform.GetChild(0).GetChild(0).GetChild(0));
                newButtons.transform.SetParent(content.transform.GetChild(0).GetChild(0).GetChild(0));
            }
        }

    }
    void OnMouseDown()
    {
        if (transform.name == "craftodun" )
        {
            if (transform.parent.name=="oduns")
            {
                
                   
                        transform.SetParent(odunsorta.transform);
                        transform.localPosition = new Vector3(0,0,0);
                        
              
               
            }
            else if (transform.parent.name == "odunsorta")
            {
               
                        transform.SetParent(oduns.transform);
                        transform.localPosition = new Vector3(0, 0, 0);

               
            }
        }
       
        //if (transform.name == "crafttas" && craftintablesobject[i] != null && craftintablesobject[i].name == "tass" && transform.position == craftintablesobject[i].transform.position)
        //{
        //    transform.position = craftintablem.transform.Find("tassorta").position;
        //}
        //if (transform.name == "craftcubuk" && craftintablesobject[i] != null && craftintablesobject[i].name == "cubuks" && transform.position == craftintablesobject[i].transform.position)
        //{
        //    transform.position = craftintablem.transform.Find("cubuksorta").position; 
        //}
        //if (transform.name == "craftkazma" && craftintablesobject[i] != null && craftintablesobject[i].name == "kazmas" && transform.position == craftintablesobject[i].transform.position)
        //{
        //    transform.position = craftintablem.transform.Find("kazmasorta").position;

        //}
        //if (transform.name == "craftmakara" && craftintablesobject[i] != null && craftintablesobject[i].name == "makaras" && transform.position == craftintablesobject[i].transform.position)
        //{
        //    transform.position = craftintablem.transform.Find("makaraorta").position;

        //}
        //if (transform.name == "craftkalas" && craftintablesobject[i] != null && craftintablesobject[i].name == "kalass" && transform.position == craftintablesobject[i].transform.position)
        //{
        //    transform.position = craftintablem.transform.Find("kalasorta").position;

        //}
        //if (transform.name == "craftip" && craftintablesobject[i] != null && craftintablesobject[i].name == "ips" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("iporta").position;

        //     }

        //if (transform.name == "craftkumas" && craftintablesobject[i] != null && craftintablesobject[i].name == "kumass" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("kumassorta").position;

        //}
        //if (transform.name == "crafthasir" && craftintablesobject[i] !=null &&craftintablesobject[i].name == "hasirs" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("hasirsorta").position;

        //}
        //if (transform.name == "craftbalonmotor" && craftintablesobject[i] != null && craftintablesobject[i].name == "balonmotors" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("balonmotorsorta").position;

        //}

        ///**//*////*/
        //if (transform.name == "craftpervane" && craftintablesobject[i] != null && craftintablesobject[i].name == "pervanes" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("pervaneortas").position;

        //}
        //if (transform.name == "craftucakmotor" && craftintablesobject[i] != null && craftintablesobject[i].name == "ucakmotors" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("ucakmotorortas").position;

        //}

        //if (transform.name == "craftucaktekerlek" && craftintablesobject[i] != null && craftintablesobject[i].name == "ucaktekerleks" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("ucaktekerlekortas").position;

        //}
        //if (transform.name == "craftkanat" && craftintablesobject[i] != null && craftintablesobject[i].name == "kanats" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("kanatortas").position;

        //}
        //if (transform.name == "craftgovde" && craftintablesobject[i] != null && craftintablesobject[i].name == "govdes" && transform.position == craftintablesobject[i].transform.position)
        //    {
        //    transform.position = craftintablem.transform.Find("govdeortas").position;

        //}
    }

    void objectposition()
    {
        if (control == false)
        {
           

        }
        else
        {

      

            //if (transform.name == "craftodun" && craftintablesobject[i] != null && craftintablesobject[i].name == "oduns" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    Debug.Log("uuuuuuuuuuuu");
            //    transform.position = craftintablem.transform.Find("oduns").position;
            //    control = false;
            //}
            //if (transform.name == "crafttas" && craftintablesobject[i] != null && craftintablesobject[i].name == "tass" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("tass").position;
            //    control = false;
            //}
            //if (transform.name == "craftcubuk" && craftintablesobject[i] != null && craftintablesobject[i].name == "cubuks" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("cubuks").position;

            //    control = false;

            //}
            //if (transform.name == "craftkazma" && craftintablesobject[i] != null && craftintablesobject[i].name == "kazmas" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("kazmas").position;

            //    control = false;
            //}
            //if (transform.name == "craftbalta" && craftintablesobject[i] != null && craftintablesobject[i].name == "baltas" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("baltas").position;
            //    control = false;
            //}
            //if (transform.name == "crafttekerlek" && craftintablesobject[i] != null && craftintablesobject[i].name == "tekerleks" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("tekerleks").position;
            //    control = false;
            //}
            //if (transform.name == "craftcampfire" && craftintablesobject[i] != null && craftintablesobject[i].name == "camfires" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("camfires").position;
            //    control = false;
            //}
            //if (transform.name == "craftmakara" && craftintablesobject[i] != null && craftintablesobject[i].name == "makaras" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("makaras").position;
            //    control = false;
            //}
            //if (transform.name == "craftkalas" && craftintablesobject[i] != null && craftintablesobject[i].name == "kalass" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("kalass").position;
            //    control = false;
            //}
            //if (transform.name == "craftip" && craftintablesobject[i] != null && craftintablesobject[i].name == "ips" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("ips").position;

            //    control = false;
            //}

            //if (transform.name == "craftkumas" && craftintablesobject[i] != null && craftintablesobject[i].name == "kumass" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("kumass").position;
            //    control = false;
            //}
            //if (transform.name == "crafthasir" && craftintablesobject[i] != null && craftintablesobject[i].name == "hasirs" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("hasirs").position;
            //    control = false;
            //}
            //if (transform.name == "craftbalonmotor" && craftintablesobject[i] != null && craftintablesobject[i].name == "balonmotors" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("balonmotors").position;

            //    control = false;
            //}
            ////
            //if (transform.name == "craftpervane" && craftintablesobject[i] != null && craftintablesobject[i].name == "pervanes" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("pervanes").position;
            //    control = false;
            //}
            //if (transform.name == "craftucakmotor" && craftintablesobject[i] != null && craftintablesobject[i].name == "ucakmotors" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("ucakmotors").position;
            //    control = false;
            //}

            //if (transform.name == "craftucaktekerlek" && craftintablesobject[i] != null && craftintablesobject[i].name == "ucaktekerleks" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("ucaktekerleks").position;
            //    control = false;
            //}
            //if (transform.name == "craftkanat" && craftintablesobject[i] != null && craftintablesobject[i].name == "kanats" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("kanats").position;
            //    control = false;
            //}
            //if (transform.name == "craftgovde" && craftintablesobject[i] != null && craftintablesobject[i].name == "govdes" && transform.position != craftintablesobject[i].transform.position)
            //{
            //    transform.position = craftintablem.transform.Find("govdes").position;
            //    control = false;
            //}

        }


    }
    void Update()
    {
        objectposition();  
    }
}
