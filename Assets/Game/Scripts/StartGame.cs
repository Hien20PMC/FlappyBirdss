using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public static int cate_bird;
    public static void bird1()
    {
        SceneManager.LoadScene("GamePlay");
        cate_bird = 1;
        Time.timeScale = 1f;

    }
    public static void bird2()
    {
        SceneManager.LoadScene("GamePlay");
        cate_bird = 2;
        Time.timeScale = 1f;

    }

    public static void bird3()
    {
        SceneManager.LoadScene("GamePlay");
        cate_bird = 3;
        Time.timeScale = 1f;

    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
