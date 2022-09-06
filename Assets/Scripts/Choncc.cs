using UnityEngine;

public class Choncc : MonoBehaviour
{
    public float bouncStrength;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Ball ball = coll.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            Vector2 normal = coll.GetContact(0).normal;
            ball.AddForce(-normal * this.bouncStrength);
        }

    }
}
