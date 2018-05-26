using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class schoolopenlevel : MonoBehaviour
{ 

    public string level = "School";

    // Use this for initialization
    void OnCollisionEnter(Collision Colider)
    {
        if (Colider.gameObject.tag == "Player") ;
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(2);
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
