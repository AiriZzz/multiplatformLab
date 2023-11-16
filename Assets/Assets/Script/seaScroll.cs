using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class seaScroll : MonoBehaviour
{
    [SerializeField] GameObject sea;
    [SerializeField] GameObject sea2;
    [SerializeField] gameManager GameManager;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.getGameOver())
        {
            sea.transform.Translate(50 * Time.deltaTime, 0, 0);
            sea2.transform.Translate(-50 * Time.deltaTime, 0, 0);

            if (sea.transform.position.z < -55)
            {
                sea.transform.position = new Vector3(0, 0, sea2.transform.position.z + sea2.GetComponent<Renderer>().bounds.size.z - 0.5f);
            }

            if (sea2.transform.position.z < -55)
            {
                sea2.transform.position = new Vector3(0, 0, sea.transform.position.z + sea.GetComponent<Renderer>().bounds.size.z - 0.5f);
            }
        }
       
    }
}
