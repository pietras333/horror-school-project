using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDestroyer : MonoBehaviour
{
    [Header("GameObject Destroyer")]
    [Space]
    [SerializeField, Range(0,50)] float longevity; 

    void Start(){
        Invoke("destroy", longevity);
    }

    void destroy(){
        Destroy(this.transform.gameObject);
    }
}
