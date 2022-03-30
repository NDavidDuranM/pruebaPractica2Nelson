using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateTubos : MonoBehaviour
{
    public GameObject walls;
    Vector3 _startingPosition = new Vector3(0, 6f);
    float nextTime;
    const float timePased = 2f, startPositionX = 4f, minY = 4.5f, maxY = 7f;
    
    void Start()
    {
        nextTime = GetNextTime();
    }

    void Update()
    {
        if(Time.time > nextTime)
        {
            _startingPosition.x = startPositionX;
            _startingPosition.y = Random.Range(minY, maxY);
            Instantiate(walls, _startingPosition, Quaternion.identity);
            nextTime = GetNextTime();
        }
    }
    
    float GetNextTime()
    {
        return nextTime = Time.time + timePased;
    }
}
