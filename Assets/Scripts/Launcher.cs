using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    //public variables
    public Rigidbody bullet;
    public float power = 3000f;
    float timerShoot = 0f;
    public float timeBetweenShoot = 0.5f;

    void Shoot(){
        timerShoot = 0f;

        //use a prefab to Instantiate a projectile gameobject
        Rigidbody bulletInstance = Instantiate(bullet, transform.position+transform.up, transform.rotation) as Rigidbody;
        Vector3 forward = transform.up; //select direction to shoot
        bulletInstance.AddForce(forward*power);

        //Destroy(bulletInstance.gameObject, 5f);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timerShoot += Time.deltaTime;
        if(Input.GetButton("Fire1") && timerShoot > timeBetweenShoot){
            Shoot();
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0.0f, 0.0f, 90.0f*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0.0f, 0.0f, -90.0f*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Rotate(-90.0f*Time.deltaTime, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Rotate(90.0f*Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
