using UnityEngine;

public class Player : MonoBehaviour
{
    public float laneHeight = 2f;
    public int currentLane = 0;
    public GameObject beerPrefab;
    public Transform spawnPoint;

    private int maxLane = 3;

    void Update()
    {
        if (GameManager.Instance.gameOver) return;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentLane < maxLane)
            {
                currentLane++;
                MoveToLane();
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentLane > 0)
            {
                currentLane--;
                MoveToLane();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBeer();
        }
    }

    void MoveToLane()
    {
        transform.position = new Vector3(transform.position.x, currentLane * laneHeight, 0);
    }

    void ThrowBeer()
    {
        Instantiate(beerPrefab, spawnPoint.position, Quaternion.identity);
    }
}