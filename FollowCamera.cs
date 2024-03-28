using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // the things position(camera should ve the same sa the car's position)
    [SerializeField] GameObject ThingsToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ThingsToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
