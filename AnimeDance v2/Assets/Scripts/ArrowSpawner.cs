using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] private Arrow prefabArrow;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float delay;
    [SerializeField] private float repeatRate;
    private float lastSpawnTime;

    float timer = 0;
    private void Awake()
    {
       print(startPoint.position.y - endPoint.position.y);
        
    }
    private void Start()
    {
        float distance = Vector3.Distance(endPoint.position, startPoint.position);
       
    }
    private void FixedUpdate()
    {
      
        if (timer >= repeatRate)
        {
            SpawnArrow();
            timer = 0;
        }
        timer += Time.fixedDeltaTime;

    }
    private void SpawnArrow()
    {
        Arrow arrow = Instantiate(prefabArrow,transform);
        arrow.transform.position = startPoint.position;
        arrow.SetFinalPoint(endPoint.position);
        lastSpawnTime = Time.fixedDeltaTime;
    }

    
}
