using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 5.0f;
    public GameObject character;

    void Update () {
        if (Input.GetKey(KeyCode.D)){
            character.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)){
            character.transform.position += Vector3.left* speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W)){
            character.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            character.transform.position += Vector3.back* speed * Time.deltaTime;
        }
    }
}
