using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Envanter : MonoBehaviour
{
    public GameObject[] envanterslots=new GameObject[50];
    public GameObject envanterslot;

    public Sprite[] esyaglobal;
    public GameObject envanterobject;

    bool tutorial = false;
    public int odun;
    public int tas;

    public int cubuk;
    public int vinc;
    public int kazma;
    public int tekerlek;
    public int balta;
    public int campfire;
    public int demir;
    public int makara;
    public int ip;
    public int kalas;
    public int balonmotor;
    public int kumas;
    public int hasir;
    public int balon;

    public int kanat;
    public int ucaktekerlek;
    public int govde;
    public int ucakmotor;
    public int pervane;
    public int ucak;
    void Start()
    {
        
    }
    //envanterin açılıp kapanmasını sağlama
    
    //envanterin içeriğini kontrol etme
    void envanter()
    {


        if (pervane >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("pervaneslot") == null && esyaglobal[j].name == "pervane")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "pervaneslot";
                        }
                    }

                }

            }


        }

        if (ucak >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("ucakslot") == null && esyaglobal[j].name == "ucak")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "ucakslot";
                        }
                    }

                }

            }


        }

        if (ucakmotor >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("ucakmotorslot") == null && esyaglobal[j].name == "motor")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "ucakmotorslot";
                        }
                    }

                }

            }


        }
        if (govde >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("govdeslot") == null && esyaglobal[j].name == "govde")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "govdeslot";
                        }
                    }

                }

            }


        }
        if (kanat >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("kanatslot") == null && esyaglobal[j].name == "kanat")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "kanatslot";
                        }
                    }

                }

            }


        }
        if (ucaktekerlek >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("ucaktekerlekslot") == null && esyaglobal[j].name == "ucaktekerlek")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "ucaktekerlekslot";
                        }
                    }

                }

            }


        }

        if (kalas >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("kalasslot") == null && esyaglobal[j].name == "kalas")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "kalasslot";
                        }
                    }

                }

            }


        }
        if (balon >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("balonslot") == null && esyaglobal[j].name == "ucanbalon")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "balonslot";
                        }
                    }

                }

            }


        }
        if (kumas >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("kumasslot") == null && esyaglobal[j].name == "kumas")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "kumasslot";
                        }
                    }

                }

            }
        }
        if (hasir >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("hasirslot") == null && esyaglobal[j].name == "hasir")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "hasirslot";
                        }
                    }

                }

            }
        }
        if (balonmotor >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("balonmotorslot") == null && esyaglobal[j].name == "motor")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "balonmotorslot";
                        }
                    }

                }

            }
        }
        if (vinc >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("vincslot") == null && esyaglobal[j].name == "vinc")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "vincslot";
                        }
                    }

                }

            }


        }
        if (ip >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("ipslot") == null && esyaglobal[j].name == "ip")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "ipslot";
                        }
                    }

                }

            }


        }

        if (makara >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("makaraslot") == null && esyaglobal[j].name == "makara")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "makaraslot";
                        }
                    }

                }

            }


        }

        if (demir >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("demirslot") == null && esyaglobal[j].name == "demir")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "demirslot";
                        }
                    }

                }

            }


        }
        if (odun>=1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i]==null)
                {
                    for (int j = 0; j < esyaglobal.Length;  j++)
                    {
                        if (envanterobject.transform.Find("odunslot")==null&&esyaglobal[j].name=="odun")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "odunslot";
                        }
                    }
                    
                }

            }
           

        }
        if (tas >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("tasslot") == null && esyaglobal[j].name == "tas")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "tasslot";
                        }
                    }

                }

            }

        }
        if (cubuk >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("cubukslot") == null && esyaglobal[j].name == "cubuk")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "cubukslot";
                        }
                    }

                }

            }

        }
        if (balta >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("baltaslot") == null && esyaglobal[j].name == "balta")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "baltaslot";
                        }
                    }

                }

            }

        }
        
        if (kazma >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("kazmaslot") == null && esyaglobal[j].name == "kazma")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "kazmaslot";
                        }
                    }

                }

            }

        }
        if (tekerlek >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("tekerlekslot") == null && esyaglobal[j].name == "tekerlek")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "tekerlekslot";
                        }
                    }

                }

            }

        }
        if (campfire >= 1)
        {
            for (int i = 0; i < envanterslots.Length; i++)
            {

                if (envanterslots[i] == null)
                {
                    for (int j = 0; j < esyaglobal.Length; j++)
                    {
                        if (envanterobject.transform.Find("campfireslot") == null && esyaglobal[j].name == "campfiree")
                        {
                            envanterslots[i] = Instantiate(envanterslot, envanterobject.transform);
                            envanterslots[i].transform.GetChild(0).transform.GetComponent<Image>().sprite = esyaglobal[j];
                            envanterslots[i].transform.SetParent(envanterobject.transform);
                            envanterslots[i].name = "campfireslot";
                        }
                    }

                }

            }

        }
    }
    void Env_obje_say()
    {

        for (int i = 0; i < envanterslots.Length; i++)
        {
            if (envanterslots[i]!=null)
            {

           
            if (envanterslots[i].transform.name=="odunslot")
            {
                envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = odun.ToString();
            }
            if (envanterslots[i].transform.name == "tasslot")
            {
                envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = tas.ToString();
            }
            if (envanterslots[i].transform.name == "cubukslot")
            {
                envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = cubuk.ToString();
            }
                if (envanterslots[i].transform.name == "baltaslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = balta.ToString();
                }
                if (envanterslots[i].transform.name == "kazmaslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = kazma.ToString();
                }
                if (envanterslots[i].transform.name == "campfireslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = campfire.ToString();
                }
                if (envanterslots[i].transform.name == "tekerlekslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = tekerlek.ToString();
                }
                if (envanterslots[i].transform.name == "demirslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = demir.ToString();
                }
                if (envanterslots[i].transform.name == "ipslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = ip.ToString();
                }
                if (envanterslots[i].transform.name == "kalasslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = kalas.ToString();
                }
                if (envanterslots[i].transform.name == "makaraslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = makara.ToString();
                }
                if (envanterslots[i].transform.name == "hasirslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = hasir.ToString();
                }
                if (envanterslots[i].transform.name == "balonmotorslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = balonmotor.ToString();
                }
                if (envanterslots[i].transform.name == "kumasslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = kumas.ToString();
                }
                if (envanterslots[i].transform.name == "balonslot")
                {
                    envanterslots[i].transform.GetChild(1).GetComponent<Text>().text = balon.ToString();
                }


            }
        }

    }
    void nesne_yoksa()
    {
        for (int i = 0; i < envanterslots.Length; i++)
        {
            if (envanterslots[i] != null)
            {
                if (odun == 0 && envanterslots[i].name == "odunslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (cubuk == 0 && envanterslots[i].name == "cubukslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (kazma == 0 && envanterslots[i].name == "kazmaslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (balta == 0 && envanterslots[i].name == "baltaslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (demir == 0 && envanterslots[i].name == "demirslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (ip == 0 && envanterslots[i].name == "ipslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (kalas == 0 && envanterslots[i].name == "kalasslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (makara == 0 && envanterslots[i].name == "makaraslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (hasir == 0 && envanterslots[i].name == "hasirslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (kumas == 0 && envanterslots[i].name == "kumasslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (balonmotor == 0 && envanterslots[i].name == "balonmotorslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }


                if (govde == 0 && envanterslots[i].name == "govdeslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (kanat == 0 && envanterslots[i].name == "kanatslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (ucaktekerlek == 0 && envanterslots[i].name == "ucaktekerlekslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (ucakmotor == 0 && envanterslots[i].name == "ucakmotorslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
                if (pervane == 0 && envanterslots[i].name == "pervaneslot")
                {
                    Destroy(envanterslots[i].gameObject);
                }
            }
        }


    }
   
    void Update()
    {

        nesne_yoksa();
        envanter();
        Env_obje_say();
    }
}
