using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para la navegación entre escenas

public class NavegacionEscenas : MonoBehaviour
{

    public void IrAEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
 
    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}