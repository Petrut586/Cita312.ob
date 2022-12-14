using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timeElapsed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeElapsed)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
            
        }
    }
}
