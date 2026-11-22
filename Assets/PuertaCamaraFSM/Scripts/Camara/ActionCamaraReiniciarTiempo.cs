using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraReiniciarTiempo.asset", menuName = "FSM/Camara/Reiniciar Tiempo")]
public class ActionCamaraReiniciarTiempo : Action
{
    public override void Act(Controller controller)
    {
        controller.GetComponent<CamaraContexto>().tiempoEnEstado = 0f;
    }
}
