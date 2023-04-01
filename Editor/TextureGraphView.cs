using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;
namespace Thermofusion.TextureGraph.Editor
{
    public class TextureGraphView : GraphView
    {
        public new class UxmlFactory : UxmlFactory<TextureGraphView> { }

        public new class UxmlTraits : VisualElement.UxmlTraits
        {
            UxmlStringAttributeDescription m_Status = new UxmlStringAttributeDescription { name = "graph" };

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
            {
                get { yield break; }
            }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);
                ((TextureGraphView)ve).status = m_Status.GetValueFromBag(bag, cc);
            }
        }
        string m_Status = string.Empty;
        public string status { get; set; }
        public TextureGraphView()
        {
            style.flexGrow = 1;
            Insert(0, new GridBackground() { name = "grid_background" });
            this.AddManipulator(new ContentZoomer());
            this.AddManipulator(new ContentDragger());
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());

            //Undo.undoRedoPerformed += UndoRedoPerformed;
        }

    }
}