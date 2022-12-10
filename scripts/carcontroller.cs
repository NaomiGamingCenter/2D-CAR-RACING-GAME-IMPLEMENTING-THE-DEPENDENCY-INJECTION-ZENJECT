using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class carcontroller : MonoBehaviour
{    public float carSpeed;
     public float minPosition = 8.4f;
     public float maxPosition = 7.7f;
     
     Vector3 position; 
     [Zenject.Inject] public uiManager ui;
      
    // Start is called before the first frame update
    void Start()
    {
      position = transform.position; 

    }

    // Update is called once per frame
    void Update()
    {
       position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
       position.x = Mathf.Clamp (position.x, -8.4f, 7.7f);

       transform.position = position;
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {   
        
        if(coll.gameObject.tag == "dodgecar")
        {
           Destroy (gameObject);
           ui.gameOverActivate();
           //SceneManager.LoadScene("GameOver");
        }
    }
   
} 

