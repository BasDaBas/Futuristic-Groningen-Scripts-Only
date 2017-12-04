using UnityEngine;
using System.Collections;

    public class PathWayMovement : MonoBehaviour {

    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    public float speed = 0.1f;
    
    // Use this for initialization
    void Start ()
    {
        lastWaypointSwitchTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPosition = waypoints[currentWaypoint].transform.position;
        Vector3 endPosition = waypoints[currentWaypoint + 1].transform.position;

        float pathLength = Vector3.Distance(startPosition, endPosition);
        float totalTimeForPath = pathLength / speed;
        float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, currentTimeOnPath / totalTimeForPath);
        
        RotateIntoMoveDirection();

        if (gameObject.transform.position.Equals(endPosition))//if object is at the endposition
        {
            if (currentWaypoint < waypoints.Length - 2)// -2 because of the start and end waypoint
            {
                currentWaypoint++;
                lastWaypointSwitchTime = Time.time;
                Debug.Log("LastwaypointSwitchtime = " + lastWaypointSwitchTime);
            }           
        }
        
    }

    private void RotateIntoMoveDirection()
    {
        Vector3 newStartPosition = waypoints[currentWaypoint].transform.position;
        Vector3 newEndPosition = waypoints[currentWaypoint + 1].transform.position;
        Vector3 newDirection = (newEndPosition - newStartPosition);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(newDirection),Time.deltaTime * 6f);// Rotates the Object smooth  
    }
}

