using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviors : MonoBehaviour
{
    public GameObject gift;
    public Text txt;
    public Button btn;

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
    public void ClickClaim()
    {
        txt.text = "100";
        btn.GetComponent<Image>().color = Color.grey;
    }
}