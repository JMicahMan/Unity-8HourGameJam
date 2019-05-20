using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminBehaviour : MonoBehaviour {

    public bool finished = false;

    public float mov = 10.0f;
	void Update () 
    {
        if (Input.GetButton("Horizontal"))
        {
            Vector3 vector3 = transform.position;

            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
                
        }

        if (Input.GetButton("Vertical"))
        {
            Vector3 vector3 = transform.position;

            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);

        }

        if (transform.position.y < -60)
        {
            finished = true;
        }

    }
}
