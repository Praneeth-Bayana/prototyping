using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject button; // Assign the button object in the inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure the player has the "Player" tag
        {
            // Enable the button script to allow it to be interacted with
            button.GetComponent<Button>().enabled = true;
        }
    }
}
