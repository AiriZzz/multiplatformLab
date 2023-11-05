using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    
    float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer= spawnTimer + Time.deltaTime;

       // Debug.Log(spawnTimer);

        if(spawnTimer >= 5)
        {
            spawnTimer = 0;

            int spawnPos = Random.Range(-5, 5);
            Instantiate(enemy, new Vector3(spawnPos, 0, 50), enemy.transform.rotation);
        }

    }
}
