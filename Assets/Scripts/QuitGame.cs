using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    public void TheEnd()
    {
        if(Input.GetButton("Fire1"))
        {
            Application.Quit();
        }
    }

}
