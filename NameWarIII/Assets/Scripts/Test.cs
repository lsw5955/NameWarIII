using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public SpriteMask maskLeft;
    public SpriteMask maskRight;
    public GameObject maskPivot;
    public float force;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void DisableLeftMask()
    {
        maskLeft.enabled = false;
    }

    public void DisableRightMask()
    {
        maskRight.enabled = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("我点了");
        var self = this;
        var other = Instantiate(this.gameObject,transform.position, Quaternion.identity).GetComponent<Test>();
        self.GetComponent<Test>().DisableRightMask();
        other.GetComponent<Test>().DisableLeftMask();

        self.rb.gravityScale = 1;
        other.rb.gravityScale = 1;

        self.FaShe(110);
        other.FaShe(70);

    }

    public void FaShe(int angle)
    {
        Vector3 direction = Quaternion.Euler(0, 0, angle) * Vector3.right;

        rb.AddForce(direction * force, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if(transform.position.y <= -20)
        {
            Destroy(this.gameObject);
        }
    }
}
