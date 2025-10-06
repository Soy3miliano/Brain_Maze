using UnityEngine;

public class ActivadorDeMenu : MonoBehaviour
{
    // Aquí arrastraremos nuestro panel del menú desde el editor de Unity
    public GameObject panelDelMenu;

    // Esta función se llama automáticamente cuando otro objeto entra en el trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Comprobamos si el objeto que entró tiene la etiqueta "Player"
        // (Asegúrate de que tu jugador tenga esta etiqueta en el Inspector)
        if (other.CompareTag("Player"))
        {
            // Si es el jugador, activamos el panel del menú
            if (panelDelMenu != null)
            {
                panelDelMenu.SetActive(true);
            }
        }
    }
}

