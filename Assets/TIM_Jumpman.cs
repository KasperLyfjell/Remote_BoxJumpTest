using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIM_Jumpman : MonoBehaviour
{
    private void Update() {
         if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
        }
    }
}
