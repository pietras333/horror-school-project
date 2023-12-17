using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationCarrier : MonoBehaviour
{
    [Header("Information Carrier")]
    [Space]
    [Header("Information")]
    [SerializeField] public string message;



    public void OnTriggerEnter(Collider collider){
        print(message);
        if(collider.transform.gameObject.CompareTag("Player")){
            collider.transform.gameObject.GetComponentInChildren<HUDAnimator>().hideInformationPopup();
            print("Player detected");
            collider.transform.gameObject.GetComponentInChildren<HUDAnimator>().informationPopup(message);
        }
    }
}
