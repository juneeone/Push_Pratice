using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 10.0f)
        {
            Destroy(gameObject, 0);
        }
    }
}
