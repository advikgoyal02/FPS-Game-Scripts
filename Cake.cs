using UnityEngine;

public class Cake : Interactable
{
    [SerializeField]
    private GameObject eatEffect;      // particle prefab, optional

    [SerializeField]
    private LevelCompleteUI levelCompleteUI;

    void Start()
    {
        promptMessage = "Eat Cake";

        if (levelCompleteUI == null)
            Debug.LogError("Cake has no LevelCompleteUI assigned on " + name, this);
    }

    protected override void Interact()
    {
        if (eatEffect != null)
        {
            // Spawned before Destroy so it isn't removed with the cake.
            Instantiate(eatEffect, transform.position, Quaternion.identity);
        }

        if (levelCompleteUI != null)
            levelCompleteUI.Show();

        Destroy(gameObject);
    }
}