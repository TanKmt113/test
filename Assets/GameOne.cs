using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOne : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        float speed = 5f; // biến để điều khiển tốc độ

        if (Input.GetKey(KeyCode.LeftArrow)) //nếu đầu vào Input là phím mũi tên trái
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); //dịch chuyển (Translate) vector 3 của vật (transform) sang trái
        }
        else if (Input.GetKey(KeyCode.RightArrow)) //nếu đầu vào Input là phím mũi tên phải
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed); //dịch chuyển (Translate) vector 3 của vật (transform) sang phải
        }
        else if (Input.GetKey(KeyCode.UpArrow)) //nếu đầu vào Input là phím mũi tên lên
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed); //dịch chuyển (Translate) vector 3 của vật (transform) lên trên
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //nếu đầu vào Input là phím mũi tên xuống
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed); //dịch chuyển (Translate) vector 3 của vật (transform) xuống dưới
        }
        //lưu ý: các Vector3 phải *( Time.deltaTime * speed) để điều chỉnh tốc độ di chuyển phù hợp với nhịp game.

    }
}
