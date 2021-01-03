using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectrigidbody : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshCollider>().convex = true;

        gameObject.GetComponent<MeshCollider>().isTrigger = true;
    }
    
    // Update is called once per frame
    void Update()
    {
      
      

     
    }
}
