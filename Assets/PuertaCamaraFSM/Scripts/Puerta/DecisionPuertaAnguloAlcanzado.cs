using UnityEngine;

[CreateAssetMenu(fileName = "DecisionPuertaAnguloAlcanzado.asset", menuName = "FSM/Puerta/Decision Angulo Alcanzado")]
public class DecisionPuertaAnguloAlcanzado : Decision
{
    public bool abierta;

    public override bool Decide(Controller controller)
    {
        PuertaContexto puerta = controller.GetComponent<PuertaContexto>();
        return Mathf.Approximately(puerta.anguloActual, puerta.AnguloObjetivo(abierta));
    }
}
