using System.Collections;
using UnityEngine;
namespace Syy.Camera
{
    public class CameraShake : MonoBehaviour
    {
        Vector3 originPosition;
        Quaternion originRotation;

        public float shakeDecay = 0.002f;
        public float shakeIntensitiy;
        public float _initShakeIntensity;

        System.Random Random = new System.Random();

        void Awake()
        {
            _initShakeIntensity = shakeIntensitiy;
        }

        public IEnumerator Shake()
        {
            originPosition = transform.position;
            originRotation = transform.rotation;

            while(shakeIntensitiy > 0)
            {
                transform.position = originPosition + UnityEngine.Random.insideUnitSphere * shakeIntensitiy;
                transform.rotation = new Quaternion(
                    originRotation.x + RandomRange(-shakeIntensitiy, shakeIntensitiy) * .2f,
                    originRotation.y + RandomRange(-shakeIntensitiy, shakeIntensitiy) * .2f,
                    originRotation.z + RandomRange(-shakeIntensitiy, shakeIntensitiy) * .2f,
                    originRotation.w + RandomRange(-shakeIntensitiy, shakeIntensitiy) * .2f);
                    shakeIntensitiy -= shakeDecay;
                    yield return false;
            }
            shakeIntensitiy = _initShakeIntensity;
            yield break;
        }

        public float RandomRange(float min, float max)
        {
            return min + ((float)Random.NextDouble() * (max - min));
        }

        public int RandomRange(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}
