using UnityEngine;

public class Botonesscript : MonoBehaviour
{
    public void Inicio()
    {
        Debug.Log("Hola estas en el Inicio");
    }

    public void Informacion()
    {
        Debug.Log("Esta página de Información fue creada usando Unity por Alejandra Bonilla");
    }

    public void Cita()
    {
        Debug.Log("¿Quieres agendar una cita? Por favor, contacta a nuestro correo electrónico: info@nuestraempresa.com");
    
        Application.Quit();
    }
}