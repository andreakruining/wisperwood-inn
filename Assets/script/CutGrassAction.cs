using UnityEngine;

// Make sure to create a folder like "ScriptableObjects/Actions" and then right-click -> Create -> YourGameName -> CutGrassAction
[CreateAssetMenu(fileName = "CutGrassAction", menuName = "YourGame/StaffActions/CutGrassAction")]
public class CutGrassAction : StaffAction
{
    public override void PerformAction(GameObject targetObject, GameObject player)
    {
        Debug.Log($"Performing CutGrassAction on {targetObject.name}");

        // 1. Change the sprite to soil
        SpriteRenderer targetSpriteRenderer = targetObject.GetComponent<SpriteRenderer>();
        if (targetSpriteRenderer != null && resultSprite != null)
        {
            targetSpriteRenderer.sprite = resultSprite;
            // You might also want to change the tag of the object here if tags are used for logic
            // targetObject.tag = "Soil";
        }

        // 2. Play an animation (This part is more complex and depends on how you've set up animations)
        // For now, we'll just log that an animation should play.
        // If you're using an Animator component:
        // Animator animator = targetObject.GetComponent<Animator>();
        // if (animator != null && actionAnimation != null)
        // {
        //     animator.Play(actionAnimation.name); // Assuming actionAnimation is a clip
        // }
        // Or if the player's staff has an animation:
        // Animator playerAnimator = player.GetComponent<Animator>();
        // if (playerAnimator != null && actionAnimation != null)
        // {
        //     playerAnimator.Play(actionAnimation.name);
        // }

        // 3. Add any other logic, like playing a sound effect.
    }
}