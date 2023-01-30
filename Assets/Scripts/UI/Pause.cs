using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool _isPause; //вкл выкл паузы
	[SerializeField] private GameObject _pausePanel;

    private void Start()
    {
        Time.timeScale = 1f;
        _isPause = false;
    }

    private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseM();
        }
        if (_isPause)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
	}

    private void FixedUpdate()
	{

	}

	public void PauseM()
	{
		if(_isPause == true)
		{
			_pausePanel.SetActive(false);
			Time.timeScale = 1f;
			_isPause = false;
			return;
		}
		if(_isPause == false)
		{
			_pausePanel.SetActive(true);
			Time.timeScale = 0.00001f;
			_isPause = true;
			return;
		}
	} 

	public void Restart()
	{
		SceneManager.LoadScene(0);
	}

}
