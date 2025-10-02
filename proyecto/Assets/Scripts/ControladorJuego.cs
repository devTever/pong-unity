using UnityEngine;
using TMPro;

public class ControladorJuego : MonoBehaviour
{
    public TMP_Text marcadorPala1;
    public TMP_Text marcadorPala2;
    public Transform pala1Transform;
    public Transform pala2Transform;
    public Transform bolaTransform;

    private int golesPala1, golesPala2;

    public static ControladorJuego Instance { get; private set; }

    private void Awake()
    {
        // Configurar Singleton de forma segura
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void GolPala1()
    {
        golesPala1++;
        marcadorPala1.text = golesPala1.ToString();
    }

    public void GolPala2()
    {
        golesPala2++;
        marcadorPala2.text = golesPala2.ToString();
    }

    public void Reiniciar()
    {
        pala1Transform.position = new Vector2(pala1Transform.position.x, 0);
        pala2Transform.position = new Vector2(pala2Transform.position.x, 0);
        bolaTransform.position = new Vector2(0, 0);
    }
}
