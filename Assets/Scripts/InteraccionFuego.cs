using UnityEngine;

public class InteraccionFuego : MonoBehaviour
{
    public GameObject burbujas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Olla"))
        {
            burbujas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Olla"))
        {
            burbujas.SetActive(false);
        }
    }
}