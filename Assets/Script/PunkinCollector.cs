using UnityEngine;
using TMPro;

public class PumpkinCollector : MonoBehaviour
{
    // Reference to the UI text element
    public TextMeshProUGUI counterText;

    // Total number of pumpkins in the scene
    private int totalPumpkins;

    void Start()
    {
        // Count all pumpkins in the scene at the start
        totalPumpkins = GameObject.FindGameObjectsWithTag("Pumpkin").Length;

        // Set the initial counter text
        counterText.text = "Pumpkins Left: " + totalPumpkins;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entered is tagged as a Pumpkin
        if (other.CompareTag("Pumpkin"))
        {
            // Remove the pumpkin from the scene
            Destroy(other.gameObject);

            // Subtract from the total
            totalPumpkins--;

            // Update the UI text
            counterText.text = "Pumpkins Left: " + totalPumpkins;
        }
    }
}