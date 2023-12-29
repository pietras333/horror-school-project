using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsHandler : MonoBehaviour
{
    [Header("Footsteps Handler")]
    [Space]
    [Header("Neccesary")]
    [SerializeField] AudioSource footsteps;
    [SerializeField] Move move;

    void Start(){
        footsteps.gameObject.SetActive(false);
    }

    void Update(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if((horizontal != 0 || vertical != 0) && move.grounded){
            footsteps.gameObject.SetActive(true);
        }else{
            footsteps.gameObject.SetActive(false);
        }
    }
}
