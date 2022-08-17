using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGameList : MonoBehaviour
{
    [SerializeField] private List<Arrow> arrowsInspect = new List<Arrow>();
    private static Dictionary<Collider2D, Arrow> arrows = new Dictionary<Collider2D, Arrow>();

    private void Start()
    {
        foreach (var item in arrowsInspect)
        {
            arrows.Add(item.Collider, item);
        }
    }
    public static void AddArrow(Collider2D collider,Arrow arrow)
    {
        arrows.Add(collider, arrow);
    }
    public static Arrow GetArrow(Collider2D colider)
    {
        arrows.TryGetValue(colider, out Arrow arrow);
        return arrow;
    }
}
