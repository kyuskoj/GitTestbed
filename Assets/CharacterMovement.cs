using System.Diagnostics;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
	
    public float testbranch_001;

    void Update()
    {
        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Debug.Log("Character is moving. BRACH001: " + testbranch_001);
        


        // Player rotation (optional, depending on your game's camera and control scheme)
        // For example, if you want the character to rotate with A/D keys:
        // float rotation = horizontalInput * rotationSpeed * Time.deltaTime;
        // transform.Rotate(Vector3.up, rotation);
    }
}
