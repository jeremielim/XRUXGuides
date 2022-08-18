using UnityEngine;

public class SetParent : MonoBehaviour
{
    [SerializeField] private GameObject parent;

    
    private void OnEnable()
    {
        transform.SetParent(parent.transform);
    }
}