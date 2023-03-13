using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject Bullets;
    [SerializeField] private float speed = 5f;


    // Update is called once per frame
    void Update()
    {
        Bullets.transform.position += Vector3.right * Time.deltaTime * speed;
        if (Bullets.transform.position.x>3)
        {
            Debug.Log("1");
            Bullets.SetActive(false);
        }
    }
}
