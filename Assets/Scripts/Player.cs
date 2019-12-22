using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerNumber = 1;
    public float jumpForce = 10f;
    public string currentColor;

    public Color colorRed;
    public Color colorYellow;
    public Color colorPurple;
    public Color colorBlue;

    public Image borders;
    public PlayerManager playerManager;
    public Spawner spawner;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetRandomColor();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Player"+playerNumber+"Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorChanger") == true)
        {
            SetRandomColor();
            spawner.Spawn();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.CompareTag(currentColor) == false || collision.CompareTag("DeathZone") == true)
        {
            Die();
        }
    }

    private void Die()
    {
        playerManager.GameOver();
        gameObject.SetActive(false);
    }

    private void SetRandomColor()
    {
        int randomIndex = Random.Range(0, 4);

        switch (randomIndex)
        {
            case 0:
                currentColor = "red";
                spriteRenderer.color = colorRed;
                borders.color = colorRed;
                break;
            case 1:
                currentColor = "yellow";
                spriteRenderer.color = colorYellow;
                borders.color = colorYellow;
                break;
            case 2:
                currentColor = "purple";
                spriteRenderer.color = colorPurple;
                borders.color = colorPurple;
                break;
            case 3:
                currentColor = "blue";
                spriteRenderer.color = colorBlue;
                borders.color = colorBlue;
                break;
            default:
                break;
        }
    }
}
