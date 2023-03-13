using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{ 
    public static bool PauseGame=false;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject optionMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }
    public void Option()
    {
        optionMenuUI.SetActive(true);
    }

    public void Option2()
    {
        optionMenuUI.SetActive(false);
    }

    public void Quit()
    {

        SceneManager.LoadScene("StartGame");

    }
}
