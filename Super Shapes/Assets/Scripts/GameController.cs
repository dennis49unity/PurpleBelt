using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    
    //The [] tells Unity that we want an Array
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //The first object will spawn after
    //the spawnDelay and then every spawnTime
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2;
    [Header("Default Spawn Time")]
    public float spawnTime = 3;

    [Header("Game Over UI Canvas")]
    public GameObject gameOverCanvas;


    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //spawn new hexagon that was picked randomly
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);

    }

    public void GameOver()
    {
        CancelInvoke("Spawn");
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
