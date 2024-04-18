using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{

    public float minX, MaxX;
    public GameObject[] Balloons;

    public float MaxTime;
    float CurrentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if(CurrentTime >= MaxTime)
        {
            CurrentTime = 0f;
            Instantiate(Balloons[Random.Range(0, Balloons.Length)], 
                new Vector3(Random.Range(minX, MaxX), this.transform.position.y, 0), Quaternion.identity);

        }
    }
}
