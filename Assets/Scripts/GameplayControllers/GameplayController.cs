using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

	[SerializeField]
    private GameObject pausePanel;


	void Awake () {
        pausePanel.SetActive(false);

		
	}
	
	public void pauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);

    }

    public void resumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void quitGame()
    {
        Time.timeScale = 1f;
        //Application.LoadLevel("mainMenu");
        SceneManager.LoadScene("_mainMenu", LoadSceneMode.Single);
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_mainMenu", LoadSceneMode.Single);
        //add the start game again function here;
    }
}
