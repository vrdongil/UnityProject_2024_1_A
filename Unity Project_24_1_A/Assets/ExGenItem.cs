using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPoint : MonoBehaviour
{
    public GameObject ItemBox;
    public float checkTime;   
    
    
    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;
        if(checkTime >= 2.0f)
        {
            checkTime = 0.0f;
            GameObject temp = Instantiate(ItemBox);
            temp.transform.position = this.gameObject.transform.position;
            int RandomNumber = Random.Range(0, 4);
            temp.transform.position += new Vector3(0.0f, RandomNumber, 0.0f);

        }    


    }
}
