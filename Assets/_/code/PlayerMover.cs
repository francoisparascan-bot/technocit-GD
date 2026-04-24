using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float m_deadZoneTolerence = 0.1f;

    public void Move(Vector2 input)
    {
        Vector3 currentFrameInput = new Vector3(input.x, 0f, input.y);
        if (currentFrameInput.magnitude < m_deadZoneTolerence) return;

        Vector3 delta = currentFrameInput  * moveSpeed * Time.deltaTime;
        transform.position += delta;


    }
}
