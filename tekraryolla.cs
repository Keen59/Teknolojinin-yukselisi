using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tekraryolla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Wait2");
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
