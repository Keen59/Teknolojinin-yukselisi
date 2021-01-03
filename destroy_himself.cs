using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_himself : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform);
        gameObject.GetComponent<ParticleSystem>().Play(true);
      
           
      
     

        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
