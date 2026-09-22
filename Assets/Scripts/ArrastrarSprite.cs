using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        offset = transform.position - ObtenerPosicionMouse();
    }

    private void OnMouseDrag()
    {
        Vector3 nuevaPosicion = ObtenerPosicionMouse() + offset;
        rb.MovePosition(nuevaPosicion);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "fuego")
        {
            Debug.Log("Me quemo, tocaste el fuego");
        }
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