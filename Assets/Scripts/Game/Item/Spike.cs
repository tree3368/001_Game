using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Spike : Template
{
    public override void AssignSpawnPoint()
    {
        SpawnPoint = FindObjectOfType<Spike>().transform;
    }
}
