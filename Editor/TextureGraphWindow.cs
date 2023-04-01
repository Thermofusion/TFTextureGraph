using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
namespace Thermofusion.TextureGraph.Editor
{

    public class TextureGraphWindow : EditorWindow
    {

        [MenuItem("Window/Texture Graph/Debug")]
        public static void PrintDebug()
        {
            Debug.Log(typeof(TextureGraph).AssemblyQualifiedName);
        }

        [MenuItem("Window/Texture Graph/Texture Graph Window")]
        public static void ShowExample()
        {
            TextureGraphWindow wnd = GetWindow<TextureGraphWindow>();
            wnd.titleContent = new GUIContent("TextureGraphWindow");
        }

        public void CreateGUI()
        {
            // Each editor window contains a root VisualElement object
            VisualElement root = rootVisualElement;

            // VisualElements objects can contain other VisualElement following a tree hierarchy.
            // VisualElement label = new Label("Hello World! From C#");
            // root.Add(label);

            TextureGraphView graphView = new TextureGraphView();
            root.Add(graphView);

            var node = new UnityEditor.Experimental.GraphView.Node();
            node.title = "Node 1";
            node.SetPosition(new Rect(100, 100, 200, 200));
            graphView.AddElement(node);

            // Import UXML
            // var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/com.thermofusion.tftexturegraph/Editor/TextureGraphWindow.uxml");
            // VisualElement labelFromUXML = visualTree.Instantiate();
            // root.Add(labelFromUXML);

            // A stylesheet can be added to a VisualElement.
            // The style will be applied to the VisualElement and all of its children.
            // var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Packages/com.thermofusion.tftexturegraph/Editor/TextureGraphWindow.uss");
            // VisualElement labelWithStyle = new Label("Hello World! With Style");
            // labelWithStyle.styleSheets.Add(styleSheet);
            // root.Add(labelWithStyle);
        }
    }
}