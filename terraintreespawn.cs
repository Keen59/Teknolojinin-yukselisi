using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraintreespawn : MonoBehaviour
{
    public GameObject tree;
    public GameObject tree2;
    int randomposxeski;
    GameObject[] eskigameobject = new GameObject[100];
    int randomposzeski;
 
    void Start()
    {

        randomposxeski = 0;
        randomposzeski = 0;
        for (int i = 0; i < 100; i++)
        {
            int randomposx = Random.Range(0, 250);
            int randomposz = Random.Range(0, 250);
            int random = Random.Range(0, 2);
            if (random == 1)
            {
                GameObject eskigameobject = Instantiate(tree, new Vector3(randomposx, Terrain.activeTerrain.SampleHeight
                    (new Vector3(randomposx,0, randomposz)), randomposz), Quaternion.identity);
                eskigameobject.name = "agac2";
                eskigameobject.isStatic = true;
                eskigameobject.transform.parent = GameObject.Find("agaclar").transform;
            }
            else
            {
                GameObject eskigameobject = Instantiate(tree2, new Vector3(randomposx, Terrain.activeTerrain.SampleHeight
                    (new Vector3(randomposx, 0, randomposz)), randomposz), Quaternion.identity);
                eskigameobject.name = "agac3";
                eskigameobject.isStatic = true;
                eskigameobject.transform.parent = GameObject.Find("agaclar").transform;
            }


        }

    }
    int i = 0;
    void Update()
    {
       



    }
}

