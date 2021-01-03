using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameobjectlook : MonoBehaviour
{
    public GameObject goster;
    public GameObject gosterparent;
    GameObject envanter;

    // Start is called before the first frame update
    void Start()
    {
        envanter = transform.parent.gameObject;
    }
    void OnTriggerStay(Collider other)
    {
      

        if (other.tag == "odun"|| other.tag == "kalas"|| other.tag == "demirkirik"|| other.tag == "kiriktas"|| other.tag == "cubuk"|| other.tag == "ip"||other.tag == "makara"|| other.tag == "balonmotor" || other.tag == "hasir" || other.tag == "kumas"|| other.tag == "govde" || other.tag == "kanat" || other.tag == "ucakmotor" || other.tag == "pervane" || other.tag == "ucaktekerlek")
        {
            if (other.transform.position!=transform.position)
            {
                other.transform.position = Vector3.MoveTowards(other.transform.position, transform.position, 15 * Time.deltaTime);
                Destroy(other.gameObject,1);
            }
            


        }
       
    
    }

  
    void OnTriggerEnter(Collider other)
    {
        /*|| other.tag == "kanat" || other.tag == "ucakmotor" || other.tag == "pervane" || other.tag == "ucaktekerlek")*/
        if (other.tag == "govde")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Uçak gövdesi envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().govde++;
        }
        if (other.tag == "ucaktekerlek")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Uçak tekerleği envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().ucaktekerlek++;
        }
        if (other.tag == "pervane")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 pervane envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().pervane++;
        }
        if (other.tag == "ucakmotor")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Uçak motoru envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().ucakmotor++;
        }
        if (other.tag == "kanat")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Kanat envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().kanat++;
        }
        if (other.tag == "balonmotor")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Balon motoru envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().balonmotor++;
        }
        if (other.tag == "hasir")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 hasır envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().hasir++;
        }
        if (other.tag == "kumas")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 kumas envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().kumas++;
        }
        if (other.tag == "demirkirik")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Demir envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().demir++;
        }
        if (other.tag == "odun")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Odun envantere eklendi";
            b.transform.SetParent(gosterparent.transform);
            
            envanter.GetComponent<Envanter>().odun++;
        }
        if (other.tag == "kiriktas")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 Taş envantere eklendi";
            b.transform.SetParent(gosterparent.transform);
       
            envanter.GetComponent<Envanter>().tas++;
        }
        if (other.tag == "cubuk")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 cubuk envantere eklendi";
            b.transform.SetParent(gosterparent.transform);
          
            envanter.GetComponent<Envanter>().cubuk++;
        }
        if (other.tag == "kalas")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 kalas envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().kalas++;
        }
        if (other.tag == "ip")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 ip envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().ip++;
        }
        if (other.tag == "makara")
        {
            GameObject b = Instantiate(goster, gosterparent.transform.position, Quaternion.identity);
            b.GetComponent<Text>().text = "+1 makara envantere eklendi";
            b.transform.SetParent(gosterparent.transform);

            envanter.GetComponent<Envanter>().makara++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
