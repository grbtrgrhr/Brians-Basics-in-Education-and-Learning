using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadlevel : MonoBehaviour
{

    void OntriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("trigger touched");
        }
    }
    void OntriggerStay2D()
    {
        Debug.Log(" still touching");
    }
    void OntriggerExit2D()
    {
        Debug.Log("still touching");
    }
}