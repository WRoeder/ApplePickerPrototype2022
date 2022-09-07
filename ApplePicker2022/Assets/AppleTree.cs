using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the appleTree moves
    public float speed = 1f;

    // Distance where appleTree turns around
    public float LeftAndRightEdge = 10f;

    // Chance that the appleTree will change directions
    public float ChangeDirChance = 0.1f;

    // Seconds between Apple instatiations
    public float appleDropDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        // Changing Direction
    }
}
