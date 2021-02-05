using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Template : MonoBehaviour
{
    [SerializeField] private int quantity;
    [SerializeField] private float offsetX;

    public Transform SpawnPoint { get; protected set; }
    public int Quantity => quantity;
    public float OffsetX => offsetX;

    public abstract void AssignSpawnPoint();
}
