using NoteTweaks.Configuration;
using UnityEngine;

namespace NoteTweaks.Managers
{
    internal abstract class Meshes
    {
        private static PluginConfig Config => PluginConfig.Instance;
        
        private static readonly Mesh TriangleArrowMesh = Utils.Meshes.GenerateBasicTriangleMesh();
        private static readonly Mesh LineArrowMesh = Utils.Meshes.GenerateBasicLineMesh();
        private static readonly Mesh ChevronArrowMesh = Utils.Meshes.GenerateChevronMesh();
        private static readonly Mesh PointyMesh = Utils.Meshes.GeneratePointyMesh(new Vector2(0f, -0.0165f));
        private static readonly Mesh PentagonArrowMesh = Utils.Meshes.GeneratePentagonMesh();
        private static Mesh _defaultArrowMesh;

        public static Mesh CurrentArrowMesh
        {
            get
            {
                switch (Config.ArrowMesh)
                {
                    case "Triangle":
                        return TriangleArrowMesh;
                    case "Line":
                        return LineArrowMesh;
                    case "Chevron":
                        return ChevronArrowMesh;
                    case "Pointy":
                        return PointyMesh;
                    case "Pentagon":
                        return PentagonArrowMesh;
                    default:
                        return _defaultArrowMesh;
                }
            }
        }

        internal static Mesh DotMesh = Utils.Meshes.GenerateFaceMesh(Config.DotMeshSides);

        public static void UpdateDefaultArrowMesh(Mesh mesh)
        {
            if (_defaultArrowMesh == null)
            {
                _defaultArrowMesh = mesh;
            }
        }

        private static readonly Mesh DefaultNoteMesh = Utils.Meshes.GenerateFaceMesh(6);
        private static readonly Mesh StarNoteMesh = Utils.Meshes.GenerateFaceMesh(10);
        private static readonly Mesh HeartNoteMesh = Utils.Meshes.GenerateFaceMesh(8);
        private static readonly Mesh DiamondNoteMesh = Utils.Meshes.GenerateFaceMesh(4);
        private static readonly Mesh HexagonNoteMesh = Utils.Meshes.GenerateFaceMesh(6);

        public static Mesh CurrentNoteMesh
        {
            get
            {
                switch (Config.NoteShape)
                {
                    case "Star":
                        return StarNoteMesh;
                    case "Heart":
                        return HeartNoteMesh;
                    case "Diamond":
                        return DiamondNoteMesh;
                    case "Hexagon":
                        return HexagonNoteMesh;
                    default:
                        return DefaultNoteMesh;
                }
            }
        }

        private static readonly Mesh DefaultArrowShape = Utils.Meshes.GenerateBasicTriangleMesh();
        private static readonly Mesh ArrowShape1 = Utils.Meshes.GenerateBasicLineMesh();
        private static readonly Mesh ArrowShape2 = Utils.Meshes.GenerateChevronMesh();
        private static readonly Mesh ArrowShape3 = Utils.Meshes.GeneratePointyMesh(new Vector2(0f, -0.0165f));
        private static readonly Mesh ArrowShape4 = Utils.Meshes.GeneratePentagonMesh();

        public static Mesh CurrentArrowShape
        {
            get
            {
                switch (Config.ArrowShape)
                {
                    case "Shape1":
                        return ArrowShape1;
                    case "Shape2":
                        return ArrowShape2;
                    case "Shape3":
                        return ArrowShape3;
                    case "Shape4":
                        return ArrowShape4;
                    default:
                        return DefaultArrowShape;
                }
            }
        }
    }
}
