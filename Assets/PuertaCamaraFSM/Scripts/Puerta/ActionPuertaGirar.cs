using UnityEngine;

[CreateAssetMenu(fileName = "ActionPuertaGirar.asset", menuName = "FSM/Puerta/Girar")]
public class ActionPuertaGirar : Action
{
    public bool abrir;

    public override void Act(Controller controller)
    {
        PuertaContexto puerta = controller.GetComponent<PuertaContexto>();
        puerta.anguloActual = Mathf.MoveTowards(puerta.anguloActual,
                                                puerta.AnguloObjetivo(abrir),
                                                puerta.velocidadGiro * Time.deltaTime);
        puerta.AplicarRotacion();
    }
}
