FlashLight

using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light flashlight;

    private void Start()
    {
        flashlight = GetComponent<Light>();
    }

    private void Update()
    {
        // Обработка включения и выключения фонарика по нажатию клавиши F 
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
