using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    Rigidbody2D _rb;
    public Vector2 Move;
    public bool Fill;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Moving();
    }
    private void Moving()
    { 
        _rb.linearVelocity = new Vector2(Move.x * _speed,  Move.y * _speed);
        
        
        
        
        //vérification de la position pour pouvoir remplir la choppe
        if (transform.position == new Vector3(6.1f,-4.5f,0f))
        {
            FillBeer();
        }

        if (transform.position == new Vector3(6.1f,-1.5f,0f))
        {
            FillBeer();
        }
        if (transform.position == new Vector3(6.1f,1.5f,0f))
        {
           FillBeer(); 
        }
        if (transform.position == new Vector3(6.1f,4.5f,0f))
        {
            FillBeer();
        }
    }
    
    public void FillBeer()
    {
        //dois rester appuyer pour remplir la choppe 
        
        
        //if (Fill == true)
        //{
          //  Beer.ThrowBeer();
        //}
        //else
        {
        }
    }
}