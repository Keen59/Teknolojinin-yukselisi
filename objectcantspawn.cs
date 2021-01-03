using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectcantspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnTriggerStay(Collider other)
    {
        if (other.tag=="agac")
        {
            Destroy(other.gameObject);
        }
       

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
