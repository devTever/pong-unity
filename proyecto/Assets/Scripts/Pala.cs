using UnityEngine;

public class Pala : MonoBehaviour
{
    public float velocidad = 7f;
    public bool isPala1;
    public float limiteY = 3.75f; // Límite de altura

    void Update()
    {
        float movimiento = isPala1 ? Input.GetAxisRaw("Vertical1") : Input.GetAxisRaw("Vertical2");
        Vector2 posicionPala = transform.position;
        // Nos permite indicar los valores mínimo y máximo que pasamos como posiciones
        posicionPala.y = Mathf.Clamp(posicionPala.y + movimiento * velocidad * Time.deltaTime,
                                     -limiteY, limiteY);
        transform.position = posicionPala;
    }

}