using UnityEngine;

[CreateAssetMenu(fileName = "ActionCamaraSeguirObjetivo.asset", menuName = "FSM/Camara/Seguir Objetivo")]
public class ActionCamaraSeguirObjetivo : Action
{
    public override void Act(Controller controller)
    {
        CamaraContexto camara = controller.GetComponent<CamaraContexto>();
        if (camara.veoJugador)
            camara.lastPlayerPosition = camara.playerTransform.position;
        camara.RotarHacia(camara.lastPlayerPosition);
    }
}
