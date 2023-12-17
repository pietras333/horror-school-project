using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [Header("Jump Pad")]
    [Space]
    [Header("Customizable")]
    [Space]
    [SerializeField, Range(0,20)] float force;

    public void OnCollisionEnter(Collision other){
        if(other.transform.gameObject.GetComponent<Rigidbody>()){
            other.transform.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.up * force * 10f, ForceMode.Impulse);
        }
    }
}
