using UnityEngine;
public class Player : MonoBehaviour
{
    private const string PipeTag = "PipePart";
    
    [SerializeField] private float _jumpForce = 5.5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) ||  Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.AddForce(transform.up * _jumpForce,ForceMode2D.Impulse);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(PipeTag))
        {
           SceneLoader.Instance.Lose();
        }
    }
}
  