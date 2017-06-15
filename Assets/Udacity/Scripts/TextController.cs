using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text keyText;
    public Text coinText;

    DataController data;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<DataController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (data.mazeData.isKeyCollected) {
            keyText.text = "Keys collected: 1/1";
        }

        coinText.text = "Coins collected: " + data.mazeData.coinsCollected + "/5";        
	}
}
