using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    [SerializeField] float enemySpeed = 0.05f;

    int enemyPos;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.Translate(0, enemySpeed,0);
    }


    void OnTriggerEnter(Collider collide)
    {
       if(collide.tag == "Destroy Barrier")
        {
            Debug.Log("HIT");
        }
    }
}
