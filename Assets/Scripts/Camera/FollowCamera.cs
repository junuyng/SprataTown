using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
     [SerializeField]private Transform target;
     
     
     private void LateUpdate()
     {
          NextCameraPosition();
     }

     
     private void NextCameraPosition()
     {
          Vector3 cameraPos = target.position + new Vector3(0, 0, -10);
          transform.position = cameraPos;
     }
}
