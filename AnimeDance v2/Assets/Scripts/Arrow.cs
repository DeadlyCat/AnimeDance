using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Arrow : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 final;

    public Collider2D Collider { private set; get; }
    public float timeStart;
    private Action complete;
    private void Awake()
    {
        tag = "Arrow";
        Collider = GetComponent<Collider2D>();
    }

    public void SetFinalPoint(Vector3 point)
    {
        final = point;
        transform.DOMove(point, 0.567f).SetEase(Ease.Linear).OnComplete(() =>
        {
            complete?.Invoke();
        });
    }

    
    private void Start()
    {
        timeStart = Time.time;
        ArrowGameList.AddArrow(this.Collider, this);
    }
   

  
}
