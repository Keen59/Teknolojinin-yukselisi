using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolscripti : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
   

    }

    public void kapat()
    {


        gameObject.transform.parent.gameObject.SetActive(false);

       
    }
    float bekle;
    // Update is called once per frame
    void Update()
    {
  
    }
}
