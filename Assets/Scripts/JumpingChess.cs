using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingChess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void upDown() {
        float currentPositionY = transform.position.y;

        if (currentPositionY >= initPositionY)
        {
            turnSwitch = false;
        }
        else if (currentPositionY <= turningPoint)
        {
            turnSwitch = true;
        }

        if (turnSwitch)
        {
            transform.position = transform.position + new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        upDown();
    }
}
