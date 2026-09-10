using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;

    private void OnMouseDown()
    {
        offset = transform.position - ObtenerPosicionMouse();
    }

    private void OnMouseDrag()
    {
        transform.position = ObtenerPosicionMouse() + offset;
    }

    private Vector3 ObtenerPosicionMouse()
    {
        Vector3 posicionMouse = Input.mousePosition;

        posicionMouse.z = Mathf.Abs(
            Camera.main.transform.position.z - transform.position.z
        );

        return Camera.main.ScreenToWorldPoint(posicionMouse);
    }
}