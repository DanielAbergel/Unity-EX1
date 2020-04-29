using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     float timer = 0f;
   public  float speed = 10f;
    int phase = 0;
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow))
            speed = speed < 0 ? -speed : speed ;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            speed = speed > 0 ? -speed : speed ;

        transform.Rotate(0f, 0f, speed * (0.5f));  //Speed, from maximum to zero.
}
}
