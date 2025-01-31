using UnityEngine;

/// <summary>
/// Checks for when this object is touched by the player
/// </summary>
public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
