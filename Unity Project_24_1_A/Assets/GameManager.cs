using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject[] CircleObject;
    public Transform genTransform;
    public float timeCheck;
    public bool isGen;

    public int Point;
    public int BestScore;
    public static event Action<int> OnPointChanged;
    public static event Action<int> OnBestScoreChanged;
    public void GenObject()
    {
        isGen = false;
        timeCheck = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        GenObject();
        OnPointChanged?.Invoke(Point);
        OnBestScoreChanged?.Invoke(BestScore);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGen == false)
        {
            timeCheck -= Time.deltaTime;
            if (timeCheck <= 0.0f)
            {
                int RandNumber = UnityEngine.Random.Range(0, 3);
                GameObject Temp = Instantiate(CircleObject[RandNumber]);
                Temp.transform.position = genTransform.position;
                isGen = true;
            }
        }
    }

    public void MergeObject(int index, Vector3 position)
    {
        GameObject Temp = Instantiate(CircleObject[index]);
        Temp.transform.position = position;
        Temp.GetComponent<CircleObject>().Used();

        Point += (int)Mathf.Pow(index, 2) * 10;
        OnPointChanged?.Invoke(Point);

    }

    public void EndGame()
    {
        int BestScore = PlayerPrefs.GetInt("BestScore");

        if(Point > BestScore)
        {
            BestScore = Point;
            PlayerPrefs.SetInt("BestScore", Point);
            OnBestScoreChanged?.Invoke(BestScore);
        }    
    }

}

