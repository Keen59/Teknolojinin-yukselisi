using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questmarker_triggered : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {

        }    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
