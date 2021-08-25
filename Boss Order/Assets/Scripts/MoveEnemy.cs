using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public GameObject Guy;
    public Transform target;
    public float speed = 4;
    public float changerate = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        Guy = GameObject.FindWithTag("Player");
        target = Guy.transform;
        changerate = Time.deltaTime * changerate;

    }

    // Update is called once per frame
    void Update()
    {
        float step = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        speed += changerate;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}