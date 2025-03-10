﻿using NoteTweaks.Configuration;
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
    }
}