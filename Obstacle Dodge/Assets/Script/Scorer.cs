using UnityEngine;

/// <summary>
/// Keeps track of how many times the player has bumped into something
/// </summary>
public class Scorer : MonoBehaviour
{
    // The player's score
    public float score = 0;

    /// <summary>
    /// When this object collides with another check
    /// </summary>
    /// <param name="other"> The object collided with </param>
    private void OnCollisionEnter(Collision other)
    {
        // If the object hit does not have the tag hit add 1 to the score
        if (other.gameObject.tag != "Hit")
        {
            score += 1;
            Debug.Log("You've bumped into a thing this many times: " + score);
        }
    }
}
