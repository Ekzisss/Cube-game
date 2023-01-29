using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwithScene : MonoBehaviour
{
    public Scene scene;
    public Object sceneToLoad;

    void OnTriggerEnter()
    {
        // SceneManager.LoadScene(scene.buildIndex);
        SceneManager.LoadScene(sceneToLoad.name);
    }
}
