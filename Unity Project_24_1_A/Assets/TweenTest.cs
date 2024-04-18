using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    void Start()
    {
        //transform.DOMoveX(5, 2);
        //transform.DORotate(new Vector3(0, 0, 180), 2); 
        //transform.DOScale(new Vector3(2, 2, 2), 2);

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 1));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 1));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 1));

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce);
        // transform.DOShakeRotation(0.5f, new Vector3(0, 0, 90), 10, 90);
        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);

        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 1));
        sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();

        }
            

       
    }
}
