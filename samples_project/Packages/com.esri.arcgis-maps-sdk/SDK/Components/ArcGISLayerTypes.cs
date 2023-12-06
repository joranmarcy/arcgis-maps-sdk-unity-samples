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
using UnityEngine;

namespace Esri.ArcGISMapsSDK.Components
{
	// This needs to be kept in parity with ArcGISLayerType
	public enum LayerTypes
	{
		[InspectorName("ArcGIS Image Layer")]
		ArcGISImageLayer = 0,

		[InspectorName("ArcGIS 3DObject Scene Layer")]
		ArcGIS3DObjectSceneLayer = 1,

		[InspectorName("ArcGIS Integrated Mesh Layer")]
		ArcGISIntegratedMeshLayer = 2,

		[InspectorName("ArcGIS Vector Tile Layer")]
		ArcGISVectorTileLayer = 6,

		[InspectorName("ArcGIS Building Scene Layer")]
		ArcGISBuildingSceneLayer = 7,

		ArcGISUnsupportedLayer = 4,

		ArcGISUnknownLayer = 5,
	}
}
