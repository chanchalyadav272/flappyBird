using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundPlay : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float speedX;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speedX * Time.deltaTime, 0);
    }
}
