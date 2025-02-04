using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Moves the object attached to towards the player
/// </summary>
public class FlyAtPlayer : MonoBehaviour
{
    // The reference to the player
    [SerializeField] public Transform player;
    // Speed of the object
    [SerializeField] public float speed = 1.0f;
    // The position of the player in the scene
    private Vector3 playerPosition;

    /// <summary>
    /// Called when the object is first enabled
    /// </summary>
    void Awake()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Start is called once before the first execution of Update after the MonoBehaviour is created
    /// </summary>
    void Start()
    {
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveTowardsPlayer();
        DestroyWhenReached();
    }

    /// <summary>
    /// Destroys the object when it reaches its destination
    /// </summary>
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Moves the object towards the player position when the obejct was first intialized
    /// </summary>
    void moveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
