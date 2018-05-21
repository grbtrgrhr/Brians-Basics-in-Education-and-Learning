using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cissds : MonoBehaviour
{

    public string level = "testingscene2";

    // Use this for initialization
    void OnCollisionEnter(Collision Colider)
    {
        if (Colider.gameObject.tag == "Player") 
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(level);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}