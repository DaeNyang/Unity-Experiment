using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{

    

    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 haNosPackageColor = new Color32(1,1,1,1);
    [SerializeField] float DestroyDelay = 0.5f ;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)  //collider 충돌시 메세지 출력
    {
        Debug.Log("쾅!");
    }
   
    private void OnTriggerEnter2D(Collider2D other) //collider > is trigger 메세지 출력문
    {
        
        if(other.tag == "P" && !hasPackage)
        {
            Debug.Log("음 아주 맛있어 보이는 도넛이군!");
            hasPackage =  true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,DestroyDelay);
        }
        else if(other.tag == "C" && hasPackage)
        {
            Debug.Log("이 도넛 먹고 힘내라고 젊은이~");
            spriteRenderer.color = haNosPackageColor;
            hasPackage = false;
        }
    }
}
