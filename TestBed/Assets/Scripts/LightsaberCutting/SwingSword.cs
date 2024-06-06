using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 turn;
    [SerializeField] public float sensitivity = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        // float rotateHorizontal = Input.GetAxis ("Mouse X");
		// float rotateVertical = Input.GetAxis ("Mouse Y");
		// transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
		// transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
    }
}
