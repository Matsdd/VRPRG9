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
        if (!_isSpinning) return;

        var cuttable = other.GetComponent<ICuttable>();
        if (cuttable != null)
        {
            cuttable.CutLog(other.gameObject);
        }
    }

}
