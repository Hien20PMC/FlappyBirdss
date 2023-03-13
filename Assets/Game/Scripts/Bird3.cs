using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird3 : Bird
{
    public Image imageCooldown;
    bool isCooldown;
    public float cooldown = 0.2f;

    public override void Start()
    {
        
    }
    // Update is called once per frame
    public override void Update()
    {
        Move();
        Collide();
        if (StartGame.cate_bird == 3)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                isCooldown = true;
            }
            if (isCooldown)
            {
                MovePipe.speed += 3;
                imageCooldown.fillAmount += cooldown * Time.deltaTime;
                if (imageCooldown.fillAmount >= 1)
                {
                    imageCooldown.fillAmount = 0;
                    isCooldown = false;
                    MovePipe.speed = 1f;
                }
            }
 
        }
    }
   
}
