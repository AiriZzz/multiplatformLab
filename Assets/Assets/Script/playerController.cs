using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    [SerializeField] GameObject player;
   // [SerializeField] Rigidbody playerRigidBody;
    [SerializeField] Slider slider;
    [SerializeField] gameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position.Set(100, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.Translate(slider.value, 0, 0);

        if(player.transform.position.x > 5)
        {
            player.transform.position = new Vector3(5, 0.3f, 0);
        }

        if (player.transform.position.x < -5)
        {
            player.transform.position = new Vector3(-5, 0.3f, 0);
        }

    }


    private void OnTriggerEnter(Collider collider)
    {
        if(!gameManager.getGameOver())
        {
            if (collider.tag == "enemy")
            {
                gameManager.setGameOver();
            }
        }
        
    }
}
