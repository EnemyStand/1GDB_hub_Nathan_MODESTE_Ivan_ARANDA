using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PublicAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator _Animator = null;
    private void OnTriggerStay()
    {
        _Animator.Play("Waving");
    }

}
