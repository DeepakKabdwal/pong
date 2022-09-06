using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 200.0f;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        //add force to x direction with random function
        //it gets a value b/w 0 and 1 
        //so if the value is more than 0.5 then one direction i fthe value is less then another 
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        //the reason the direction is not hardcoded is to make it random, otherwise the ball will just
        //go in one angle towards either side
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}
