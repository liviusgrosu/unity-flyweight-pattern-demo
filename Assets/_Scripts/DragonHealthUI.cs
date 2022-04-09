using UnityEngine;
using UnityEngine.UI;

public class DragonHealthUI : MonoBehaviour
{
    public Slider HealthBarSlider;
    public Dragon Dragon;

    void Start()
    {
        // Init the health bar
        HealthBarSlider.maxValue = Dragon.MaxHealth;
    }

    void Update()
    {
        // Update the health bar
        HealthBarSlider.value = Dragon.CurrentHealth;
    }
}
