using UnityEngine;

[CreateAssetMenu(fileName = "DecisionCamaraPuntoAlcanzado.asset", menuName = "FSM/Camara/Decision Punto Alcanzado")]
public class DecisionCamaraPuntoAlcanzado : Decision
{
    public override bool Decide(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        return camara.ApuntaA(camara.PuntoActual());
    }
}
