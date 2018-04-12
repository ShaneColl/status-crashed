using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfCollision : MonoBehaviour {
    public static bool isCollision = false;

    private void OnTriggerEnter(Collider ColliderBottom)
    {
        isCollision = true;
    }

}
