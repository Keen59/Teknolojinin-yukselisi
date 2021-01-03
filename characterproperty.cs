using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class characterproperty : MonoBehaviour
{
    public Camera cam;
    public float interractDist = 20f;
    public GameObject agacefeckt;
    public GameObject odun;
    public GameObject cubuk;
    public AudioSource source;

    public AudioClip[] sesler;
    public GameObject tasdusen;
    public GameObject demirdusen;
    public GameObject digeragac;
    public GameObject digeragac2;
    GameObject[] alt = new GameObject[10];
    GameObject[] ust = new GameObject[10];
    Animator mapanim;
    Animator cameranim;
    Animator baltaanim;
    public bool kazmaeq;
    public bool baltaeq;
    Animator kazmaanim;
    GameObject gameobject;
    int agaccan;
    int tas;
    void Start()
    {
        kazmaeq = false;
        baltaeq = false;
        cameracraftanim = false;
        agaccan = 8;
        baltaanim = transform.GetChild(0).GetChild(1).GetComponent<Animator>();
        kazmaanim = transform.GetChild(0).GetChild(0).GetComponent<Animator>();
        tas = 8;
        gameobject = GameObject.FindGameObjectWithTag("GameController");
        salter = false;

    }
    bool salter;
    bool magarada;
    bool tapinakta;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "magarakapi")
        {
            if (magarada == false)
            {
                transform.position = new Vector3(10019.6f, 1.79f, 9948.7f);
                magarada = true;
            }
            else
            {
                transform.position = new Vector3(140.07f, 2.22f, 221.53f);
                magarada = false;
            }
        }
        if (other.gameObject.tag == "mayakapi")
        {
            if (tapinakta == false)
            {
                transform.position = new Vector3(9988.67f, -108.46f, 10052f);
                tapinakta = true;
            }
            else
            {
                transform.position = new Vector3(-298.9f, 50.46f, 104.27f);
                tapinakta = false;
            }
        }
        if (other.gameObject.tag == "questmarker")
        {
            GameObject.FindGameObjectWithTag("questanlatimi").GetComponent<history>().questmarker_ready = true;
            for (int i = 0; i < GameObject.FindGameObjectsWithTag(other.gameObject.tag).Length; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag(other.gameObject.tag)[i]);
            }

        }
    }

    bool yollasona=false;

    Vector3 refPos;
    float movementTime = 0.8f;
    float rotationSpeed = 3f;
    public bool cameracraftanim;
    float bekle;
    void Update()
    {
        if (yollasona==true)
        {
            bekle += Time.deltaTime;
            if (bekle>=4)
            {
                SceneManager.LoadScene("kazandin");
            }
        }
        if (cameracraftanim == true)
        {
            transform.GetChild(0).position = Vector3.SmoothDamp(transform.GetChild(0).position, GameObject.Find("GameObject2").transform.position, ref refPos, movementTime);
            transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, GameObject.Find("GameObject2").transform.rotation, rotationSpeed * Time.deltaTime);
            transform.GetComponent<RigidbodyFirstPersonController>().mouseLook.smoothTime = 0;
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            transform.GetComponent<RigidbodyFirstPersonController>().mouseLook.smoothTime = 18;
            transform.GetChild(0).position = Vector3.SmoothDamp(transform.GetChild(0).position, transform.GetChild(2).position, ref refPos, movementTime);
            transform.GetChild(0).transform.Rotate(GameObject.Find("craftingtable").transform.rotation.x, GameObject.Find("craftingtable").transform.rotation.z, GameObject.Find("craftingtable").transform.rotation.z);
            transform.GetChild(3).gameObject.SetActive(true);
        }

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            float mesafem = Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position);
            if (hit.collider.gameObject.tag == "craftingtable" && mesafem <= 5f)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (cameracraftanim == true)
                    {
                        gameobject.GetComponent<stopeverythin>().baslat();
                        cameracraftanim = false;
                    }
                    else
                    {
                        transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                        transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                        gameobject.GetComponent<stopeverythin>().durdur();
                        cameracraftanim = true;
                    }
                }
            }

            if (hit.collider.gameObject.tag == "bookorta" && mesafem <= 5f)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                }
            }
            if (hit.collider.gameObject.tag == "salter" && mesafem <= 5f)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                    salter = true;
                    hit.collider.gameObject.GetComponent<Animator>().SetTrigger("indir");
                    source.GetComponent<AudioSource>().clip = sesler[0];
                    Instantiate(source, hit.point, Quaternion.identity);
                }
            }
                if (hit.collider.gameObject.tag == "zamanmak" && mesafem <= 5f)
                {

                if (yollasona==false)
                {

              
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (salter == true && gameObject.GetComponent<Envanter>().ucak >= 1)
                        {
                            source.GetComponent<AudioSource>().clip = sesler[1];
                       Instantiate(source, hit.point, Quaternion.identity);
                            yollasona = true;
                              
                           
                           
                        }

                    }
                }
            }
                if (hit.collider.gameObject.tag == "agac" && mesafem <= 5f)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        source.GetComponent<AudioSource>().clip = sesler[1];
                        Instantiate(source, hit.point, Quaternion.identity);
                        if (baltaeq)
                        {
                            baltaanim.SetTrigger("vur");
                            if (hit.transform.GetComponent<treeheal>().can > 0)
                            {
                                hit.transform.GetComponent<treeheal>().can -= 2;
                            }
                        }
                        else
                        {
                            if (hit.transform.GetComponent<treeheal>().can > 0)
                            {
                                hit.transform.GetComponent<treeheal>().can--;
                            }
                        }
                        agacefeckt.GetComponent<ParticleSystem>().startColor = new Color32(90, 57, 30, 255);
                        Instantiate(agacefeckt, hit.point, Quaternion.identity);
                        if (hit.transform.GetComponent<treeheal>().can == 0)
                        {
                            if (hit.transform.gameObject.name == "agac2")
                            {
                                Transform ust = Instantiate(digeragac.transform.GetChild(1), hit.transform.position, Quaternion.identity);
                                Transform alt = Instantiate(digeragac.transform.GetChild(0), new Vector3(hit.transform.position.x, 1.08588f, hit.transform.position.z), Quaternion.identity);
                                alt.parent = ust;
                            }
                            else
                            {
                                Transform ust = Instantiate(digeragac2.transform.GetChild(0), new Vector3(hit.transform.position.x, 1.08588f, hit.transform.position.z), Quaternion.identity);
                                Transform alt = Instantiate(digeragac2.transform.GetChild(1), hit.transform.position, Quaternion.identity);
                                ust.parent = alt;
                            }
                            for (int i = 0; i < 3; i++)
                            {
                                Vector3 pos = new Vector3(hit.transform.position.x + Random.Range(0, 2), hit.transform.position.y, hit.transform.position.z + Random.Range(0, 2));
                                Instantiate(odun, pos, Quaternion.Euler(90, 0, 0));
                                Instantiate(cubuk, pos, Quaternion.Euler(90, 0, 0));

                            }
                            Destroy(hit.collider.gameObject);
                        }
                    }
                }

                if (Input.GetMouseButtonDown(0))
                {
                    if (baltaeq)
                    {
                        baltaanim.SetTrigger("vur");
                    }
                    else if (kazmaeq)
                    {
                        kazmaanim.SetTrigger("vur");
                    }
                }

                if (hit.collider.gameObject.tag == "demir" && mesafem <= 5f)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        source.GetComponent<AudioSource>().clip = sesler[2];
                        Instantiate(source, hit.point, Quaternion.identity);
                        if (kazmaeq && hit.transform.GetComponent<treeheal>().can > 0)
                        {

                            kazmaanim.SetTrigger("vur");
                            hit.transform.GetComponent<treeheal>().can -= 3;

                        }
                        else if (kazmaeq == false && hit.transform.GetComponent<treeheal>().can > 0)
                        {
                            hit.transform.GetComponent<treeheal>().can--;
                        }
                        agacefeckt.GetComponent<ParticleSystem>().startColor = new Color(118, 118, 118);
                        Instantiate(agacefeckt, hit.point, Quaternion.identity);
                        if (hit.transform.GetComponent<treeheal>().can <= 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Vector3 pos = new Vector3(hit.transform.position.x + Random.Range(0, 2), 0.5f, hit.transform.position.z + Random.Range(0, 2));
                                Instantiate(demirdusen, pos, Quaternion.Euler(90, 0, 0));
                            }
                            Destroy(hit.collider.gameObject);
                        }
                    }
                }


                if (hit.collider.gameObject.tag == "tas" && mesafem <= 5f)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        source.GetComponent<AudioSource>().clip = sesler[2];
                        Instantiate(source, hit.point, Quaternion.identity);
                        if (kazmaeq && hit.transform.GetComponent<treeheal>().can > 0)
                        {

                            kazmaanim.SetTrigger("vur");
                            hit.transform.GetComponent<treeheal>().can -= 3;

                        }
                        else if (kazmaeq == false && hit.transform.GetComponent<treeheal>().can > 0)
                        {
                            hit.transform.GetComponent<treeheal>().can--;
                        }
                        agacefeckt.GetComponent<ParticleSystem>().startColor = new Color(118, 118, 118);
                        Instantiate(agacefeckt, hit.point, Quaternion.identity);
                        if (hit.transform.GetComponent<treeheal>().can <= 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Vector3 pos = new Vector3(hit.transform.position.x + Random.Range(0, 2), 0.5f, hit.transform.position.z + Random.Range(0, 2));
                                Instantiate(tasdusen, pos, Quaternion.Euler(90, 0, 0));
                            }
                            Destroy(hit.collider.gameObject);
                        }
                    }
                }


            }
        }
    }

