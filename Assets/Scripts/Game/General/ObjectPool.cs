using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;

    private List<Template> _pool = new List<Template>();

    public List<Template> Pool => _pool;

    protected void Initialize(Template prefab)
    {
        for (int i = 0; i < prefab.Quantity;  i++)
        {
            Template spawned = Instantiate(prefab, _container.transform);
            spawned.gameObject.SetActive(false);
            _pool.Add(spawned);
            spawned.AssignSpawnPoint();
        }
    }

    protected bool TryGetObject(out Template result)
    {
        result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);
        return result != null;
    }
}
