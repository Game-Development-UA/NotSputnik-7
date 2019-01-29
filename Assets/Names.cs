using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names : MonoBehaviour
{

    public GameObject[] cubes;

    void start() {
        for( int index = 0; index < cubes.Length; index++ ) {
            cubes[index].name = cubes[index].name + index;
        }
    }
}
