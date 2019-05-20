using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scor2 : MonoBehaviour {

    GameObject objRef;
    public void HowitDo()
    {
        if (objRef.GetComponent<ScoreBeahviour>().TheScore == 1)
        {
            Vector3 vector3 = transform.position;
            transform.position = new Vector3(transform.position.x, 90.0f, transform.position.z);

        }
    }

}

