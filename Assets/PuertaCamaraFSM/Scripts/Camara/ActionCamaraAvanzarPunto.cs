using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraAvanzarPunto.asset", menuName = "FSM/Camara/Avanzar Punto")]
public class ActionCamaraAvanzarPunto : Action
{
    public override void Act(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        if (camara.ApuntaA(camara.PuntoActual()))
            camara.AvanzarPunto();
    }
}
