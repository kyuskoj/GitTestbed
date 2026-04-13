using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A MonoBehaviour component that demonstrates basic Unity lifecycle methods and debug logging.
/// Outputs "Hello World!" on start and checks if the GameObject's name contains the letter "h".
/// </summary>
namespace MyGame
{
    public class Hello : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hello World!222 okok22334444");
            if (gameObject.name.Contains("h"))
            {
                Debug.Log("오케이2");
            }



        }
    }
}
