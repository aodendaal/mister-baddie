using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objective")
        {
            Destroy(other.gameObject);
            ObjectiveTracker.Instance.UpdateScore();
        }
    }
}
