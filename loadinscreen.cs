 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class loadinscreen : MonoBehaviour
{
   public GameObject player;
   public GameObject crafttable;
    public GameObject canvas;
   public GameObject gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        crafttable.SetActive(false);
        canvas.SetActive(false);
        gamecontroller.SetActive(false);
    }
    float bekleme;
    void Update()
    {
        bekleme += Time.deltaTime;        
        if (bekleme>10f)
        {
            player.SetActive(true);
            crafttable.SetActive(true);
            canvas.SetActive(true);
           gamecontroller.SetActive(true);
     
            Destroy(gameObject);

        }
    }
}
