using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Brick Settings", menuName = "Brick Settings")]
public class BrickSettings : ScriptableObject
{
    public int columns = 5;
    public int rows = 5;
    public List<Color> rowColors;
}
