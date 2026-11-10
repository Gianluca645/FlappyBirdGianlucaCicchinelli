using UnityEngine;

public class TriggerActivator : MonoBehaviour
{
    [SerializeField] Dropper target;

    // Hago una referencia al Dropper para que active el bird attacker
    // y activar la gravedad para que caiga


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(target) target.Activate();
        }



    }
}
