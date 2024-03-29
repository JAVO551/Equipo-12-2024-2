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

    void MoverEnX()
    {
        float inputMovimiento = Input.GetAxis("Horizontal"); // Corrige el nombre del método
        rb.velocity = new Vector2(inputMovimiento * velocidad, rb.velocity.y); // Aplica la velocidad en el eje X
        
        //experimento para delimitar
        float newXPosition = transform.position.x + inputMovimiento * velocidad * Time.deltaTime;
        //Para que permanezca en el rango
        newXPosition = Mathf.Clamp(newXPosition, minX, maxX);
        //Aplica la nueva posicion
        transform.position = new Vector2(newXPosition, transform.position.y);

        //Experimento para aumentar en X
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position=new Vector2(transform.position.x + XIncrement,transform.position.y);
        } else if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position=new Vector2(transform.position.x - XIncrement,transform.position.y);
        }

    }
}
