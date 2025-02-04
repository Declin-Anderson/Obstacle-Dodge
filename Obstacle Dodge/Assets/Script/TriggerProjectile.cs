using UnityEngine;

/// <summary>
/// When this is collided with it launches projectiles towards the player
/// </summary>
public class TriggerProjectile : MonoBehaviour
{
    // The Projectile that is being launched
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;

    /// <summary>
    /// When the trigger is collided with launch projectiles if it was the player that triggered it
    /// </summary>
    /// <param name="other"> object colliding with the trigger</param>
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
            projectile5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
