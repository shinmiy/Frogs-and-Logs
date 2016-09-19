using UnityEngine;

public class FlyPickup : MonoBehaviour
{

    [SerializeField]
    private GameObject pickupPrefab;

    void OnTriggerEnter(Collider other)
    {
		// If the Collider other is tagged with "Player"...
        if (other.CompareTag("Player"))
        {
            // ... add the pickup particles...
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);

            //... decrement total number of flies...
            FlySpawner.totalFlies--;

            Destroy(gameObject);
        }
    }

}
