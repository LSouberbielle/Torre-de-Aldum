using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseButton();
        }
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
            Time.timeScale = 0;
    }
    public void ContinueButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}