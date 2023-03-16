using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private GameObject Pipe1;
    [SerializeField] private GameObject Pipe2;
    [SerializeField] private Vector3 vel;
    [SerializeField] private GameObject[] Pipe;
    [SerializeField] private GameObject[] target;
    [SerializeField] private Transform dasheffect;
    public static MovePipe instance;
    private bool isDash = false;
    public static float speed = 1f;


    void Start()
    {
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
            Bird.temp[0] = 1;
            target[0].SetActive(true);
        }
        if (Pipe[1].transform.position.x < -5)
        {
            Pipe[1].transform.position = new Vector3(3, Random.Range(-1, 1));
            Bird.temp[1] = 1;
            target[1].SetActive(true);
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
   
}
