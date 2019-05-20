using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvalBad : MonoBehaviour
{
    GameObject objref;

    public void Judgement()
    {
        if (objref.GetComponent<ScoreBeahviour>().TheScore == 0 || objref.GetComponent<ScoreBeahviour>().TheScore == 1 || objref.GetComponent<ScoreBeahviour>().TheScore == 2)
        {
            Vector3 vector3 = transform.position;
            transform.position = new Vector3(transform.position.x, 40.0f, transform.position.z);
        }
    }
    

}

