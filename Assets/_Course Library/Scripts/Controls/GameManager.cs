using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float spawnInterval = 10f;
    private float startDelay = 20f;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallSpawn", spawnInterval, startDelay);
    }

    // Update is called once per frame
    private void BallSpawn()
    {
        Instantiate(Ball, spawnPoint);
    }
}
