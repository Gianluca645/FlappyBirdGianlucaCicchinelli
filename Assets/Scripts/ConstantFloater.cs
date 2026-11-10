using UnityEngine;

public class ConstantFloater : MonoBehaviour
{
   
   
   [SerializeField] float amplitude = 2f; // Quiero que suba esto

   [SerializeField] float final_frequency = 1f; // la velocidad a la que quiero que oscile mi pipe
   
   Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition; // El valor inicial de la posición
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * final_frequency) * amplitude;

        transform.localPosition = new Vector3(startPos.x, newY, startPos.z);


        // TOmo la localPosition actual, modifico alguno de sus valores x,y,z (en este caso el eje Y) y le vuelvo a asignar localPosition

    }
}
