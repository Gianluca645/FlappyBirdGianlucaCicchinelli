using UnityEngine;

public class PipeScore : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag=="Player")
        {
            ScoreBoardManager scoreBoardManager = FindAnyObjectByType<ScoreBoardManager>();
            if(scoreBoardManager) scoreBoardManager.IncreaseScore(1);
            Destroy(this.gameObject);

            // Esto sigue la misma lógica que en el ProcessHit del PlayerCollisionManager
            // Pero ahora eliminamos el objeto que contiene este script. Así no puntua dos veces por ejemplo.

        }





    }
}
