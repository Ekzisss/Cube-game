using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwithScene : MonoBehaviour
{
    public int sceneNumber = 0;

    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
