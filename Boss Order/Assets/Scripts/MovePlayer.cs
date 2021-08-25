using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0) {
            speed -= 1 * (Time.deltaTime / 2.5f);
        }
        if (speed < 0){
            speed = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            speed = Time.deltaTime * 8;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(new Vector3(0, 0, -5) * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(new Vector3(0, 0, 5) * Time.deltaTime * 100);
        }
        transform.Translate(Vector2.up * speed);
    }
}
