using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;//get the object that moves
    void OnCollisionEnter(Collision collisionInfo)
    {
        //if we touch the robot we will stop the movement
        if (collisionInfo.collider.name == "Ball")//if its the ball 
        {
            movement.enabled = false; //then stop it
        }
    }

}