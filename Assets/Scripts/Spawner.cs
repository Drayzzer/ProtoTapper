using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerPrefab;
    public Transform[] laneSpawnPoints;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCustomer), 1f, spawnInterval);
    }

    void SpawnCustomer()
    {
        if (GameManager.Instance.gameOver) return;

        int lane = Random.Range(0, laneSpawnPoints.Length);
        Instantiate(customerPrefab, laneSpawnPoints[lane].position, Quaternion.identity);
    }
}