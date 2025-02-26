using UnityEngine;

[CreateAssetMenu(menuName = "SO/Character Type")]
public class CharacterType : ScriptableObject
{
    public string[] Name => _name;
    public Sprite Icon => _icon;
    public int Id => _id;
    //public Weapon Weapon => _weapon;

    [SerializeField] private string[] _name;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _id;
    //[SerializeField] private Weapon _weapon;
}
