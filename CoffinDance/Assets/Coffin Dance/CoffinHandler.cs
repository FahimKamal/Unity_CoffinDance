using UnityEngine;

public class CoffinHandler : MonoBehaviour
{
    public GameObject[] anchorGO;
    public Transform anchorTransform;
    public GameObject coffin;

    void Update()
    {
        var midFront = (anchorGO[0].transform.position + anchorGO[1].transform.position) * 0.5f;
        var midRight = (anchorGO[1].transform.position + anchorGO[2].transform.position) * 0.5f;
        var midBack = (anchorGO[2].transform.position + anchorGO[3].transform.position) * 0.5f;
        var midLeft = (anchorGO[3].transform.position + anchorGO[0].transform.position) * 0.5f;

        var mid = (midFront + midBack) * 0.5f;

        var vForward = midFront - midBack;
        vForward.Normalize();

        var vRight = midRight - midLeft;
        vRight.Normalize();

        var vUp = Vector3.Cross(vForward, vRight);

        coffin.transform.position = mid;
        coffin.transform.forward = vForward;
        coffin.transform.right = vRight;
        coffin.transform.up = vUp;

        var rot = coffin.transform.localEulerAngles;
        coffin.transform.localRotation = Quaternion.Euler(rot.x, anchorTransform.rotation.y, rot.z);

        // coffin.transform.localPosition = mid;
        // coffin.transform.localRotation = Quaternion.LookRotation(vForward, vUp);
    }
}