using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour
{
    Renderer aRenderer;
    // Start is called before the first frame update
    void Start()
    {
        aRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime*3);

        if (transform.position.x < -11)
        {
            transform.position = new Vector3(11, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 11)
        {
            transform.position = new Vector3(-11, transform.position.y, transform.position.z);
        }

        if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }

        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5, transform.position.z);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 200 *Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * 200 * Time.deltaTime);
        }

    }
}
