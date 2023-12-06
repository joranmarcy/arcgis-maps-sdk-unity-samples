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

namespace Esri.GameEngine.Math
{
    /// <summary>
    /// A 4 dimensional vector made of doubles
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ArcGISDoubleVector4
    {
        /// <summary>
        /// The x parameter
        /// </summary>
        public double X;
        
        /// <summary>
        /// The y parameter
        /// </summary>
        public double Y;
        
        /// <summary>
        /// The z parameter
        /// </summary>
        public double Z;
        
        /// <summary>
        /// The w parameter
        /// </summary>
        public double W;
    }
}