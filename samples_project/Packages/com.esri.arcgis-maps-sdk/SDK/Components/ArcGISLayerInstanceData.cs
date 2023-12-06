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
using Esri.ArcGISMapsSDK.Security;
using Esri.ArcGISMapsSDK.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Esri.ArcGISMapsSDK.Components
{
	[Serializable]
	public class ArcGISLayerInstanceData
	{
		public string Name;
		[EnumFilter(typeof(LayerTypes), (int)LayerTypes.ArcGISUnsupportedLayer, (int)LayerTypes.ArcGISUnknownLayer)]
		public LayerTypes Type;
		[FileSelector]
		public string Source;
		[Range(0, 1)]
		public float Opacity;
		public bool IsVisible;
		public OAuthAuthenticationConfigurationMapping Authentication;

		public override bool Equals(object obj)
		{
			return obj is ArcGISLayerInstanceData data &&
				   EqualityComparer<OAuthAuthenticationConfigurationMapping>.Default.Equals(Authentication, data.Authentication) &&
				   IsVisible == data.IsVisible &&
				   Name == data.Name &&
				   Opacity == data.Opacity &&
				   Source == data.Source &&
				   Type == data.Type;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Authentication, IsVisible, Name, Opacity, Source, Type);
		}

		public static bool operator !=(ArcGISLayerInstanceData lhs, ArcGISLayerInstanceData rhs)
		{
			return !(lhs == rhs);
		}

		public static bool operator ==(ArcGISLayerInstanceData lhs, ArcGISLayerInstanceData rhs)
		{
			if (ReferenceEquals(lhs, rhs))
			{
				return true;
			}

			if (((object)lhs == null) || ((object)rhs == null))
			{
				return false;
			}

			return lhs.Equals(rhs);
		}
	}
}
