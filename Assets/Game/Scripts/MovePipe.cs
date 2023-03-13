using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    //[SerializeField] private GameObject bird;
    //[SerializeField] private GameObject bird1;
    //[SerializeField] private GameObject bird2;
    [SerializeField] private GameObject Pipe1;
    [SerializeField] private GameObject Pipe2;
    [SerializeField] private Vector3 vel;
    [SerializeField] private GameObject[] Pipe;
    [SerializeField] private Transform dasheffect;
    public static MovePipe instance;
    private bool isDash = false;
    public static float speed = 1f;
    //private float dx;
    //private float dy; 
    //private float dx1;
    //private float dy1;
    ////public float leftedge;
    //float x;
    //float y;
    //float x1;
    //float y1;
    //float x2;
    //float y2;
    //float x3;
    //float y3;

    void Start()
    {
        //if (StartGame.cate_bird == 0)
        //{
        //    StartGame.cate_bird = 1;
        //}
        //if (StartGame.cate_bird == 1)
        //{
        //    bird = bird1;
        //    bird2.SetActive(false);
        //}
        //if (StartGame.cate_bird == 2)
        //{
        //    bird = bird2;
        //    bird1.SetActive(false);
        //}
        //Score();
        //leftedge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        //Pipe1.transform.position += Vector3.left * Time.deltaTime * speed;
        //Pipe2.transform.position += Vector3.left * Time.deltaTime * speed;
        Pipe[0].transform.position += Vector3.left * Time.deltaTime * speed;
        Pipe[1].transform.position += Vector3.left * Time.deltaTime * speed;
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    float dashDistance = 2.5f;
        //    transform.position = Vector3.left * dashDistance;
        //    //Vector3 beforeDashPosition = transform.position;
        //    //Transform dasheffectTransform = Instantiate(dasheffect, beforeDashPosition, Quaternion.identity);
        //    //float dashEffectWidth = 35f;
        //    //dasheffectTransform.localScale = new Vector3(dashDistance / dashEffectWidth, 1f, 1f);
        //}
        //if (Pipe1.transform.position.x < -5)
        //{
        //    Pipe1.transform.position = new Vector3(2, Random.Range(-1, 1));
        //} 
        //if (Pipe2.transform.position.x < -5)
        //{
        //    Pipe2.transform.position = new Vector3(2, Random.Range(-1, 1));
        //}
        if (Pipe[0].transform.position.x < -5)
        {
            Pipe[0].transform.position = new Vector3(3, Random.Range(-1, 1));
        }
        if (Pipe[1].transform.position.x < -5)
        {
            Pipe[1].transform.position = new Vector3(3, Random.Range(-1, 1));
        }
        //dx = Pide_up.transform.position.x;
        //dy = Pide_up.transform.position.y;
        //x1 = dx + 0.8f;
        //y1 = dy - 0.2f;
        //y = dy - 0.2f;
        //x = dx - 0.8f;
        //if (bird.transform.position.x > x && bird.transform.position.y > y && 
        //    bird.transform.position.x < x1 && bird.transform.position.y > y1)
        //{
        //    Sound.s_Sound.SoundHit();
        //    GameOver();
        //}
        //dx1 = Pide_down.transform.position.x;
        //dy1 = Pide_down.transform.position.y;
        //x3 = dx1 + 0.8f;
        //y3 = dy1 + 0.2f;
        //y2 = dy1 + 0.2f;
        //x2 = dx1 - 0.8f;
        //if (bird.transform.position.x > x2 && bird.transform.position.y < y2 &&
        //    bird.transform.position.x < x3 && bird.transform.position.y < y3)
        //{
        //    Sound.s_Sound.SoundHit();
        //    GameOver();
        //}
    }
    //public void GameOver()
    //{
    //    SceneManager.LoadScene("GameOver");
    //}

    //private bool CanMove(Vector3 dir, float distance)
    //{
    //    return Physics2D.Raycast(transform.position, dir, distance).collider == null;
    //}
    //public IEnumerator Dash()
    //{
    //    isDash = true;
    //    transform.position += Vector3.left * speed * 10 * Time.deltaTime;
    //    speed += 7;
    //    yield return new WaitForSeconds(0.3f);
    //    isDash = false;
    //    transform.position += Vector3.left * speed * Time.deltaTime;
    //    speed -= 7;
    //}
    //public void MoveDash()
    //{
    //    if (!isDash)
    //    {
    //        if (Input.GetKeyDown(KeyCode.DownArrow))
    //        {
    //            Dash();
    //        }
    //    }
    //}
}
