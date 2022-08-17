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
        Application.targetFrameRate = 60;
    }
    private void Start()
    {
        float distance = Vector3.Distance(endPoint.position, startPoint.position);
       
    }
    private void Update()
    {
      
        if (timer >= repeatRate)
        {
            SpawnArrow();
            timer = 0;
        }
        timer += Time.deltaTime;

    }
    private void SpawnArrow()
    {
        
        Arrow arrow = Instantiate(prefabArrow,transform);
        arrow.transform.position = startPoint.position;
        arrow.SetFinalPoint(endPoint.position);
        lastSpawnTime = Time.deltaTime;
    }

    
}
