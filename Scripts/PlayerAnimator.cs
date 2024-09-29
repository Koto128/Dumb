using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimater : MonoBehaviour
{
    private const string IS_WALKING = "IsWalkin";

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool(IS_WALKING, true);
    }
}
