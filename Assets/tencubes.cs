using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour
{

    public Transform source;
    public Transform target;
    public float speed;

    

    void Update() {
        float horizInput = Input.GetAxis( "Horizontal" );

        source.RotateAround( target.position )
    }
    {

    }