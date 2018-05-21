using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{
    public string level = "testingscene2";

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D Colider)
    {
#pragma warning disable CS0642 // Possible mistaken empty statement
        if (Colider.gameObject.tag == "Player") ;
#pragma warning restore CS0642 // Possible mistaken empty statement

    }
}