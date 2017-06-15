using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    public GameObject door;
    AudioSource[] audioSources;

    DataController data;
    bool isOpening;
    bool isDoorFullyOpen;
    private Animator doorAnimator;
    
    private void Start()
    {
        audioSources = GetComponents<AudioSource>();
        data = FindObjectOfType<DataController>();
        print("audioSources length: " + audioSources.Length);
        //doorAnimator = door.GetComponent<Animator>();
    }
    int i = 0;
    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (isOpening) {
            gameObject.transform.Rotate(new Vector3(-1.1f, 0, 0));
            i++;
            if (i > 100)
            {
                isOpening = false;
            }
        }
    }

    public void OnDoorClicked() {
        print("door clicked");
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        if (data.mazeData.isKeyCollected) {
            isOpening = true;
            Unlock();          
        }
        // (optionally) Else
        // Play a sound to indicate the door is locked
        else
        {
            audioSources[0].Play();
        }
        
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        // --As stated in key.cs - I believe the Unlock should not be called on collecting the key
        audioSources[1].Play();
    }
}
