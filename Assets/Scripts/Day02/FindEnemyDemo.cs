using UnityEngine;

public class FindEnemyDemo : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("查找血量最低的敌人"))
        {
            Enemy[] allEnemy = Object.FindObjectsOfType<Enemy>();
            Enemy min = FindEnemyByMinHP(allEnemy);
            min.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    public Enemy FindEnemyByMinHP(Enemy[] allEnemy)
    {
        Enemy min = allEnemy[0];

        for (int i = 0; i < allEnemy.Length; i++)
        {
            if (min.HP > allEnemy[i].HP)
            {
                min = allEnemy[i];
            }
        }
        return min;
    }
}