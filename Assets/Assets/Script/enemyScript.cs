using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField] float enemySpeed = 10;

    int enemyPos;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -enemySpeed *Time.deltaTime);

   
    }

    private void OnTriggerEnter(Collider collide)
    {
        if(collide.tag == "Destroy Barrier")
        {
            Destroy(gameObject);
        }
    }
  
}
