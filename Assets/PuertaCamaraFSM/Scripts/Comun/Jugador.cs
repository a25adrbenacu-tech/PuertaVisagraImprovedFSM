using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class Jugador : MonoBehaviour
{
    public float velocidad = 6f;

    void Update()
    {
        Vector2 input = LeerInput();
        if (input == Vector2.zero) return;

        Vector3 adelante = Vector3.forward;
        Vector3 derecha = Vector3.right;
        Camera cam = Camera.main;
        if (cam != null)
        {
            adelante = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up).normalized;
            derecha = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up).normalized;
        }

        Vector3 movimiento = Vector3.ClampMagnitude(derecha * input.x + adelante * input.y, 1f);
        transform.position += movimiento * velocidad * Time.deltaTime;
    }

    Vector2 LeerInput()
    {
#if ENABLE_INPUT_SYSTEM
        Keyboard k = Keyboard.current;
        if (k == null) return Vector2.zero;
        float x = (k.dKey.isPressed || k.rightArrowKey.isPressed ? 1f : 0f)
                - (k.aKey.isPressed || k.leftArrowKey.isPressed ? 1f : 0f);
        float y = (k.wKey.isPressed || k.upArrowKey.isPressed ? 1f : 0f)
                - (k.sKey.isPressed || k.downArrowKey.isPressed ? 1f : 0f);
        return new Vector2(x, y);
#else
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
#endif
    }
}
