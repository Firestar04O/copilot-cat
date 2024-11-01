using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVDMovementandeffect : MonoBehaviour
{
    public float movementspeed = 0;
    int directionX = 1;
    int directionY = 1;
    private Transform _Transform;
    private SpriteRenderer _SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
        _SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _Transform.position = new Vector2(_Transform.position.x + movementspeed * directionX * Time.deltaTime ,_Transform.position.y + movementspeed * directionY * Time.deltaTime);
        if (_Transform.position.x > 6.865f)
        {
            directionX = -1;
            _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
            _SpriteRenderer.flipY = !_SpriteRenderer.flipY;
            _SpriteRenderer.color = new Color(Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f);
        }
        else if (_Transform.position.x < -6.865f)
        {
            _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
            _SpriteRenderer.flipY = !_SpriteRenderer.flipY;
            directionX = 1;
            _SpriteRenderer.color = new Color(Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f);
        }

        if (_Transform.position.y > 4.101f)
        {
            _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
            _SpriteRenderer.flipY = !_SpriteRenderer.flipY;
            directionY = -1;
            _SpriteRenderer.color = new Color(Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f);
        }
        else if (_Transform.position.y < -4.1f)
        {
            _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
            _SpriteRenderer.flipY = !_SpriteRenderer.flipY;
            directionY = 1;
            _SpriteRenderer.color = new Color(Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f, Random.Range(1, 101) / 255f);
        }
    }
}
