using UnityEngine;

public class Beer : MonoBehaviour
{
    public GameObject beer;
    public float speed;
    private Rigidbody2D _rb;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    public void ThrowBeer()
    {
        if (Input.GetButton("Fire1"))
        {
            beer =  Instantiate(beer, transform.position, Quaternion.identity);
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Customer"))
        {
            
        }
    }
    public void EmptyBeer()
    {
        
    }
}
