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
using Esri.GameEngine.Elevation.Base;
using System;
using System.Collections.Generic;

namespace Esri.ArcGISMapsSDK.Components
{
	[Serializable]
	public class ArcGISElevationSourceInstanceData
	{
		public string Name;
		[EnumFilter(typeof(ArcGISElevationSourceType), (int)ArcGISElevationSourceType.Unknown)]
		public ArcGISElevationSourceType Type;
		public string Source;
		public bool IsEnabled;
		public OAuthAuthenticationConfigurationMapping Authentication;
		public ArcGISElevationSource APIObject;

		public override bool Equals(object obj)
		{
			return obj is ArcGISElevationSourceInstanceData data &&
				   EqualityComparer<OAuthAuthenticationConfigurationMapping>.Default.Equals(Authentication, data.Authentication) &&
				   IsEnabled == data.IsEnabled &&
				   Name == data.Name &&
				   Source == data.Source &&
				   Type == data.Type;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Authentication, IsEnabled, Name, Source, Type);
		}

		public static bool operator !=(ArcGISElevationSourceInstanceData lhs, ArcGISElevationSourceInstanceData rhs)
		{
			return !(lhs == rhs);
		}

		public static bool operator ==(ArcGISElevationSourceInstanceData lhs, ArcGISElevationSourceInstanceData rhs)
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
