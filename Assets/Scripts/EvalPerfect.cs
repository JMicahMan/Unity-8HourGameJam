using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvalPerfect : MonoBehaviour {

    GameObject objref;

    public void Judgement()
    {
        if (objref.GetComponent<ScoreBeahviour>().TheScore == 16)
        {
            Vector3 vector3 = transform.position;
            transform.position = new Vector3(transform.position.x, 40.0f, transform.position.z);
        }
    }
}
