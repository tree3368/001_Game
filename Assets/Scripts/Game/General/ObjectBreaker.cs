using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBreaker : MonoBehaviour
{
    [SerializeField] private Generator _generator;
    [SerializeField] private float _cameraOffsetX;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        DisableObjectAbroadScreen();
    }

    private void DisableObjectAbroadScreen()
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector2(_cameraOffsetX, 0));
        foreach (Template item in _generator.Pool)
        {
            if (item.gameObject.activeSelf == true)
            {
                if (item.transform.position.x < disablePoint.x)
                    item.gameObject.SetActive(false);
            }
        }
    }
}
