/*using UnityEngine;
using EzySlice;
public class FruitSlice : MonoBehaviour
{
    public Material cutMaterial; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blade")) 
        {
            SliceFruit();
        }
    }
    void SliceFruit()
    {
        SlicedHull slicedObject = gameObject.Slice(transform.position, transform.up, cutMaterial);
        if (slicedObject != null)
        {
            GameObject upperPart = slicedObject.CreateUpperHull(gameObject, cutMaterial);
            GameObject lowerPart = slicedObject.CreateLowerHull(gameObject, cutMaterial);
            AddPhysics(upperPart);
            AddPhysics(lowerPart);
            Destroy(gameObject); 
        }
    }
    void AddPhysics(GameObject obj)
    {
        obj.AddComponent<Rigidbody>().AddForce(Vector3.up * 2f, ForceMode.Impulse);
        obj.AddComponent<MeshCollider>().convex = true;
    }
}*/