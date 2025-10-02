using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadInicial = 4f;
    public float incrementoVelocidad = 1.1f;
    private Rigidbody2D bolaRb;

    void Start()
    {
        bolaRb = GetComponent<Rigidbody2D>();
        Lanzar();
    }

    private void Lanzar()
    {
        float velocidadX = Random.Range(0, 2) == 0 ? 1 : -1;
        float velocidadY = Random.Range(0, 2) == 0 ? 1 : -1;
        bolaRb.linearVelocity = new Vector2(velocidadX, velocidadY) * velocidadInicial;
    }

    /**
    * Método para saber cuando se produce una colisión
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pala"))
        {
            bolaRb.linearVelocity *= incrementoVelocidad;
        }
    }

    // Detectamos si se alcanzó alguna de las 2 zonas de gol
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("golPala1"))
        {
            ControladorJuego.Instance.GolPala1();
        }
        else
        {
            ControladorJuego.Instance.GolPala2();
        }
        // Reiniciamos los elementos del juego y lanzamos la bola
        ControladorJuego.Instance.Reiniciar();
        Lanzar();
    }

}
