using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 5f;
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            
        Rigidbody rb = this.GetComponent<Rigidbody>();
       
        rb.AddForce(Direction * speed);

        if (this.gameObject.transform.position.y < -5f)
        {
            this.gameObject.transform.position = new Vector3(21f, 1f, -25f);
        }
        
    }
}
