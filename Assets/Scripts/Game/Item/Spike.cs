using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Spike : Template
{
    public override void AssignSpawnPoint(Transform[] spawnPoints)
    {
        spawnPoint = spawnPoints[0];
    }
}
