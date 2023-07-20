using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class realKey_l2 : MonoBehaviour
{
    [Serializable]
    public struct Keys {
        public bool value;
        public GameObject key;
    }
    
    [SerializeField]
    public static Keys[] keys_2 = new Keys[3];


    // Start is called before the first frame update
    void Start()
    {
        int real = UnityEngine.Random.Range(0,3);
        
        for(int i = 0; i < 3; i++) {
            keys_2[i].value = false;
        }
        keys_2[real].value = true;
        Debug.Log("real key : " + real + "??????? " + keys_2[real].value);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
