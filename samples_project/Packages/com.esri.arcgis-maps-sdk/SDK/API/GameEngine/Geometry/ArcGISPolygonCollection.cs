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

namespace Esri.GameEngine.Geometry
{
    /// <summary>
    /// Defines a mutable collection of <see cref="GameEngine.Geometry.ArcGISPolygon">ArcGISPolygon</see>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal partial class ArcGISPolygonCollection
    {
        #region Constructors
        /// <summary>
        /// Creates a vector. This allocates memory that must be deleted.
        /// </summary>
        internal ArcGISPolygonCollection()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            Handle = PInvoke.RT_PolygonCollection_create(errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        #endregion // Constructors
        
        #region Properties
        /// <summary>
        /// Determines the number of values in the vector.
        /// </summary>
        /// <remarks>
        /// The number of values in the vector. If an error occurs a 0 will be returned.
        /// </remarks>
        internal ulong Size
        {
            get
            {
                var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
                
                var localResult = PInvoke.RT_PolygonCollection_getSize(Handle, errorHandler);
                
                Unity.ArcGISErrorManager.CheckError(errorHandler);
                
                return localResult.ToUInt64();
            }
        }
        #endregion // Properties
        
        #region Methods
        /// <summary>
        /// Add a value to the vector.
        /// </summary>
        /// <param name="value">The value that is to be added.</param>
        /// <returns>
        /// The position of the value. Max value of size_t if an error occurs.
        /// </returns>
        internal ulong Add(ArcGISPolygon value)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localValue = value.Handle;
            
            var localResult = PInvoke.RT_PolygonCollection_add(Handle, localValue, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult.ToUInt64();
        }
        
        /// <summary>
        /// Appends a vector to a vector.
        /// </summary>
        /// <param name="vector2">The value that is to be added.</param>
        /// <returns>
        /// The new size of vector_1. Max value of size_t if an error occurs.
        /// </returns>
        internal ulong AddArray(Unity.ArcGISCollection<ArcGISPolygon> vector2)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localVector2 = vector2.Handle;
            
            var localResult = PInvoke.RT_PolygonCollection_addArray(Handle, localVector2, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult.ToUInt64();
        }
        
        /// <summary>
        /// Get a value at a specific position.
        /// </summary>
        /// <remarks>
        /// Retrieves the value at the specified position.
        /// </remarks>
        /// <param name="position">The position which you want to get the value.</param>
        /// <returns>
        /// The value, <see cref="GameEngine.Geometry.ArcGISPolygon">ArcGISPolygon</see>, at the position requested.
        /// </returns>
        internal ArcGISPolygon At(ulong position)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localPosition = new UIntPtr(position);
            
            var localResult = PInvoke.RT_PolygonCollection_at(Handle, localPosition, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            ArcGISPolygon localLocalResult = null;
            
            if (localResult != IntPtr.Zero)
            {
                localLocalResult = new ArcGISPolygon(localResult);
            }
            
            return localLocalResult;
        }
        
        /// <summary>
        /// Does the vector contain the given value.
        /// </summary>
        /// <remarks>
        /// Does the vector contain a specific value.
        /// </remarks>
        /// <param name="value">The value you want to find.</param>
        /// <returns>
        /// True if the value is in the vector otherwise false.
        /// </returns>
        internal bool Contains(ArcGISPolygon value)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localValue = value.Handle;
            
            var localResult = PInvoke.RT_PolygonCollection_contains(Handle, localValue, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult;
        }
        
        /// <summary>
        /// Returns true if the two vectors are equal, false otherwise.
        /// </summary>
        /// <param name="vector2">The second vector.</param>
        /// <returns>
        /// Returns true if the two vectors are equal, false otherwise.
        /// </returns>
        internal bool Equals(Unity.ArcGISCollection<ArcGISPolygon> vector2)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localVector2 = vector2.Handle;
            
            var localResult = PInvoke.RT_PolygonCollection_equals(Handle, localVector2, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult;
        }
        
        /// <summary>
        /// Get the first value in the vector.
        /// </summary>
        /// <returns>
        /// The value, <see cref="GameEngine.Geometry.ArcGISPolygon">ArcGISPolygon</see>, at the position requested.
        /// </returns>
        internal ArcGISPolygon First()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localResult = PInvoke.RT_PolygonCollection_first(Handle, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            ArcGISPolygon localLocalResult = null;
            
            if (localResult != IntPtr.Zero)
            {
                localLocalResult = new ArcGISPolygon(localResult);
            }
            
            return localLocalResult;
        }
        
        /// <summary>
        /// Retrieves the position of the given value in the vector.
        /// </summary>
        /// <param name="value">The value you want to find.</param>
        /// <returns>
        /// The position of the value in the vector, Max value of size_t otherwise.
        /// </returns>
        internal ulong IndexOf(ArcGISPolygon value)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localValue = value.Handle;
            
            var localResult = PInvoke.RT_PolygonCollection_indexOf(Handle, localValue, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult.ToUInt64();
        }
        
        /// <summary>
        /// Insert a value at the specified position in the vector.
        /// </summary>
        /// <remarks>
        /// Insert a value at a specified position to the vector.
        /// </remarks>
        /// <param name="position">The position which you want to insert the value.</param>
        /// <param name="value">The value that is to be added.</param>
        internal void Insert(ulong position, ArcGISPolygon value)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localPosition = new UIntPtr(position);
            var localValue = value.Handle;
            
            PInvoke.RT_PolygonCollection_insert(Handle, localPosition, localValue, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        
        /// <summary>
        /// Determines if there are any values in the vector.
        /// </summary>
        /// <remarks>
        /// Check if the vector object has any values in it.
        /// </remarks>
        /// <returns>
        /// true if the  vector object contains no values otherwise false. Will return true if an error occurs.
        /// </returns>
        internal bool IsEmpty()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localResult = PInvoke.RT_PolygonCollection_isEmpty(Handle, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult;
        }
        
        /// <summary>
        /// Get the last value in the vector.
        /// </summary>
        /// <returns>
        /// The value, <see cref="GameEngine.Geometry.ArcGISPolygon">ArcGISPolygon</see>, at the position requested.
        /// </returns>
        internal ArcGISPolygon Last()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localResult = PInvoke.RT_PolygonCollection_last(Handle, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            ArcGISPolygon localLocalResult = null;
            
            if (localResult != IntPtr.Zero)
            {
                localLocalResult = new ArcGISPolygon(localResult);
            }
            
            return localLocalResult;
        }
        
        /// <summary>
        /// Move a value from the current position to a new position in the string vector.
        /// </summary>
        /// <remarks>
        /// Move a value from the current position to a new position in the vector.
        /// </remarks>
        /// <param name="oldPosition">The current position of the value.</param>
        /// <param name="newPosition">The position which you want to move the value to.</param>
        internal void Move(ulong oldPosition, ulong newPosition)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localOldPosition = new UIntPtr(oldPosition);
            var localNewPosition = new UIntPtr(newPosition);
            
            PInvoke.RT_PolygonCollection_move(Handle, localOldPosition, localNewPosition, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        
        /// <summary>
        /// Returns a value indicating a bad position within the vector.
        /// </summary>
        /// <returns>
        /// A size_t.
        /// </returns>
        internal static ulong Npos()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localResult = PInvoke.RT_PolygonCollection_npos(errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
            
            return localResult.ToUInt64();
        }
        
        /// <summary>
        /// Remove a value at a specific position in the vector.
        /// </summary>
        /// <param name="position">The position which you want to remove the value.</param>
        internal void Remove(ulong position)
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            var localPosition = new UIntPtr(position);
            
            PInvoke.RT_PolygonCollection_remove(Handle, localPosition, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        
        /// <summary>
        /// Remove all values from the vector.
        /// </summary>
        internal void RemoveAll()
        {
            var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
            
            PInvoke.RT_PolygonCollection_removeAll(Handle, errorHandler);
            
            Unity.ArcGISErrorManager.CheckError(errorHandler);
        }
        #endregion // Methods
        
        #region Internal Members
        internal ArcGISPolygonCollection(IntPtr handle) => Handle = handle;
        
        ~ArcGISPolygonCollection()
        {
            if (Handle != IntPtr.Zero)
            {
                var errorHandler = Unity.ArcGISErrorManager.CreateHandler();
                
                PInvoke.RT_PolygonCollection_destroy(Handle, errorHandler);
                
                Unity.ArcGISErrorManager.CheckError(errorHandler);
            }
        }
        
        internal IntPtr Handle { get; set; }
        #endregion // Internal Members
    }
    
    internal static partial class PInvoke
    {
        #region P-Invoke Declarations
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_PolygonCollection_create(IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern UIntPtr RT_PolygonCollection_getSize(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern UIntPtr RT_PolygonCollection_add(IntPtr handle, IntPtr value, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern UIntPtr RT_PolygonCollection_addArray(IntPtr handle, IntPtr vector2, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_PolygonCollection_at(IntPtr handle, UIntPtr position, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool RT_PolygonCollection_contains(IntPtr handle, IntPtr value, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool RT_PolygonCollection_equals(IntPtr handle, IntPtr vector2, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_PolygonCollection_first(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern UIntPtr RT_PolygonCollection_indexOf(IntPtr handle, IntPtr value, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_PolygonCollection_insert(IntPtr handle, UIntPtr position, IntPtr value, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool RT_PolygonCollection_isEmpty(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern IntPtr RT_PolygonCollection_last(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_PolygonCollection_move(IntPtr handle, UIntPtr oldPosition, UIntPtr newPosition, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern UIntPtr RT_PolygonCollection_npos(IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_PolygonCollection_remove(IntPtr handle, UIntPtr position, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_PolygonCollection_removeAll(IntPtr handle, IntPtr errorHandler);
        
        [DllImport(Unity.Interop.Dll)]
        internal static extern void RT_PolygonCollection_destroy(IntPtr handle, IntPtr errorHandle);
        #endregion // P-Invoke Declarations
    }
}