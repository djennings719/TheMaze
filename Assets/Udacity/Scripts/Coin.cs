using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;
    //public GameObject coin;
    
    DataController data;    

    void Start()
    {
        data = FindObjectOfType<DataController>();
    }

    private void Update()
    {
        
    }
    
    public void OnCoinClicked(GameObject coin) {

        print("Coin clicked");
        
        // Instantiate the CoinPoof Prefab where this coin is located
        GameObject poofInstance = Instantiate(coinPoof);
        poofInstance.transform.position = coin.transform.position;
        // Make sure the poof animates vertically
        
        poofInstance.GetComponent<ParticleSystem>().Play();

        data.mazeData.coinsCollected++;

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(coin);
    }

}
