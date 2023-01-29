using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl4 : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        PlayerPrefs.SetInt("CompletedLvls", 4);
        SceneManager.LoadScene(0);
    }
}
