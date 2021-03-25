using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nueva Zona", menuName = "zona", order = 1)]
public class Zona : ScriptableObject
{
    [SerializeField]
    public string titulo = "Zona";

    [SerializeField, TextArea(3, 10)]
    public string description;

    [SerializeField]
    public Sprite image;
}
