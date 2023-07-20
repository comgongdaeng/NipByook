using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class realKey : MonoBehaviour
{
    [Serializable]
    public struct Keys {
        public bool value;
        public GameObject key;
    }
    
    [SerializeField]
    public static Keys[] keys = new Keys[6];


    // Start is called before the first frame update
    void Start()
    {
        int real = UnityEngine.Random.Range(0,6);
        
        for(int i = 0; i < 6; i++) {
            keys[i].value = false;
        }
        keys[real].value = true;
        Debug.Log("real key : " + real + "??????? " + keys[real].value);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
