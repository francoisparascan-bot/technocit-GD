using UnityEngine;
using UnityEngine.Events;

public class triggerreactor : MonoBehaviour
{
    public UnityEvent m_OnTriggerEnter;
    public UnityEvent m_OnTriggerStay;
    public UnityEvent m_OnTriggerExit;  
   

    public void OnTriggerEnter(Collider other)
    {
        m_OnTriggerEnter.Invoke();
    }

}
}
