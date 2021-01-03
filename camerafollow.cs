using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    Vector3 a;
    // Update is called once per frame
    void Update()
    {
      transform.position= Vector3.MoveTowards(transform.position,new Vector3(player.transform.position.x,100, player.transform.position.z),Time.deltaTime*50);
  
    }
}
