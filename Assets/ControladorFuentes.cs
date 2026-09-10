using UnityEngine;
using TMPro;

public class ControladorFuentes : MonoBehaviour
{
    [Header("Configuración de Fuentes")]
    public TMP_FontAsset fuenteEstiloA;
    public TMP_FontAsset fuenteEstiloB;

     public void CambiarFuenteA(TMP_Text textoAModificar)
    {
        if (textoAModificar != null && fuenteEstiloA != null)
            textoAModificar.font = fuenteEstiloA;
    }

    public void CambiarFuenteB(TMP_Text textoAModificar)
    {
        if (textoAModificar != null && fuenteEstiloB != null)
            textoAModificar.font = fuenteEstiloB;
    }
}