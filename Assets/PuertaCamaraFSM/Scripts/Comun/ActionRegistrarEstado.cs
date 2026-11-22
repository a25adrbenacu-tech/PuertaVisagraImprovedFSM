using UnityEngine;

[CreateAssetMenu(fileName = "ActionRegistrarEstado.asset", menuName = "FSM/Comun/Registrar Estado")]
public class ActionRegistrarEstado : Action
{
    public string etiqueta;

    public override void Act(Controller controller)
    {
        EstadoVisible visible = controller.GetComponent<EstadoVisible>();
        string quien = controller.name;
        if (visible != null)
        {
            visible.estadoActual = etiqueta;
            quien = visible.titulo;
        }
        Debug.Log(quien + " -> " + etiqueta);
    }
}
