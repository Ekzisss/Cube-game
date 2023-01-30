using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Promts : MonoBehaviour
{
    private int _completedLvls;
    [SerializeField] private GameObject _promt1Panel;
    [SerializeField] private GameObject _promt2Panel;
    //[SerializeField] private GameObject _promt3Panel;
    //[SerializeField] private GameObject _promt4Panel;
    //[SerializeField] private GameObject _promt5Panel;
           
    void Start()
    {
        _completedLvls = PlayerPrefs.GetInt("CompletedLvls", 0);
        if (_completedLvls == 0) //if lvl 1 completed
        {
            StartCoroutine(Promt1());
        }
        else if (_completedLvls == 1) //if lvl 2 completed
        {
            StartCoroutine(Promt2());
        }
        else if (_completedLvls == 2) //if ...
        {
            
        }
        else if (_completedLvls == 3)
        {
            
        }
        else if (_completedLvls == 4) //esli lvl5 budet kak finalniy
        {
            
        }
    }

    void Update()
    {
        
    }

    IEnumerator Promt1()
    {
        _promt1Panel.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        _promt1Panel.SetActive(false);
    }
    IEnumerator Promt2()
    {
        _promt2Panel.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        _promt2Panel.SetActive(false);
    }

}
