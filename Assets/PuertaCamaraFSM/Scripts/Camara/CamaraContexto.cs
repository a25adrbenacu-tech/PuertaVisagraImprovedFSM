using UnityEngine;

[RequireComponent(typeof(Controller))]
public class CamaraContexto : MonoBehaviour
{
    public Transform[] posicionesCamara;
    public Transform playerTransform;
    public float velocidadCamara = 45f;
    public float distanciaVision = 40f;
    public float anguloVision = 30f;
    public float toleranciaAngulo = 0.5f;

    public int puntoCamara = 0;
    public float tiempoEnEstado = 0f;
    public bool veoJugador = false;
    public Vector3 lastPlayerPosition;

    public void ActualizarVision()
    {
        Vector3 haciaJugador = playerTransform.position - transform.position;
        veoJugador = haciaJugador.magnitude <= distanciaVision
                  && Vector3.Angle(transform.forward, haciaJugador) <= anguloVision;
    }

    public Vector3 PuntoActual()
    {
        return posicionesCamara[puntoCamara].position;
    }

    public void AvanzarPunto()
    {
        puntoCamara = (puntoCamara + 1) % posicionesCamara.Length;
    }

    public void RotarHacia(Vector3 objetivo)
    {
        Quaternion rotacionObjetivo = Quaternion.LookRotation(objetivo - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotacionObjetivo,
                                                      velocidadCamara * Time.deltaTime);
    }

    public bool ApuntaA(Vector3 objetivo)
    {
        Quaternion rotacionObjetivo = Quaternion.LookRotation(objetivo - transform.position);
        return Quaternion.Angle(transform.rotation, rotacionObjetivo) < toleranciaAngulo;
    }
}
