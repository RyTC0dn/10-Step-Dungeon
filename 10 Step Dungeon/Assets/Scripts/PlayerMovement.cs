using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //General Player Variables
    private CharacterController controller;
    public float gravity = -9.81f;

    // Player Movement Variables

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize components
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Consistantly apply gravity to the player
        controller.Move(Vector3.up * gravity * Time.deltaTime);
    }
}
