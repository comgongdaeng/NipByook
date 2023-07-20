using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDown : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(SceneManager.GetActiveScene().name == "Level1"){
            if(collision.gameObject.name == "User"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else {
            if(collision.gameObject.name == "User"){
                SceneController.GoLevel1();
            }
        }
    }
}
