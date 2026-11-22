using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraRotarHaciaPunto.asset", menuName = "FSM/Camara/Rotar Hacia Punto")]
public class ActionCamaraRotarHaciaPunto : Action
{
    public override void Act(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        camara.RotarHacia(camara.PuntoActual());
    }
}
