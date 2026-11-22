using UnityEngine;

[CreateAssetMenu(fileName = "DecisionCamaraVeJugador.asset", menuName = "FSM/Camara/Decision Ve Jugador")]
public class DecisionCamaraVeJugador : Decision
{
    public override bool Decide(Controller controller)
    {
        return controller.GetComponent<CamaraContexto>().veoJugador;
    }
}
