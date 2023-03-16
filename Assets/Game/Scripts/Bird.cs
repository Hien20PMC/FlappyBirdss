using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    [SerializeField] private float gra;
    [SerializeField] private Vector3 vel;
    [SerializeField] private float maxspeed;
    [SerializeField] private Transform bulletPosition;
    [SerializeField] private GameObject bird;
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private TMP_Text highscore;
    [SerializeField] private Image Ghost;
    [SerializeField] private Image TimeManager;
    [SerializeField] private GameObject[] Pipe;
    [SerializeField] private GameObject[] target;
    public static int a = 0;
    private int score = 0;
    private int HightScore = 0;
    public static int [] temp ;
    private bool pass = false;
    public virtual void Start()
    {
        HightScore = PlayerPrefs.GetInt("HighScore", 0);
        highscore.text = "HighScore: " + HightScore.ToString();
        temp =new int[Pipe.Length];
        temp[0]=1;
        temp[1] = 1;
        if (StartGame.cate_bird == 1)
        {
            TimeManager.gameObject.SetActive(false);
            Ghost.gameObject.SetActive(false);
        }
        if (StartGame.cate_bird == 2)
        {
            TimeManager.gameObject.SetActive(true);
            Ghost.gameObject.SetActive(false);
        }
        if (StartGame.cate_bird == 3)
        {
            TimeManager.gameObject.SetActive(false);
            Ghost.gameObject.SetActive(true);
        }
        MovePipe.speed = 1f;
    }
    public virtual void Update()
    {
        Move();
        Collide();
        UpdateHighScore();
    }
    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (vel.y < 0)
                vel.y = 0;
            vel = Vector3.up * maxspeed;
            Sound.s_Sound.SoundMovement();
        }
        vel.y += 2f * (gra * Time.deltaTime);

        transform.position += vel * Time.deltaTime;

        float angel = 0f;
        if (vel.y < 0)
        {
            angel = Mathf.Lerp(0, -80, -vel.y / maxspeed);
        }
        transform.rotation = Quaternion.Euler(0, 0, angel);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Fire();
            Sound.s_Sound.SoundShot();
        }
    }
    public void Fire()
    {
        GameObject bullet = ObjectPool.instance.GetPoolObject();
        if (bullet != null)
        {
            bullet.transform.position = bird.transform.position;
            bullet.SetActive(true);
        }
    }
    public void Collide()
    {
        Score();
        if (target[a].activeInHierarchy == true)
        {
            if (
              Mathf.Round(bird.transform.position.x) == Mathf.Round(target[a].transform.position.x)
              )
            {
                if ((bird.transform.position.y >= target[a].transform.position.y - 1) &&
                        (bird.transform.position.y <= target[a].transform.position.y + 1))
                {
                    GameOver();
                }

            }
        }

        if ((bird.transform.position.x == Mathf.Round(Pipe[a].transform.position.x) ||
                bird.transform.position.x == Mathf.Round(Pipe[a].transform.position.x))
                )
        {
            if ((bird.transform.position.y <= Pipe[a].transform.position.y - 1.5 && bird.transform.position.y < 5) ||
                    (bird.transform.position.y >= Pipe[a].transform.position.y + 1.5 && bird.transform.position.y > -5))
                GameOver();
            MovePipe.speed = 1f;
        }
        else
        {
            a++;
        }

        if (a == Pipe.Length)
        {
            a = 0;
        }
    }
    public void UpdateHighScore()
    {
        highscore.text = "HighScore: " + HightScore.ToString();
        if (score > HightScore)
        {
            PlayerPrefs.SetInt("HighScore1", score);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        Time.timeScale = 1f;
    }

    public void Score()
    {
        ScoreText.text = Mathf.Round(score).ToString();

        if (temp[0] == 1)
        {
            if (bird.transform.position.x > Pipe[0].transform.position.x)
            {
                score++;
                Sound.s_Sound.SoundPoint();
                temp[0] = 0;
            }
        }
        if (temp[1] == 1)
        {
            if (bird.transform.position.x > Pipe[1].transform.position.x)
            {
                score++;
                Sound.s_Sound.SoundPoint();
                temp[1] = 0;
            }
        }
    }

}
