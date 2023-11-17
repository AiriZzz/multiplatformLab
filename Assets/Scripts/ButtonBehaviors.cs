using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject gift;

    // Start is called before the first frame update
    void Start()
    {

    }    // Update is called once per frame
    void Update()
    {

    }
    public void ClickStart()
    {
        SceneManager.LoadScene("level");
    }
    public void ClickClose()
    {
        gift.SetActive(false);
    }
    public void ClickGift()
    {
        gift.SetActive(true);
    }
}