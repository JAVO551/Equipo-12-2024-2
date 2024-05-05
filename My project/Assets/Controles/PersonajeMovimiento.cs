using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad;
    public float maxX;
    public float minX;
    public float XIncrement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtén el componente Rigidbody2D al inicio
    }

    // Update is called once per frame
    void Update()
    {
        MoverEnX();
        
    }


    
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag =="Enemigo"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }




    void MoverEnX()
    {
        float inputMovimiento = Input.GetAxis("Horizontal"); // Obtén el input horizontal

        // Aplica la velocidad en el eje X
        rb.velocity = new Vector2(inputMovimiento * velocidad, rb.velocity.y);

        // Calcula la nueva posición en X
        float newXPosition = transform.position.x + inputMovimiento * velocidad * Time.deltaTime;

        // Limita la posición en X dentro del rango
        newXPosition = Mathf.Clamp(newXPosition, minX, maxX);
        
        //Aplica la nueva posicion
        transform.position = new Vector2(newXPosition, transform.position.y);

    }
}

