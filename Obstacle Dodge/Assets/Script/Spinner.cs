using UnityEngine;

public class Spinner : MonoBehaviour
{
    // X angle
    [SerializeField] float xValue = 0.0f;
    // Y angle
    [SerializeField] float yValue = 1.0f;
    // Z angle
    [SerializeField] float zValue = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
