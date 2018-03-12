using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        SceneManager.LoadScene(name);
    }

    public void EndGame()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    private void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
