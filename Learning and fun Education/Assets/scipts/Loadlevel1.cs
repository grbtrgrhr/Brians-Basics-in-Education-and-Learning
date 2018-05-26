using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel1 : MonoBehaviour
{

    void OnTriggerEnter(Collider ChangeScene) // can be Collider HardDick if you want.. I'm not judging you
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevelAdditive(6); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }

}
