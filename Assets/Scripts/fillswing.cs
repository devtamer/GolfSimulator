using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillswing : MonoBehaviour
{
    public Image img;
    public float speed = 3.0f;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return updatefill(0f, 1.0f, 5.0f);
            yield return updatefill(1.0f, 0f, 5.0f);
        }
    }

    // Update is called once per frame
    public IEnumerator updatefill(float start, float end, float wait)
    {
        float x = 0f;
        float rate = (1.0f / wait) * speed;
        while (x< 1.0f)
        {
            x += Time.deltaTime * rate;
            img.fillAmount = Mathf.Lerp(start, end, x);
            yield return null;
        }
    }
}
