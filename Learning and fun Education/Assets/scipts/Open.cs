using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour
{
    public void Button_Click()
    {

#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("HOUSE");
#pragma warning restore CS0618 // Type or member is obsolete
    }


}
