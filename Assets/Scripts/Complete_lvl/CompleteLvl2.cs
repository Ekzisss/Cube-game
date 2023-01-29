using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl2 : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        PlayerPrefs.SetInt("CompletedLvls", 2);
        SceneManager.LoadScene(0);
    }
}
