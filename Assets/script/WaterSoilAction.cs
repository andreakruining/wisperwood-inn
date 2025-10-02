using UnityEngine;

[CreateAssetMenu(fileName = "WaterSoilAction", menuName = "YourGame/StaffActions/WaterSoilAction")]
public class WaterSoilAction : StaffAction
{
    // You might have other parameters here, like how much water, duration etc.
    public override void PerformAction(GameObject targetObject, GameObject player)
    {
        Debug.Log($"Performing WaterSoilAction on {targetObject.name}");

        // Logic to water the soil. This might involve:
        // - Changing the soil's state to "watered"
        // - Spawning a temporary water effect
        // - Starting a growth timer for a seed if one is present
        // - Playing a watering animation
    }
}