﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class over : MonoBehaviour
{
    public GameObject Birdy;
    public GameObject Pattern;
   private void OnCollisionEnter2D(Collision2D collision) {
       
       if(collision.collider.tag=="Ground"){
          

       }
   }
   private void Destroy() {
      
       Destroy(Birdy);
       Instantiate(Pattern,transform.position,Quaternion.identity);
       print("yes");
   }
}
