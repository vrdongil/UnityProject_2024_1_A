using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class excubeplayer : MonoBehaviour
{
   public Text TextUI = null;
   public int Count = 0;
   public int Power = 100;
    public int Point = 0;
    public float checkTime = 0.0f;
    public float checkEndTime = 30.0f;
    public Rigidbody m_Rigidbody;
    // Update is called once per frame
    void Update()
    {

        checkEndTime -= Time.deltaTime;
        if (checkEndTime <= 0)
        {
            PlayerPrefs.SetInt("Point", Point);
            SceneManager.LoadScene("ResultScene");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);

        }
       
        TextUI.text = Count.ToString();
    }
        void OnCollisionEnter(Collision collision)
        {
                Debug.Log(collision.gameObject.name);
                if(collision.gameObject.tag == "Pipes")
                {
                Point = 0;
                gameObject.transform.position = Vector3.zero;
                }


        }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Items")
        {
            Point += 10;
            Destroy(other.gameObject);
        }
    }

}
