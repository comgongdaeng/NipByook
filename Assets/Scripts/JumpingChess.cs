using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingChess : MonoBehaviour
{
    float originY;

    public float turningPoint;
    public bool turned;

    public float chessSpeed;

    // Start is called before the first frame update
    void Start()
    {
       originY = -1;
    }

    void upDown() {
        float currentY = transform.position.y;

        if (currentY <= originY)
        {
            turned = false;
        }
        else if (currentY >= turningPoint)
        {
            turned = true;
        }

        if (turned)
        {
            transform.position = transform.position + new Vector3(0, -1, 0) * chessSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + new Vector3(0, 1, 0) * chessSpeed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        upDown();
    }
}