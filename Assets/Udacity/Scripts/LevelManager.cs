using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    DataController data;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<DataController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentIndex + 1);
        }
    }

    public void LoadPreviousScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex > 0)
        {
            SceneManager.LoadScene(currentIndex - 1);
            
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("01_Menu");
    }

    public void LoadGameScene() {
        data.mazeData.coinsCollected = 0;
        data.mazeData.isKeyCollected = false;
        SceneManager.LoadScene("02_Maze");
    }

    public void QuitRequest() {
        Application.Quit();
    }
}
