using UnityEngine;

[CreateAssetMenu(fileName = "New Spawner Settings", menuName = "Spawner Settings", order = 0)]
public class SpawnerSettings : ScriptableObject
{
    [Range(0f, 1f)]
    public float bombChance = 0.05f;

    public float minSpawnDelay = 0.25f;
    public float maxSpawnDelay = 1f;

    public float minAngle = -15f;
    public float maxAngle = 15f;

    public float minForce = 18f;
    public float maxForce = 22f;

    public float maxLifetime = 5f;
}
