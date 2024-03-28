using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excylinder : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;

        if (gameObject.transform.position.x < -12.0f)
        {
            gameObject.transform.position += new Vector3(24.0f, 0.0f, 0.0f);
        }
    }
}
