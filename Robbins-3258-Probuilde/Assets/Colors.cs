using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
