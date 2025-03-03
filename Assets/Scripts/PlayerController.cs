using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviourPun
{
    public float speed = 5f;
    private FixedJoystick joystick; // On ne met plus "public" car on va l'assigner dynamiquement
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Trouver le joystick dynamiquement dans la scène
        joystick = FindObjectOfType<FixedJoystick>();

        // Vérifier si le joueur est bien celui du client local
        if (!photonView.IsMine)
        {
            Destroy(this);  // Empêche les autres joueurs de contrôler ce personnage
        }
    }

    private void Update()
    {
        if (!photonView.IsMine) return;

        // Récupérer les entrées du joystick
        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical;

        // Appliquer le déplacement
        Vector2 movement = new Vector2(moveX, moveY) * speed;
        rb.linearVelocity = movement;
    }
}
