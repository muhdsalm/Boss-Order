using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFriends : MonoBehaviour
{
    public float speed = 3;
    public float now;
    public float then;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        then = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        now = Time.time;
        if (now - then >= interval)
        {
            Destroy(gameObject);
            then = Time.time;
        }
    }
}
