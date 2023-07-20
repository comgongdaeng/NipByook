using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbedKey3 : MonoBehaviour
{
    //public OVRGrabbable[] grabbableObject = new OVRGrabbable[6];
    public OVRGrabbable grabbableObject;

    private bool previouslyGrabbed = false;

    public AudioClip grabbedClip;
    public AudioClip droppedClip;
    public DoorController3 DC;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if (grabbableObject.isGrabbed == !previouslyGrabbed)
            {
                previouslyGrabbed = grabbableObject.isGrabbed;
                if (grabbableObject.isGrabbed)
                {
                    OnGrabbedEvent();
                    Debug.Log("First Okay");
                    if(realKey.keys[3].value == true) {DC.gotKey = true;
                    Debug.Log("Second OK");}
                    Debug.Log("Third OK");
                }
                else
                {
                    OnDroppedEvent();
                    DC.gotKey = false;
                }
            }
        

        
    }

    public void OnGrabbedEvent()
    {
        AudioSource.PlayClipAtPoint(grabbedClip, Vector3.zero);
    }

    public void OnDroppedEvent()
    {
        AudioSource.PlayClipAtPoint(droppedClip, Vector3.zero);
    }
}
