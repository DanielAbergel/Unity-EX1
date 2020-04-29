using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class OscMover : MonoBehaviour
{
    [Tooltip ("Speed")] [SerializeField] float speed;
    [Tooltip("X starting point")] [SerializeField] float centerX;
    [Tooltip("Y starting point")] [SerializeField] float centerY;
    [Tooltip("the Object range , from range - center - range")] [SerializeField] float range;

    // Start is called before the first frame update
     float time = 0 ;
    void Start()
    {
        Debug.Log("START");
        Transform t = GetComponent<Transform>();
        t.position = new Vector3(centerX + range, centerY, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime ;
        transform.position = new Vector3((Mathf.Cos(time * speed )*range),0,0); 
    }
}
