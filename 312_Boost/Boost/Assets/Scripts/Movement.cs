using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))//Apply thrust to rocket
        {
            
        }       
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))//Rotate rocket left
        {

        }
        else if (Input.GetKey(KeyCode.D))//Rotate rocket right
        {

        }
    }
}
