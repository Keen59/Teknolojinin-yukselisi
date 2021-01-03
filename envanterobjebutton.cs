using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class envanterobjebutton : MonoBehaviour
{
    GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        gameobject = GameObject.FindGameObjectWithTag("Player");
    }
    public void clickedobje()
    {
        if (gameobject.GetComponent<Envanter>().balta >= 1 && transform.name=="baltaslot")
        {
            gameobject.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            GameObject.Find("Canvas1").transform.GetChild(5).GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite = gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
            gameobject.GetComponent<characterproperty>().baltaeq = true;
            gameobject.GetComponent<characterproperty>().kazmaeq = false;
            gameobject.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
         }

        if (gameobject.GetComponent<Envanter>().kazma>= 1 && transform.name == "kazmaslot")
        {
            GameObject.Find("Canvas1").transform.GetChild(5).GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite = gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
            gameobject.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
            gameobject.GetComponent<characterproperty>().kazmaeq = true;
            gameobject.GetComponent<characterproperty>().baltaeq = false;
            gameobject.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
