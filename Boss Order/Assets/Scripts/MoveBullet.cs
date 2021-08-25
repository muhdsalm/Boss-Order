using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector2.up * Time.deltaTime * 15);
        if (transform.position.y > 5) {
            Destroy(gameObject);
        }
        if (transform.position.y < -5) {
            Destroy(gameObject);
        }
        if (transform.position.x < -14.8) {
            Destroy(gameObject);
        }
        if (transform.position.x > 14.8) {
            Destroy(gameObject);
        }

    }
}
