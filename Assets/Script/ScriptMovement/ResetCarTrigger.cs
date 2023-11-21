using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCarTrigger : MonoBehaviour
{
    [SerializeField] private CarMovement carMovement;
    [SerializeField] private TimeSecondsCar timeSecondsCar;
    [SerializeField] private Animator Masa;
    [SerializeField] private Animator CuerdaX;
    [SerializeField] private Animator CuerdaY;

    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            ResetAnimations();
            carMovement.ResetCarPosition();
        }
    }
    private void ResetAnimations()
    {
        Masa.enabled = false;
        CuerdaX.enabled = false;
        CuerdaY.enabled = false;
    }
}
