using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantaenvanteractırma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        if (GameObject.Find("craft").transform.GetChild(0).GetChild(0).gameObject.active==true)
        {
            GameObject.Find("craft").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            GameObject.Find("craft").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
