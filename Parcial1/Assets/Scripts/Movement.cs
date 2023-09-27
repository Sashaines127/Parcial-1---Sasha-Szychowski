using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;

    public Rigidbody rb; 

    public GameObject bucket;
    public bool hasWater;  

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Vertical");
        vertical = Input.GetAxis("Horizontal");

        //transform.position += new Vector3(horizontal, 0, -vertical) * speed * Time.deltaTime;
        rb.velocity = new Vector3(horizontal, 0, -vertical) * speed * Time.deltaTime;
    }
}
