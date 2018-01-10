using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField]
    GameObject enemy;
    // Use this for initialization
    void Start()
    {
            StartCoroutine("SpawnEnemy", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEnemy(float waitTime)
    {
        for (int i = 0; i < 10; ++i)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
