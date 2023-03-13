using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject bird1;
    [SerializeField] private GameObject bird2;
    [SerializeField] private GameObject bird3;
    private void Start()
    {
        if (StartGame.cate_bird == 0)
        {
            StartGame.cate_bird = 1;
        }
        if (StartGame.cate_bird == 1)
        {
            bird = bird1;
            bird2.SetActive(false);
            bird3.SetActive(false);
        }
        if (StartGame.cate_bird == 2)
        {
            bird = bird2;
            bird1.SetActive(false);
            bird3.SetActive(false);
        }
        if (StartGame.cate_bird == 3)
        {
            bird = bird3;
            bird1.SetActive(false);
            bird2.SetActive(false);
        }
    }
}
