using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform head;
    private void OnTriggerStay(Collider other)
    {
        head.LookAt(other.transform);
    }
}
