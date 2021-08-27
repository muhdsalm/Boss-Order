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
        transform.Rotate(Vector3.RotateTowards(current: transform.position, target.position, 0, 0));
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
        speed += changerate;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<AudioSource>().Play();
    }
}
