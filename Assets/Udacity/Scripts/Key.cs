using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject key;

    DataController data;

    private void Start()
    {
        data = FindObjectOfType<DataController>();
    }

    void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        if (key != null) {
            key.transform.position += new Vector3 ( 0, Mathf.Sin(Time.time) / 25, 0);
        }        
	}

	public void OnKeyClicked()
	{
        print("Key clicked");
        // Instatiate the KeyPoof Prefab where this key is located
        GameObject poofInstance = Instantiate(keyPoof);
        poofInstance.transform.position = key.transform.position;
        // Make sure the poof animates vertically
        poofInstance.GetComponent<ParticleSystem>().Play();

        // ***Call the Unlock() method on the Door
        // *** - I think putting this here makes the objects too reliant on each other  
        // *** - I will use a GameController like class to check the keyCollected value on clicking door event.
        
        // Set the Key Collected Variable to true
        data.mazeData.isKeyCollected = true;

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(key);  
    }
}
