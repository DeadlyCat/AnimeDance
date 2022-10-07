using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ArrowDetector : MonoBehaviour
{
    private List<Arrow> arrowInTrigger = new List<Arrow>();
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            Arrow arrow = ArrowGameList.GetArrow(collision);
            if (arrow)
            {
                float timeSpend = Time.time - arrow.timeStart;
                arrowInTrigger.Add(arrow);
                print(timeSpend);
                print(1);
            }
        }
    }
    private void OnTriggeStayr2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            Arrow arrow = ArrowGameList.GetArrow(collision);
            if (arrow)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    SelectArrow();
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            Arrow arrow = ArrowGameList.GetArrow(collision);
            if (arrow)
            {
                if (arrowInTrigger.Contains(arrow))
                {
                    arrowInTrigger.Remove(arrow);
                   
                }
            }
        }
    }
    public void SelectArrow()
    {
        if (arrowInTrigger.Count > 0)
        {
            arrowInTrigger[0].gameObject.SetActive(false);
            var arrow = arrowInTrigger.Remove(arrowInTrigger[0]);
            print("Boom");
        }
    }
}
