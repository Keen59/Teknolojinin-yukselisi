using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harvest : MonoBehaviour
{
    public GameObject agac;
    // Start is called before the first frame update
    void Start()
    {
        bekleme = 0;
        gameObject.GetComponent<Collider>().isTrigger = true;
    }
    float bekleme;
    // Update is called once per frame
    void Update()
    {
        bekleme += Time.deltaTime;
        if (bekleme>=100)
        {
            Instantiate(agac,transform.position,Quaternion.identity);
            
            Destroy(gameObject);
        }
    }
}
