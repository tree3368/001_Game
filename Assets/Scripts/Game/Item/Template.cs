using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Template : MonoBehaviour
{
    [SerializeField] protected int quantity;
    [SerializeField] protected float offsetX;

    protected Transform spawnPoint;

    public int Quantity => quantity;
    public float OffsetX => offsetX;
    public Transform SpawnPoint => spawnPoint;

    public abstract void AssignSpawnPoint(Transform[] spawnPoints);
}
