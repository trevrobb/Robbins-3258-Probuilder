using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Playa").transform.position;
        this.transform.position = new Vector3(pos.x, pos.y+2f, pos.z -10f);
        
    }
}
