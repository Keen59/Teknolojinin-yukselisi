using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnedagac : MonoBehaviour
{
    bool isgrounded;
    Rigidbody fizik;
    GameObject player;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();

        anim.SetTrigger("devril");

        Destroy(gameObject,4);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
