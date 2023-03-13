using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private float anispeed;
    [SerializeField] private Image sr;
    // Update is called once per frame
    void Update()
    {
        Material material=sr.material;
        Vector2 offset = material.mainTextureOffset;
        offset.x+=Time.deltaTime*anispeed;
        material.mainTextureOffset=offset;
    }
}
