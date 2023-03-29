using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PublicAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator _Animator = null;
    private void OnTriggerEnter()
    {
        _Animator.Play("Waving");
    }

}
