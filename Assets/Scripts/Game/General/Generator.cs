using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Generator : ObjectPool
{
    [SerializeField] private Template[] _templates;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 1;

    private void Start()
    {
        for (int i = 0; i < _templates.Length; i++)
            Initialize(_templates[i]);
    }

    private void Update()
    {
        ChangeTime();
    }

    private void ChangeTime()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _secondsBetweenSpawn)
        {
            if (TryGetObject(out Template template))
            {
                _elapsedTime = 0;               
                MoveItem(template);
            }
        }
    }

    private void MoveItem(Template item)
    {
        item.transform.position = new Vector3(item.SpawnPoint.position.x, item.SpawnPoint.position.y, transform.position.z);
        item.gameObject.SetActive(true);
        item.SpawnPoint.position += new Vector3(item.OffsetX, 0);
    }
}
