using UnityEngine;

public class SawBlade : MonoBehaviour
{
    public float speed = 1000f;
    private bool _isSpinning = false;

    private void Update()
    {
        if (_isSpinning)
        {
            transform.Rotate(Vector3.up * (speed * Time.deltaTime));
        }
    }
    
    public void ToggleSpinning()
    {
        _isSpinning = !_isSpinning;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Log triggered");
        
        if (!_isSpinning) return;

        Debug.Log("Log triggered and spinning");
        
        var log = other.GetComponent<Log>();
        
        if (log != null)
        {
            Debug.Log("CUT!!!!");
            log.CutLog(other.GetComponent<GameObject>()); // Call the CutLog method from the Log script
        }
    }
}
