using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbedNotif : MonoBehaviour
{
    public OVRGrabbable grabbableObject;
    private bool previouslyGrabbed = false;

    public AudioClip grabbedClip;
    public AudioClip droppedClip;
    public DoorController DC;

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
                DC.gotKey = true;
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
