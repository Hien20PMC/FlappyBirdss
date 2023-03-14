using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject Bullets;
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject[] target;
    [SerializeField] private GameObject[] Pipe;

    // Update is called once per frame
    void Update()
    {
        Bullets.transform.position += Vector3.right * Time.deltaTime * speed;
        if (Bullets.transform.position.x > 3)
        {
            Debug.Log("1");
            Bullets.SetActive(false);
        }
        if ((Mathf.Round(Bullets.transform.position.x) == Mathf.Round(Pipe[Bird.a].transform.position.x) ||
               Mathf.Round(Bullets.transform.position.x) == Mathf.Round(Pipe[Bird.a].transform.position.x))
               )
        {
            if ((Bullets.transform.position.y <= Pipe[Bird.a].transform.position.y - 1.5 && Bullets.transform.position.y < 5) ||
                    (Bullets.transform.position.y >= Pipe[Bird.a].transform.position.y + 1.5 && Bullets.transform.position.y > -5))
            {
                Bullets.SetActive(false);
            }

        }
        if (Mathf.Round(Bullets.transform.position.x) == Mathf.Round(target[Bird.a].transform.position.x))
        {
            if ((Bullets.transform.position.y) >= (target[Bird.a].transform.position.y) - 1 &&
               (Bullets.transform.position.y) <= (target[Bird.a].transform.position.y) + 1)
                target[Bird.a].SetActive(false);
        }
    }
}
