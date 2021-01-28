using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ground : Template
{
    public override void AssignSpawnPoint(Transform[] spawnPoints)
    {
        spawnPoint = spawnPoints[2];
    }
}
