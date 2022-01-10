using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRender;

    // Update is called once per frame
    void Update()
    {
        bgRender.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
    }
}
