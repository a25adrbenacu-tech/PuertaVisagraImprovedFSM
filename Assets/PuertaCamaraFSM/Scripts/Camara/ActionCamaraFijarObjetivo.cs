using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraFijarObjetivo.asset", menuName = "FSM/Camara/Fijar Objetivo")]
public class ActionCamaraFijarObjetivo : Action
{
    public override void Act(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        camara.lastPlayerPosition = camara.playerTransform.position;
    }
}
