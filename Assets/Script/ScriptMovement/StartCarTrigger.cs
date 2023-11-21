using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCarTrigger : MonoBehaviour
{
    [SerializeField] private CarMovement carMovement;
    [SerializeField] private TimeSecondsCar timeSecondsCar;
    [SerializeField] private Animator  Masa;
    [SerializeField] private Animator CuerdaX;
    [SerializeField] private Animator CuerdaY;
    private bool IsEnterStartCollider;
    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            carMovement.MoveCar();
            StartAnimations();
            IsEnterStartCollider = true;
            timeSecondsCar.IniciarAccion();
            Debug.Log("Car Enter Trigger!!");
        }            
    }
    private void StartAnimations ()
    {
        Masa.enabled = true;
        CuerdaX.enabled = true;
        CuerdaY.enabled = true;
    }

    public bool GetIsEnterStartCollider() => IsEnterStartCollider;

    public void SetIsEnterStartColliderFalse() => IsEnterStartCollider = false;
}
