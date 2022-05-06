using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve animationCurve;
    Animation anim;
    float curveTime = 3f;
    public float playerSpeed;
    public Vector3 currentPosition;
    void Start()
    {
      anim = GetComponent<Animation>();
        //animationCurve.Evaluate(curveTime);
    }

    // Update is called once per frame
    void Update()
    {

         currentPosition = transform.position;
        currentPosition.z += playerSpeed*Time.deltaTime;
        curveTime += Mathf.Clamp( curveTime,Time.time,10f);
        currentPosition.y = animationCurve.Evaluate(curveTime);
        print(currentPosition.y);
        transform.position = currentPosition;
    }
}
