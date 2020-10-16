using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TanksEditor : OdinEditorWindow {
    [MenuItem("NewEarthWars/TankManager")]
    private static void OpenWindow() {
        GetWindow<TanksEditor>().Show();
    }
}
