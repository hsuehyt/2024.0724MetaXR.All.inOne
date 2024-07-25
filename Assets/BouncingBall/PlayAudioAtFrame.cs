using UnityEngine;

public class PlayAudioAtPosition : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform ballTransform;
    public float groundYPosition = 0.0f;
    public float tolerance = 0.1f; // Tolerance for checking if the ball is at ground position

    private bool hasPlayed = false;

    void Update()
    {
        // Check if the ball's y position is approximately equal to the ground position within the tolerance
        if (Mathf.Abs(ballTransform.position.y - groundYPosition) <= tolerance)
        {
            if (!hasPlayed)
            {
                audioSource.Play();
                hasPlayed = true;
                Debug.Log("Sound played");
            }
        }
        else
        {
            hasPlayed = false;
        }
    }
}
