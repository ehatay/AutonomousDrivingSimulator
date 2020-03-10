using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneGizmos : MonoBehaviour
{
    public List<Transform> car_targets;
    public List<Transform> sign_targets;

    void OnDrawGizmosSelected()
    {
        foreach (Transform target in car_targets)
        {
            if (target != null)
            {
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, target.position);
            }
        }
        foreach (Transform target in sign_targets)
        {
            if (target != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, target.position);
            }
        }
    }
}