using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

/// <summary>
/// This script handles the movement of the player
/// </summary>
public class Mover : MonoBehaviour
{

    // The speed that the player moves
    [SerializeField]
    float moveSpeed = 10f;

    /// <summary>
    /// Start is called once before the first execution of Update after the MonoBehaviour is created
    /// </summary>
    void Start()
    {
        PrintInstruction();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        MovePlayer();
    }

    /// <summary>
    /// Printing a string to the console
    /// </summary>
    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move using the arrow keys or WASD");
        Debug.Log("Don't bump into the obstacles or walls");
    }

    void MovePlayer()
    {
        //Getting the input of the arrow keys and WASD to move the box
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    
        transform.Translate(xValue, yValue, zValue);
    }
}
