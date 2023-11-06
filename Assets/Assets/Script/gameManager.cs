using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool gameIsOver = false;
    [SerializeField] GameObject gameUI;
    [SerializeField] GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameIsOver);
    }

    public void setGameOver()
    {
        if(gameIsOver)
        {
            gameIsOver = false;

            gameUI.SetActive(true);
            gameOverUI.SetActive(false);
        }
        else
        {
            gameIsOver = true;
            gameUI.SetActive(false);
            gameOverUI.SetActive(true);
        }
        
    }

    public bool getGameOver()
    {
        return gameIsOver;
    }

    public void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
