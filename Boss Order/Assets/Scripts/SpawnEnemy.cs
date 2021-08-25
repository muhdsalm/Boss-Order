using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float timeInterval = 5;
    public float changerate;
    public GameObject Enemy;
    public float minX, minY, maxX, maxY;
    public float then;
    public float now;
    public bool canSpawnEnemy = false;

    // Start is called before the first frame update
    void Start()
    {
        changerate = Time.deltaTime * 0.01f;
        then = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        now = Time.time;
        if (now - then >= Random.Range((timeInterval - 2), (timeInterval + 2))){
            canSpawnEnemy = true;
            spawnEnemy();
            then = Time.time;
        }
        timeInterval -= changerate;
    }
    public void spawnEnemy(){
        if (canSpawnEnemy) {
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(Enemy, transform.position, transform.rotation);
            canSpawnEnemy = false;
        }
    }
}
