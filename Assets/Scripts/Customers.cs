using UnityEngine;

public class Customer : MonoBehaviour
{
    public float speed = 2f;
    private bool served = false;

    void Update()
    {
        if (GameManager.Instance.gameOver) return;

        if (!served)
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void Serve()
    {
        if (served = true)
        {
            GameManager.Instance.AddScore(100);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}