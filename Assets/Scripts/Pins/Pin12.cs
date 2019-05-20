using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin12 : MonoBehaviour
{
    public bool down = false;

    public void isItDown()
    {
        if (transform.position.y < 0)
        {
            down = true;
        }
    }

}
