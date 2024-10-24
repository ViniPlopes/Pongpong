using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleControle : MonoBehaviour
{
    public float speed = 5f;

    public string movementoAxisNameb = "Vertical"  ;

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveControler.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveControler.Instance.colorEnemy;
    }
    void Update()
    {
        float moveInput = Input.GetAxis(movementoAxisNameb);

        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}
