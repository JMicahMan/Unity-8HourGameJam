using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToEnd : MonoBehaviour
{
    GameObject ob;
    public void isFinished()
    {
        if(ob.GetComponent<PikminBehaviour>().finished == true)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2, UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
    }
}
