using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag){
            case "Friendly":
                Debug.Log("Start point; Press space to start!");
                break;

            case "Finish":
                Debug.Log("You have reached to the finish point!");
                break;

            case "Fuel":
                Debug.Log("Fuel added to your energy");
                break;

            default:
                Debug.Log("You are out of track!");
                break;
        }
    }
}
