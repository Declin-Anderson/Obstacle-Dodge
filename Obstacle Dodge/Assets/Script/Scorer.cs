using UnityEngine;

/// <summary>
/// Keeps track of how many times the player has bumped into something
/// </summary>
public class Scorer : MonoBehaviour
{
    public float score = 0;
    private void OnCollisionEnter(Collision other)
    {
        score += 1;
        Debug.Log("You've bumped into a thing this many times: " + score);
    }
}
