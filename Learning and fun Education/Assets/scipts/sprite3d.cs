using UnityEngine;
using System.Collections;

public class sprite3d : MonoBehaviour
{
    public Transform other;
    void Update()
    {
        if (other)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform.position;
            if (Vector3.Dot(forward, toOther) < 0)
                print("The other transform is behind me!");

        }
    }
}