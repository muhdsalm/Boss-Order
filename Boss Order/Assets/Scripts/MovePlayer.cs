using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 0;
    public float rightturnspeed = 100;
    public float leftturnspeed = 100;
    public GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5){
            transform.position = new Vector2(transform.position.x, 5);
        }
        if (transform.position.y < -5){
            transform.position = new Vector2(transform.position.x, -5);
        }
        if (transform.position.x < -14){
            transform.position = new Vector2(-14f, transform.position.y);
        }
        if (transform.position.x > 14) {
            transform.position = new Vector2(14f, transform.position.y);
        }
        if (speed > 0) {
            speed -= 1 * (Time.deltaTime / 2.5f);
        }
        if (speed < 0){
            speed = 0;
        }
        speed = Time.deltaTime * 8;
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(new Vector3(0, 0, -5) * Time.deltaTime * rightturnspeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(new Vector3(0, 0, 5) * Time.deltaTime * leftturnspeed);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bullet, transform.position, transform.rotation);
        }
        transform.Translate(Vector2.up * speed);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
