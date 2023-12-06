// COPYRIGHT 1995-2023 ESRI
// TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
// Unpublished material - all rights reserved under the
// Copyright Laws of the United States and applicable international
// laws, treaties, and conventions.
//
// For additional information, contact:
// Attn: Contracts and Legal Department
// Environmental Systems Research Institute, Inc.
// 380 New York Street
// Redlands, California 92373
// USA
//
// email: legal@esri.com
namespace Esri.GameEngine.RCQ
{
    /// <summary>
    /// Mesh buffer change type
    /// </summary>
    public enum ArcGISMeshBufferChangeType
    {
        /// <summary>
        /// Vertex positions
        /// </summary>
        Positions = 0,
        
        /// <summary>
        /// Vertex normals
        /// </summary>
        Normals = 1,
        
        /// <summary>
        /// Vertex tangents
        /// </summary>
        Tangents = 2,
        
        /// <summary>
        /// Vertex colors
        /// </summary>
        Colors = 3,
        
        /// <summary>
        /// Vertex uvs, channel 0
        /// </summary>
        Uv0 = 4,
        
        /// <summary>
        /// Vertex uvs, channel 1
        /// </summary>
        Uv1 = 5,
        
        /// <summary>
        /// Vertex uvs, channel 2
        /// </summary>
        Uv2 = 6,
        
        /// <summary>
        /// Vertex uvs, channel 3
        /// </summary>
        Uv3 = 7
    };
}