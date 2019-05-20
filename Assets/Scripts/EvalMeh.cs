using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvalMeh : MonoBehaviour {

    GameObject objref;

    public void Judgement()
    {
        if (objref.GetComponent<ScoreBeahviour>().TheScore == 3 || objref.GetComponent<ScoreBeahviour>().TheScore == 4 || objref.GetComponent<ScoreBeahviour>().TheScore == 5)
        {
            Vector3 vector3 = transform.position;
            transform.position = new Vector3(transform.position.x, 40.0f, transform.position.z);
        }
    }
}
