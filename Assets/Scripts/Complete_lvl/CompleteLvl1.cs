using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl1 : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        PlayerPrefs.SetInt("CompletedLvls", 1);
        SceneManager.LoadScene(0);
    }
}
