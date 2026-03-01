using UnityEngine;

public class Beer : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Customer"))
        {
            collision.GetComponent<Customer>().Serve();
            Destroy(gameObject);
        }
    }
}
