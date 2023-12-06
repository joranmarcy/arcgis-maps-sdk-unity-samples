// COPYRIGHT 1995-2022 ESRI
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
using Esri.ArcGISMapsSDK.Renderer.GPUResources;
using Esri.HPFramework;
using Unity.Mathematics;
using UnityEngine;

namespace Esri.ArcGISMapsSDK.Renderer.Renderables
{
	internal class Renderable : IRenderable
	{
		double3 pivot;

		public GameObject RenderableGameObject { get; }

		public IGPUResourceMaterial Material
		{
			get
			{
				var material = RenderableGameObject.GetComponent<MeshRenderer>().material;

				if (material != null)
				{
					return new GPUResourceMaterial(material);
				}

				return null;
			}

			set
			{
				RenderableGameObject.GetComponent<MeshRenderer>().material = value.NativeMaterial;
			}
		}

		public IGPUResourceMesh Mesh
		{
			get
			{
				var mesh = RenderableGameObject.GetComponent<MeshFilter>().sharedMesh;

				if (mesh != null)
				{
					return new GPUResourceMesh(mesh);
				}

				return null;
			}

			set
			{
				var meshFilter = RenderableGameObject.GetComponent<MeshFilter>();
				var collisionComponent = RenderableGameObject.GetComponent<MeshCollider>();

				var mesh = value != null ? value.NativeMesh : null;

				meshFilter.sharedMesh = mesh;
				collisionComponent.sharedMesh = collisionComponent.enabled ? mesh : null;
			}
		}

		public double3 Pivot
		{
			get
			{
				return pivot;
			}
			set
			{
				pivot = value;

				var hpTransform = RenderableGameObject.GetComponent<HPTransform>();

				hpTransform.UniversePosition = value;
				hpTransform.UniverseRotation = Quaternion.identity;
				hpTransform.LocalScale = Vector3.one;
			}
		}

		public string Name
		{
			get
			{
				return RenderableGameObject.name;
			}

			set
			{
				RenderableGameObject.name = value;
			}
		}

		public bool IsVisible
		{
			get
			{
				return RenderableGameObject.activeInHierarchy;
			}

			set
			{
				RenderableGameObject.SetActive(value);
			}
		}

		public bool IsMeshColliderEnabled
		{
			get
			{
				return RenderableGameObject.GetComponent<MeshCollider>();
			}

			set
			{
				var component = RenderableGameObject.GetComponent<MeshCollider>();
				component.enabled = value;

				if (value)
				{
					component.sharedMesh = RenderableGameObject.GetComponent<MeshFilter>().sharedMesh;
				}
			}
		}

		public uint LayerId { get; set; } = 0;

		public OrientedBoundingBox OrientedBoundingBox { get; set; }
		public bool MaskTerrain { get; set; }

		public Renderable(GameObject gameObject)
		{
			RenderableGameObject = gameObject;
		}

		public void Destroy()
		{
			if (Application.isEditor)
			{
				GameObject.DestroyImmediate(RenderableGameObject);
			}
			else
			{
				GameObject.Destroy(RenderableGameObject);
			}
		}
	}
}
