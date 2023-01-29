using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwithScene : MonoBehaviour
{
    public Scene scene;
    [SerializeField] private Object _sceneToLoad;

    private void OnTriggerEnter()
    {
        // SceneManager.LoadScene(scene.buildIndex);
        SceneManager.LoadScene(_sceneToLoad.name);
    }
}
