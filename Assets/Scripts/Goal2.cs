using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal2 : MonoBehaviour
{
     private void OnTriggerEnter(Collider other){
       PlayerController component = other.gameObject.GetComponent<PlayerController>();

       if(component != null){
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
       }
   }
}
