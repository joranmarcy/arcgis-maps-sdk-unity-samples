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
using System;

namespace Esri.GameEngine.Layers
{
    /// <summary>
    /// A layer that may be used to visualize building models exported from Building Information Modeling (BIM) projects.
    /// </summary>
    /// <remarks>
    /// <see cref="GameEngine.Layers.ArcGISBuildingSceneLayer">ArcGISBuildingSceneLayer</see> defines a layer type that is used to visualize and interact with 3D building models developed
    /// using Building Information Modeling tools. The data in a Building Scene Layer may represent building features such
    /// as walls, light fixtures, mechanical ductwork, and so forth.
    /// 
    /// The data in a <see cref="GameEngine.Layers.ArcGISBuildingSceneLayer">ArcGISBuildingSceneLayer</see> is organized into a hierarchy of <see cref="GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer">ArcGISBuildingSceneSublayer</see>.        
    /// The Building Scene Layer may contain an Overview sublayer, which may be loaded to display the exterior shell 
    /// of the building. The Overview sublayer provides a means to quickly visualize a building's exterior, in cases
    /// where visualization of interior features is not required.
    /// 
    /// If an Overview sublayer exists, the sublayers of the Building Scene Layer are placed into a hierarchy with a FullModel 
    /// sublayer as the root sublayer. A FullModel sublayer contains all building components which are organized
    /// into a hierarchy of sublayers and grouped by discipline (such as Architectural, Mechanical, or Structural).
    /// If no Overview sublayer is present, sublayers are instead placed into a hierarchy with major discipline sublayers 
    /// at each root.
    /// </remarks>
    /// <seealso cref="GameEngine.Layers.Base.ArcGISLayer">ArcGISLayer</seealso>
    /// <since>1.2.0</since>
    [StructLayout(LayoutKind.Sequential)]
    public partial class ArcGISBuildingSceneLayer :
        GameEngine.Layers.Base.ArcGISLayer
    {
        #region Constructors
        /// <summary>
        /// Creates a new building scene layer.
        /// </summary>
        /// <param name="source">Layer source</param>
        /// <param name="APIKey">API Key used to load data.</param>
        /// <since>1.2.0</since>
        public ArcGISBuildingSceneLayer(string source, string APIKey) :
            base(IntPtr.Zero)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            Handle = PInvoke.RT_GEBuildingSceneLayer_create(source, APIKey, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        
        /// <summary>
        /// Creates a new building scene layer.
        /// </summary>
        /// <param name="source">Layer source.</param>
        /// <param name="name">Layer name</param>
        /// <param name="opacity">Layer opacity.</param>
        /// <param name="visible">Layer visible or not.</param>
        /// <param name="APIKey">API Key used to load data.</param>
        /// <since>1.2.0</since>
        public ArcGISBuildingSceneLayer(string source, string name, float opacity, bool visible, string APIKey) :
            base(IntPtr.Zero)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            Handle = PInvoke.RT_GEBuildingSceneLayer_createWithProperties(source, name, opacity, visible, APIKey, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        #endregion // Constructors
        
        #region Properties
        /// <summary>
        /// The <see cref="GameEngine.Layers.ArcGISSpatialFeatureFilter">ArcGISSpatialFeatureFilter</see> to apply to the layer.
        /// </summary>
        /// <remarks>
        /// Feature filtering is not supported on mobile devices.
        /// </remarks>
        /// <since>1.3.0</since>
        public ArcGISSpatialFeatureFilter FeatureFilter
        {
            get
            {
                var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
                
                var localResult = PInvoke.RT_GEBuildingSceneLayer_getFeatureFilter(Handle, errorHandler);
                
                Unity.ArcGISErrorManager.CheckError(errorHandler);
                
                ArcGISSpatialFeatureFilter localLocalResult = null;
                
                if (localResult != IntPtr.Zero)
                {
                    localLocalResult = new ArcGISSpatialFeatureFilter(localResult);
                }
                
                return localLocalResult;
            }
            set
            {
                var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
                
                var localValue = value == null ? System.IntPtr.Zero : value.Handle;
                
                PInvoke.RT_GEBuildingSceneLayer_setFeatureFilter(Handle, localValue, errorHandler);
                
                Unity.ArcGISErrorManager.CheckError(errorHandler);
            }
        }
        
        /// <summary>
        /// An immutable collection of <see cref="">BuildingSceneSublayer</see>.
        /// </summary>
        /// <seealso cref="">BuildingSceneSublayer</seealso>
        /// <seealso cref="GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection">ArcGISBuildingSceneSublayerImmutableCollection</seealso>
        /// <since>1.2.0</since>
        public Unity.ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> Sublayers
        {
            get
            {
                var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
                
                var localResult = PInvoke.RT_GEBuildingSceneLayer_getSublayers(Handle, errorHandler);
                
                Unity.ArcGISErrorManager.CheckError(errorHandler);
                
                Unity.ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> localLocalResult = null;
                
                if (localResult != IntPtr.Zero)
                {
                    localLocalResult = new Unity.ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer>(localResult);
                }
                
                return localLocalResult;
            }
        }
        #endregion // Properties
        
        #region Internal Members
        internal ArcGISBuildingSceneLayer(IntPtr handle) : base(handle)
        {
        }
        #endregion // Internal Members
    }
    
    internal static partial class PInvoke
    {
        #region P-Invoke Declarations
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_GEBuildingSceneLayer_create([MarshalAs(UnmanagedType.LPStr)]string source, [MarshalAs(UnmanagedType.LPStr)]string APIKey, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_GEBuildingSceneLayer_createWithProperties([MarshalAs(UnmanagedType.LPStr)]string source, [MarshalAs(UnmanagedType.LPStr)]string name, float opacity, [MarshalAs(UnmanagedType.I1)]bool visible, [MarshalAs(UnmanagedType.LPStr)]string APIKey, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_GEBuildingSceneLayer_getFeatureFilter(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_GEBuildingSceneLayer_setFeatureFilter(IntPtr handle, IntPtr featureFilter, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_GEBuildingSceneLayer_getSublayers(IntPtr handle, IntPtr errorHandler);
        #endregion // P-Invoke Declarations
    }
}