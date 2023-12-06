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
using System.Runtime.InteropServices;

namespace Esri.GameEngine.RCQ
{
    /// <summary>
    /// The parameters of the set renderable pivot command
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ArcGISSetRenderablePivotCommandParameters
    {
        /// <summary>
        /// The renderable parameter of this render command
        /// </summary>
        public uint RenderableId;
        
        /// <summary>
        /// The x parameter of this render command
        /// </summary>
        public double X;
        
        /// <summary>
        /// The y parameter of this render command
        /// </summary>
        public double Y;
        
        /// <summary>
        /// The z parameter of this render command
        /// </summary>
        public double Z;
    }
}