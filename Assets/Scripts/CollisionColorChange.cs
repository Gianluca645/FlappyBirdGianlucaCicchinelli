using UnityEngine;

public class CollisionColorChange : MonoBehaviour
{
    [SerializeField] public Color hitColor; 
   
    private void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "Player") GetComponent<MeshRenderer>().material.color = hitColor;
    }
}
