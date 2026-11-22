using UnityEngine;

[CreateAssetMenu(fileName = "DecisionCamaraObjetivoPerdido.asset", menuName = "FSM/Camara/Decision Objetivo Perdido")]
public class DecisionCamaraObjetivoPerdido : Decision
{
    public override bool Decide(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        return !camara.veoJugador && camara.ApuntaA(camara.lastPlayerPosition);
    }
}
