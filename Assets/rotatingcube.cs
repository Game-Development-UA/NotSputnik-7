using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingcube : MonoBehaviour
{
    public Transform target;
    public float speed
    

    void Start() {
        speed = Random.Range( 0f, 100f );
        
    }

    
    void Update() {
    target.Rotate( 0f, Input.GetAxis( "Horizontal" ) * speed * Time.deltaTime, 0f );

        
        }

    }
}