using System.Collections;
using System.Collections.Generic;
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
                print(timeSpend);
            }
        }
    }
}
