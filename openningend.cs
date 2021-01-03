using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openningend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    float beklemesuresi;
    // Update is called once per frame
    void Update()
    {
        beklemesuresi += Time.deltaTime;
        if (beklemesuresi>=5)
        {
        SceneManager.LoadScene(1);

        }
    }
}
