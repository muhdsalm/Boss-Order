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
    public float thenChangeRate = 0;
    public bool canSpawnEnemy = false;
    public float divisorForThen = 2;

    // Start is called before the first frame update
    void Start()
    {
        changerate = Time.deltaTime * 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        then = Time.time;
        now = Time.time - (then * thenChangeRate);
        if(now >= timeInterval){
            now = 0;
            thenChangeRate += 0.5f / divisorForThen;
            divisorForThen += 2;
            canSpawnEnemy = true;
            spawnEnemy();

        }
        //timeInterval -= changerate;
    }
    public void spawnEnemy(){
        if (canSpawnEnemy) {
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(Enemy);
            canSpawnEnemy = false;
        }
    }
}
