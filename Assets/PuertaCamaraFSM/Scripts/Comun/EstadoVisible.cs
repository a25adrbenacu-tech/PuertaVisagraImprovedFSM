using UnityEngine;

public class EstadoVisible : MonoBehaviour
{
    public string titulo = "FSM";
    public int fila = 0;
    public string estadoActual = "-";

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10 + fila * 34, 260, 28), titulo + ":  " + estadoActual);
    }
}
