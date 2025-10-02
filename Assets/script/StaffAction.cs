using UnityEngine;

public abstract class StaffAction : ScriptableObject // Using ScriptableObjects for easy management in inspector
{
    public Sprite actionIcon; // Optional: icon for UI if you have one
    public string targetTag; // Tag of the object this action can be performed on (e.g., "Grass", "Soil", "Crop")
    public Sprite resultSprite; // Sprite to change into after action (e.g., "Soil" sprite for "Grass")
    public AnimationClip actionAnimation; // Animation to play

    // This is the core method to implement by specific actions
    public abstract void PerformAction(GameObject targetObject, GameObject player);
}