using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreBeahviour : MonoBehaviour
{
    public GameObject gameobjectRef;
    void Start()
    {
        TheScore = 0;

    }
    public int TheScore;
    void Score()
    {
        if (gameobjectRef.GetComponent<Pin1>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin2>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin3>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin4>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin5>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin6>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin7>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin8>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin9>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin10>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin11>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin12>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin13>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin14>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin15>().down == true)
        {
            TheScore++;
        }

        if (gameobjectRef.GetComponent<Pin16>().down == true)
        {
            TheScore++;
        }


    }

}
