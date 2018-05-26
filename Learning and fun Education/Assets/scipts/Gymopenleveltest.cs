using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gymopenleveltest : MonoBehaviour
{ 

    public string level = "GYM";

    // Use this for initialization
    void OnCollisionEnter(Collision Colider)
    {
        if (Colider.gameObject.tag == "Player") ;
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(4);
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
