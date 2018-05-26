using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clicking : MonoBehaviour
{
    public string anylevel;

     public void Button_Click()
    {
        Application.LoadLevel("menu");
    }

	
}
