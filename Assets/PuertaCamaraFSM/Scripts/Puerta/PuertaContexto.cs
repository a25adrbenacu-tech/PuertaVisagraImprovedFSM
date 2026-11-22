using UnityEngine;

[RequireComponent(typeof(Controller))]
public class PuertaContexto : MonoBehaviour
{
    public Transform transformVisagra;
    public float anguloAbierto = 90f;
    public float velocidadGiro = 90f;

    public float anguloActual = 0f;
    public bool jugadorDentro = false;

    void OnTriggerEnter(Collider other)
    {
        if (EsJugador(other)) jugadorDentro = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (EsJugador(other)) jugadorDentro = false;
    }

    bool EsJugador(Collider other)
    {
        return other.GetComponentInParent<Jugador>() != null;
    }

    public float AnguloObjetivo(bool abierta)
    {
        return abierta ? anguloAbierto : 0f;
    }

    public void AplicarRotacion()
    {
        transformVisagra.localRotation = Quaternion.Euler(0f, anguloActual, 0f);
    }
}
