using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_AnimationTaverner : MonoBehaviour
{
    
    [SerializeField]
    private Animator _Animator = null;

    private void OnTriggerEnter()
    {
        _Animator.Play("Vow");
        Invoke("PointPlayer", 3);
    }

    private void PointPlayer()
    {   
        _Animator.Play("Pointing");
    }

}
