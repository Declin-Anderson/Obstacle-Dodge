using UnityEngine;

/// <summary>
/// Checks for when this object is touched by the player
/// </summary>
public class ObjectHit : MonoBehaviour
{

    /// <summary>
    /// Checking what has entered the collision box of the object
    /// </summary>
    /// <param name="other"> What is colliding with the box</param>
    private void OnCollisionEnter(Collision other) 
    {
        // If the player collided with the object change its color to black
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
