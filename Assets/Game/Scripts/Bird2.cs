using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird2 : Bird
{
    public Image imageCooldown;
    bool isCooldown;
    public float cooldown = 5f;
    public override void Start()
    {
        
    }
    // Update is called once per frame
    public override void Update()
    {
        Move();
        Collide();
        if (StartGame.cate_bird == 2)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                isCooldown = true;
            }
            if (isCooldown)
            {
                Time.timeScale = 0.5f; ;
                imageCooldown.fillAmount += 1 / cooldown * Time.deltaTime;
                if (imageCooldown.fillAmount >= 1)
                {
                    imageCooldown.fillAmount = 0;
                    isCooldown = false;
                    Time.timeScale = 1f;
                }
            }
        }
    }
}
