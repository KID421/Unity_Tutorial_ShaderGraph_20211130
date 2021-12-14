using System.Collections;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public Material m;
    public string propertyDissolve = "dissolve";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StopAllCoroutines();
            StartCoroutine(DissolveEffect());
        }
    }

    private IEnumerator DissolveEffect()
    {
        float dissolve = m.GetFloat(propertyDissolve);
        float increase = dissolve > 0 ? -0.1f : 0.1f;

        for (int i = 0; i < 35; i++)
        {
            dissolve += increase;
            print(dissolve);
            m.SetFloat(propertyDissolve, dissolve);
            yield return new WaitForSeconds(0.03f);
        }
    }
}
