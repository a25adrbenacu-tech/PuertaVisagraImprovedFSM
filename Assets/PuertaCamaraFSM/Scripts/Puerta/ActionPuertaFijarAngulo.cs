using UnityEngine;

[CreateAssetMenu(fileName = "ActionPuertaFijarAngulo.asset", menuName = "FSM/Puerta/Fijar Angulo")]
public class ActionPuertaFijarAngulo : Action
{
    public bool abierta;

    public override void Act(Controller controller)
    {
        PuertaContexto puerta = controller.GetComponent<PuertaContexto>();
        puerta.anguloActual = puerta.AnguloObjetivo(abierta);
        puerta.AplicarRotacion();
    }
}
