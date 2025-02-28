using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("References")]
<<<<<<< HEAD
    public GameObject gameOverCanvas;
=======
    public GameObject gameOverCanvas
>>>>>>> 0738e8c8e3b2c356872ebdf678853b6987ed0b95
    public GameObject scoreCanvas;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);
    }
public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
=======
       
>>>>>>> 0738e8c8e3b2c356872ebdf678853b6987ed0b95
    }
    // Update is called once per frame
    void Update()
    {

    }
}
