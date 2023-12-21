using UnityEngine;

[CreateAssetMenu(fileName = "NewRecipe", menuName = "Custom/Recipe")]
public class RecipeScriptableObject : ScriptableObject
{
    public string recipeName;
    public int woodAmount;
    public int stoneAmount;
    public int crystalAmount;
}
