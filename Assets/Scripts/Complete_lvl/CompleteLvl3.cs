using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl3 : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        PlayerPrefs.SetInt("CompletedLvls", 3);
        SceneManager.LoadScene(0);
    }
}
