using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Destroy(gameObject);
     print("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        print("crickets");
    }
}
