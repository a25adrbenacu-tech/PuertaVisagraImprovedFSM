using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraActualizarSensores.asset", menuName = "FSM/Camara/Actualizar Sensores")]
public class ActionCamaraActualizarSensores : Action
{
    public override void Act(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        camara.tiempoEnEstado += Time.deltaTime;
        camara.ActualizarVision();
    }
}
