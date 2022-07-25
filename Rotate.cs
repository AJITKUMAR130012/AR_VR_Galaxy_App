using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float x,y,z;
    Vector3 vect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vect=new Vector3(x,y,z);
        transform.Rotate(vect*Time.deltaTime);
    }
}