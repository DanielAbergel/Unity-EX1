using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMover : MonoBehaviour
{
    [Tooltip ("rotate the object per second")] [SerializeField] float speed;

    void Update()
    {
        transform.Rotate(new Vector3(0f, 100f, 0f) * (Time.deltaTime + speed) );
    }
}
