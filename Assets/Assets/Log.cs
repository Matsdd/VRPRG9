
using UnityEngine;

public class Log : MonoBehaviour, ICuttable
{
    public GameObject shorterLogPrefab;

    public void CutLog(GameObject original)
    {
        Vector3 pos = original.transform.position;
        Quaternion rot = original.transform.rotation;

        Destroy(original);

        Instantiate(shorterLogPrefab, pos + Vector3.left * 0.1f, rot);
        Instantiate(shorterLogPrefab, pos + Vector3.right * 0.1f, rot);
    }

}
