using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAchievement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            AchievementManager.instance.AddProgress("����", 1);

        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            AchievementManager.instance.AddProgress("�ϰ�", 1);
        }
    }
}
