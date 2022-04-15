using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class MovingPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //other.GetComponent<CharacterController>().enabled = false;
        other.transform.parent = gameObject.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
