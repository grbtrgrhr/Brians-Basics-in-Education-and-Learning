using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    public void Button_Click()
    {
        // Switch to 640 x 480 fullscreen at 60 hz
        Screen.SetResolution(640, 480, true, 60);
    }
}