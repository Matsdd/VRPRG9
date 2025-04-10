using UnityEngine;

public class ShortLog : MonoBehaviour, ICuttable
{
    public GameObject plankPrefab;

    public void CutLog(GameObject original)
    {
        Vector3 pos = original.transform.position;
        Quaternion rot = original.transform.rotation;

        Destroy(original);

        Instantiate(plankPrefab, pos + Vector3.left * 0.1f, rot);
        Instantiate(plankPrefab, pos + Vector3.right * 0.1f, rot);
    }

}