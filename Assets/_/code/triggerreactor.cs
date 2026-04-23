using JetBrains.Annotations;
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
    public void OnTriggerStay(Collider other)
    {
        m_OnTriggerStay.Invoke();

    }
    public void OnTriggerExit(Collider other)
    {
        m_OnTriggerExit.Invoke();
    }
}
