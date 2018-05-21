using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltoload : MonoBehaviour
{ 
    public string levelToLoad;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("levelToLoad");
    }
}
