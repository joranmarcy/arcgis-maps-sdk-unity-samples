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

namespace Esri.Unity
{
    [StructLayout(LayoutKind.Sequential)]
    public class ArcGISImmutableCollection<T>
    {
        #region Internal Members
        internal ArcGISImmutableCollection(IntPtr handle) => Handle = handle;
    
        ~ArcGISImmutableCollection()
        {
            if (typeof (T) == typeof(GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer))
            {
                new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(Handle);
            }
            else if (typeof (T) == typeof(GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo))
            {
                new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(Handle);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    
        internal IntPtr Handle { get; private set; }
        #endregion // Internal Members
    }
    
    public static class ArcGISImmutableCollectionSpecialization
    {
        public static GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer At(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self, ulong position)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.At(position);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool Contains(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self, GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer value)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.Contains(value);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool Equals(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self, ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> vector2)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.Equals(vector2);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer First(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.First();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong GetSize(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.Size;
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong IndexOf(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self, GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer value)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.IndexOf(value);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool IsEmpty(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.IsEmpty();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer Last(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self)
        {
        	var collection = new GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection(self.Handle);
        
        	var result = collection.Last();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong Npos(this ArcGISImmutableCollection<GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayer> self)
        {
        	return GameEngine.Layers.BuildingScene.ArcGISBuildingSceneSublayerImmutableCollection.Npos();
        }
        
        public static GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo At(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self, ulong position)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.At(position);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool Contains(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self, GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo value)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.Contains(value);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool Equals(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self, ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> vector2)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.Equals(vector2);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo First(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.First();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong GetSize(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.Size;
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong IndexOf(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self, GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo value)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.IndexOf(value);
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static bool IsEmpty(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.IsEmpty();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo Last(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self)
        {
        	var collection = new GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection(self.Handle);
        
        	var result = collection.Last();
        
        	collection.Handle = IntPtr.Zero;
        
        	return result;
        }
        
        public static ulong Npos(this ArcGISImmutableCollection<GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo> self)
        {
        	return GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfoImmutableCollection.Npos();
        }
    }
}