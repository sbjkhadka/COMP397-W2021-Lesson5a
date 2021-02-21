using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggers a collision is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // get a reference to player's character controller
            var controller = other.gameObject.GetComponent<CharacterController>();
            // turn controller off
            controller.enabled = false;
            // move the player to spawn point 
            other.gameObject.transform.position = spawnPoint.position;
            // turn controller on
            controller.enabled = true;
        }
    }
}
