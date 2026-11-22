using UnityEngine;

[CreateAssetMenu(fileName = "DecisionCamaraTiempoEnEstado.asset", menuName = "FSM/Camara/Decision Tiempo En Estado")]
public class DecisionCamaraTiempoEnEstado : Decision
{
    public float segundos = 2f;

    public override bool Decide(Controller controller)
    {
        return controller.GetComponent<CamaraContexto>().tiempoEnEstado >= segundos;
    }
}
