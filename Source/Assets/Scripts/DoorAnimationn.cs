using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationn : MonoBehaviour
{
    public string animationName;
    Animation anim;
    public bool isCollided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OnCollisionEnter(Collision collision)
  {
      if(collision.gameObject.CompareTag("Player"))
      {
          isCollided=true;
         // anim.enabled=true;
         anim.enabled=true;
      }
  }
}
