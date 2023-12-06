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
// Unity
using System;
using System.Collections.Generic;

namespace Esri.ArcGISMapsSDK.Security
{
	enum ArcGISAuthenticationConfigurationType
	{
		OAuth = 0,
	}

	[Serializable]
	public class ArcGISAuthenticationConfigurationInstanceData
	{
		public string Name;
		public string ClientID;
		public string RedirectURI;

		private ArcGISAuthenticationConfigurationType Type;
	}

	[Serializable]
	public class OAuthAuthenticationConfigurationMapping
	{
		public int ConfigurationIndex = -1;

		public static OAuthAuthenticationConfigurationMapping NoConfiguration
		{
			get
			{
				return new OAuthAuthenticationConfigurationMapping();
			}
		}

		public override bool Equals(object obj)
		{
			return obj is OAuthAuthenticationConfigurationMapping mapping &&
				   ConfigurationIndex == mapping.ConfigurationIndex;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(ConfigurationIndex);
		}

		public static bool operator !=(OAuthAuthenticationConfigurationMapping lhs, OAuthAuthenticationConfigurationMapping rhs)
		{
			return !(lhs == rhs);
		}

		public static bool operator ==(OAuthAuthenticationConfigurationMapping lhs, OAuthAuthenticationConfigurationMapping rhs)
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

	public static class OAuthAuthenticationConfigurationMappingExtensions
	{
		public static List<ArcGISAuthenticationConfigurationInstanceData> Configurations { get; set; }
	}
}
