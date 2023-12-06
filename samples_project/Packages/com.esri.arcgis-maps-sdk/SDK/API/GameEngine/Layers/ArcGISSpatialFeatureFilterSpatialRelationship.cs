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
namespace Esri.GameEngine.Layers
{
    /// <summary>
    /// The spatial relationships of a spatial feature filter.
    /// </summary>
    /// <since>1.3.0</since>
    public enum ArcGISSpatialFeatureFilterSpatialRelationship
    {
        /// <summary>
        /// Keeps features that are fully outside the polygon.
        /// </summary>
        /// <since>1.3.0</since>
        Disjoint = 0,
        
        /// <summary>
        /// Keeps features that are fully inside the polygon.
        /// </summary>
        /// <since>1.3.0</since>
        Contains = 1
    };
}