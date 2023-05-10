using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontalAxis;
    public float speed = 2.5f;


    void FixedUpdate()
    {
        float xTrans = Input.GetAxis("Horizontal") * speed;
        float zTrans = Input.GetAxis("Vertical") * speed;

        zTrans *= Time.deltaTime;
        xTrans *= Time.deltaTime;

        transform.Translate(xTrans, 0, -zTrans);


    }
}
