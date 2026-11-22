using UnityEngine;

[CreateAssetMenu(fileName = "DecisionPuertaJugadorDentro.asset", menuName = "FSM/Puerta/Decision Jugador Dentro")]
public class DecisionPuertaJugadorDentro : Decision
{
    public override bool Decide(Controller controller)
    {
        return controller.GetComponent<PuertaContexto>().jugadorDentro;
    }
}
