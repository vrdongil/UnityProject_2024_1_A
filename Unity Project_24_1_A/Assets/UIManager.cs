using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text PointText;
    public Text BestScoreText;

    void OnEnable()
    {
        GameManager.OnPointChanged += UpdatePointText;
        GameManager.OnBestScoreChanged += UpdateBestScoreText;
    }

   void OnDisable()
    {
        GameManager.OnPointChanged -= UpdatePointText;
        GameManager.OnBestScoreChanged += UpdateBestScoreText;
    }

    void UpdatePointText(int newPoint)
    {
        PointText.text = "Points : " + newPoint;
    }

    
    void UpdateBestScoreText(int newBestScore)
    {
        BestScoreText.text = "BestScore : " + newBestScore;
    }         
}
