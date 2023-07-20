using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDown : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
    Debug.Log("Trigger with " + other.gameObject.tag);
        if(SceneManager.GetActiveScene().name == "Level1"){
            if(other.gameObject.tag == "User"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else {
            if(other.gameObject.tag == "User"){
                SceneController.GoLevel1();
            }
        }
    }
}
