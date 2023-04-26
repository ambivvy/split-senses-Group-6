using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private float horizontalAxis;
    private float speedMult = 0.1f;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float xTrans = Input.GetAxis("Horizontal") * speed;
        float zTrans = Input.GetAxis("Vertical") * speed;

        zTrans *= Time.deltaTime;
        xTrans *= Time.deltaTime;

        transform.Translate(xTrans, 0, -zTrans);


    }
}
