using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    int nivel1 = 19;
    string sceneName;
    Scene aScene;
    
    void Start()
    {
       aScene = SceneManager.GetActiveScene();
        sceneName = aScene.name;
    }

    // Update is called once per frame
    void Update()
    {

            if (ScoreScript.scoreValue >= nivel1)
            {
                SceneManager.LoadScene("Level2");
                ScoreScript.scoreValue = 0;
            }
    }
}
