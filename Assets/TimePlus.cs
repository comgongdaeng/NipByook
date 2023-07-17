using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePlus : MonoBehaviour
{
    
    
    void OnCollisionEnter(Collision col) {

        timer.time += 10f;
        Destroy(col.gameObject, 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
