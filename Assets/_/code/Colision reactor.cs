using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Collisionreactor : MonoBehaviour
{ public UnityEvent m_OncollisionEnter;
  public UnityEvent m_OncollisionExit;
  public UnityEvent m_OnCollisionStay;
    public void OnCollisionEnter(Collision collision)
    {
        m_OncollisionEnter.Invoke();
     }

    public void OnCollisionStay(Collision collision)
    {m_OnCollisionStay.Invoke();
        
    }
    public void OnCollisionExit(Collision collision)
    {
        m_OncollisionExit.Invoke();
    }

}