using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] public float speed = 2;
    [SerializeField] public bool counterClockwise = true;
    // Start is called before the first frame update
    void Start()
    {
        if (counterClockwise){
            speed = -speed;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(0f, speed*Time.deltaTime, 0f, Space.Self);
    }
}
