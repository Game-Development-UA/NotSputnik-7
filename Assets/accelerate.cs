using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerate : MonoBehaviour
{
    public float speed;
    public accelerate[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(250.0f, 500.0f);

        foreach(accelerate cube in cubes){
            print(cube);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        transform.Rotate(0f,0f + (horiz * -1) * speed * Time.deltaTime, 0f);
        print(horiz);
        
    }
    
}
