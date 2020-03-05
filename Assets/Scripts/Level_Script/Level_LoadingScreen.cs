﻿using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
// This script makes the next scene load after 2 seconds have elapsed

// This script is attached to Level_SceneSwitch

/* 
    Jason Weimann, 2017 : How to load a scene after a timer or delay in Unity3D with SceneManager
    Available from: https://www.youtube.com/watch?v=Oe9BZVnoedE&list=LLH3a8ESny180HvT46FvAlAw&index=6
*/

public class Level_LoadingScreen : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 2f; // Default value for delay before loading next scene

    [SerializeField]
    private string sceneNameToLoad; // Name of the scene to load next
=======
public class Level_LoadingScreen : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 2f;

    [SerializeField]
    private string sceneNameToLoad;
>>>>>>> 91ce6acbca5a1e9c46b8cbe4a2e8bc29ef13437d

    private float timeElapsed;

    private void Update()
    {
<<<<<<< HEAD
        timeElapsed += Time.deltaTime; // Keep track of how much time has elapsed
=======
        timeElapsed += Time.deltaTime;
>>>>>>> 91ce6acbca5a1e9c46b8cbe4a2e8bc29ef13437d

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
