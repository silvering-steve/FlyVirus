using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float camSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(camSpeed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
    }
    
}
