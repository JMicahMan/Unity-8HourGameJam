using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvalGood : MonoBehaviour {
    GameObject objref;

    public void Judgement()
    {
        if (objref.GetComponent<ScoreBeahviour>().TheScore == 6 || objref.GetComponent<ScoreBeahviour>().TheScore == 7 || objref.GetComponent<ScoreBeahviour>().TheScore == 8 || objref.GetComponent<ScoreBeahviour>().TheScore == 9 || objref.GetComponent<ScoreBeahviour>().TheScore == 10|| objref.GetComponent<ScoreBeahviour>().TheScore == 11 || objref.GetComponent<ScoreBeahviour>().TheScore == 12)
        {
            Vector3 vector3 = transform.position;
            transform.position = new Vector3(transform.position.x, 40.0f, transform.position.z);
        }
    }

}
