using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MazeData {
    public bool isKeyCollected;
    public int coinsCollected;

    public bool isTimeBased;
    public int timeLimitInSeconds;
    public float timeElapsed;
}