using UnityEngine;

public class MainDoor_Trigger : MonoBehaviour
{
     public Animator doorAnimator;

    bool played = false;

    void Start()
    {
        doorAnimator.enabled = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !played)
        {
            played = true;

            doorAnimator.enabled = true; 
            doorAnimator.Play("upside_open"); 
        }
    }
}
