using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController1 : MonoBehaviour
{
    float _scrollingSpeed = 0.25f;
    Vector2 _currentPosition = new Vector2();
    MeshRenderer _renderer;
    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();   
    }

    void Update()
    {
        _currentPosition.x = _currentPosition.x + _scrollingSpeed * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPosition;
    }
}
