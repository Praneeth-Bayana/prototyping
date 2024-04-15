using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject drawbridge; // Assign the drawbridge object in the inspector
    private bool isActivated = false;

    // This method would be called by your player interaction script
    public void Interact()
    {
        if (isActivated)
        {
            // Lower the drawbridge
            drawbridge.transform.Rotate(new Vector3(-90, 0, 0)); // Example rotation, adjust as needed
        }
    }

    void OnEnable()
    {
        isActivated = true;
    }
}
