using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * speed);
            
        Rigidbody rb = this.GetComponent<Rigidbody>();
       
        rb.AddForce(Direction);
        
    }
}
