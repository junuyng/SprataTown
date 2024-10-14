using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtaionController : MonoBehaviour
{
     protected Animator animator;
     protected TownCharacterController controller;

     private void Awake()
     {
          controller = GetComponent<TownCharacterController>();
          animator = GetComponentInChildren<Animator>();
     }
     
}