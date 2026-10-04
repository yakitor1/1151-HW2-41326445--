using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector2[] path;
    int cur = 0;
    public float speed = 2f;//速度
    void Start()
    {
        path = new Vector2[3];
        path[0] = new Vector2(0f, 0f);//前走
        path[1] = new Vector2(4f, 3f);//上跳
        path[2] = new Vector2(8f, 0f);//下落
    }

    // Update is called once per frame
    void Update()
    {
        move(transform.position);//移動
    }

    void move(Vector2 playerPos)
    {
        if(cur < path.Length)
        {
            Vector2 targetPos = path[cur];//下一個目標點位置
            transform.position = Vector2.MoveTowards(playerPos, targetPos, speed * Time.deltaTime);//移動

            if(Vector2.Distance(playerPos, targetPos) < 0.1f)//到目標點
            {
                cur++;//往下一個目標點
            }
        }

    }
}
