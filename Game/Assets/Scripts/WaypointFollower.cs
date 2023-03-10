using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] waypoints;
    int currentIndex =  0;
    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentIndex].transform.position) < .1f)
        {
            currentIndex++;
            if (currentIndex >= waypoints.Length)
            {
                currentIndex = 0;
            } 
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentIndex].transform.position, speed * Time.deltaTime);
    }
}

