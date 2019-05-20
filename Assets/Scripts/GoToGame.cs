using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoToGame : MonoBehaviour
{
    
    public void NextScene()
    {
        if(Input.GetButton("Fire1"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1, UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
    }
}
