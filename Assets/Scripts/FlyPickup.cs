using UnityEngine;

public class FlyPickup : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
		// If the Collider other is tagged with "Player"...
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
