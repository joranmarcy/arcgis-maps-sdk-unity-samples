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
namespace Esri.Standard
{
    /// <summary>
    /// The different types that a element can hold.
    /// </summary>
    /// <remarks>
    /// Each of the different supported element types. Can get the type by calling <see cref="">Element.objectType</see>.
    /// </remarks>
    /// <seealso cref="">Element</seealso>
    /// <seealso cref="">Element.objectType</seealso>
    public enum ArcGISElementType
    {
        /// <summary>
        /// An <see cref="">ArcGISFeature</see> object.
        /// </summary>
        ArcGISFeature = 0,
        
        /// <summary>
        /// An <see cref="">ArcGISFeatureServiceInfo</see> object.
        /// </summary>
        ArcGISFeatureServiceInfo = 1,
        
        /// <summary>
        /// Deprecated. For internal use within C-API only.
        /// </summary>
        ArcGISMapServiceInfo = 2,
        
        /// <summary>
        /// An ArcGIS sublayer object.
        /// </summary>
        ArcGISSublayer = 3,
        
        /// <summary>
        /// An array.
        /// </summary>
        Array = 4,
        
        /// <summary>
        /// An attachment value.
        /// </summary>
        Attachment = 5,
        
        /// <summary>
        /// A network analyst attribute parameter value.
        /// </summary>
        AttributeParameterValue = 6,
        
        /// <summary>
        /// An <see cref="">Basemap</see> object
        /// </summary>
        Basemap = 7,
        
        /// <summary>
        /// A bookmark object.
        /// </summary>
        Bookmark = 8,
        
        /// <summary>
        /// A boolean value.
        /// </summary>
        Bool = 9,
        
        /// <summary>
        /// A buffer value.
        /// </summary>
        Buffer = 10,
        
        /// <summary>
        /// A class break object.
        /// </summary>
        ClassBreak = 11,
        
        /// <summary>
        /// An <see cref="">CodedValue</see> object.
        /// </summary>
        CodedValue = 12,
        
        /// <summary>
        /// A class closest facility parameters.
        /// </summary>
        ClosestFacilityParameters = 13,
        
        /// <summary>
        /// A class closest facility result.
        /// </summary>
        ClosestFacilityResult = 14,
        
        /// <summary>
        /// A class closest facility route.
        /// </summary>
        ClosestFacilityRoute = 15,
        
        /// <summary>
        /// A class closest facility task.
        /// </summary>
        ClosestFacilityTask = 16,
        
        /// <summary>
        /// A color object.
        /// </summary>
        Color = 17,
        
        /// <summary>
        /// A network analyst cost attribute.
        /// </summary>
        CostAttribute = 18,
        
        /// <summary>
        /// A date time value.
        /// </summary>
        DateTime = 19,
        
        /// <summary>
        /// Element holds a dictionary.
        /// </summary>
        Dictionary = 20,
        
        /// <summary>
        /// A network analyst direction event.
        /// </summary>
        DirectionEvent = 21,
        
        /// <summary>
        /// A network analyst direction maneuver.
        /// </summary>
        DirectionManeuver = 22,
        
        /// <summary>
        /// A network analyst direction message.
        /// </summary>
        DirectionMessage = 23,
        
        /// <summary>
        /// An <see cref="">DistanceSymbolRange</see> object.
        /// </summary>
        DistanceSymbolRange = 24,
        
        /// <summary>
        /// A domain object.
        /// </summary>
        Domain = 25,
        
        /// <summary>
        /// The result of an edit to an attachment.
        /// </summary>
        EditResult = 26,
        
        /// <summary>
        /// An <see cref="">ElevationSource</see> object.
        /// </summary>
        ElevationSource = 27,
        
        /// <summary>
        /// An <see cref="">EstimateTileCacheSizeResult</see> object.
        /// </summary>
        EstimateTileCacheSizeResult = 28,
        
        /// <summary>
        /// An <see cref="">ExportTileCacheTask</see> object.
        /// </summary>
        ExportTileCacheTask = 29,
        
        /// <summary>
        /// An <see cref="">ExportTileCacheParameters</see> object.
        /// </summary>
        ExportTileCacheParameters = 30,
        
        /// <summary>
        /// An <see cref="">ExtensionLicense</see> object.
        /// </summary>
        ExtensionLicense = 31,
        
        /// <summary>
        /// A closest facility.
        /// </summary>
        Facility = 32,
        
        /// <summary>
        /// A feature object.
        /// </summary>
        Feature = 33,
        
        /// <summary>
        /// A feature collection object.
        /// </summary>
        FeatureCollection = 34,
        
        /// <summary>
        /// A feature collection table object.
        /// </summary>
        FeatureCollectionTable = 35,
        
        /// <summary>
        /// The result of an edit to a feature.
        /// </summary>
        FeatureEditResult = 36,
        
        /// <summary>
        /// A feature query result object.
        /// </summary>
        FeatureQueryResult = 37,
        
        /// <summary>
        /// An <see cref="">FeatureTable</see> object.
        /// </summary>
        FeatureTable = 38,
        
        /// <summary>
        /// A feature template object.
        /// </summary>
        FeatureTemplate = 39,
        
        /// <summary>
        /// A feature type object.
        /// </summary>
        FeatureType = 40,
        
        /// <summary>
        /// A field value.
        /// </summary>
        Field = 41,
        
        /// <summary>
        /// A 32 bit float value.
        /// </summary>
        Float32 = 42,
        
        /// <summary>
        /// A 64 bit float value.
        /// </summary>
        Float64 = 43,
        
        /// <summary>
        /// An <see cref="">GenerateGeodatabaseParameters</see> object.
        /// </summary>
        GenerateGeodatabaseParameters = 44,
        
        /// <summary>
        /// Options for a layer when generating a geodatabase using the sync task.
        /// </summary>
        GenerateLayerOption = 45,
        
        /// <summary>
        /// A result of geocode operation.
        /// </summary>
        GeocodeResult = 46,
        
        /// <summary>
        /// A geodatabase.
        /// </summary>
        Geodatabase = 47,
        
        /// <summary>
        /// A geodatabase feature table.
        /// </summary>
        GeodatabaseFeatureTable = 48,
        
        /// <summary>
        /// An <see cref="">GeodatabaseSyncTask</see> object
        /// </summary>
        GeodatabaseSyncTask = 49,
        
        /// <summary>
        /// A geometry value.
        /// </summary>
        Geometry = 50,
        
        /// <summary>
        /// An <see cref="">GeoprocessingFeatureSet</see> object.
        /// </summary>
        GeoprocessingFeatureSet = 51,
        
        /// <summary>
        /// An <see cref="">GeoprocessingParameter</see> object.
        /// </summary>
        GeoprocessingParameter = 52,
        
        /// <summary>
        /// A graphic object.
        /// </summary>
        Graphic = 53,
        
        /// <summary>
        /// A graphics overlay object.
        /// </summary>
        GraphicsOverlay = 54,
        
        /// <summary>
        /// A GUID value.
        /// </summary>
        GUID = 55,
        
        /// <summary>
        /// An object containing the results of an identify on a graphics overlay.
        /// </summary>
        IdentifyGraphicsOverlayResult = 56,
        
        /// <summary>
        /// An object containing the results of an identify on a layer.
        /// </summary>
        IdentifyLayerResult = 57,
        
        /// <summary>
        /// An <see cref="">IdInfo</see> object.
        /// </summary>
        IdInfo = 58,
        
        /// <summary>
        /// An image object.
        /// </summary>
        Image = 59,
        
        /// <summary>
        /// A closest facility incident.
        /// </summary>
        Incident = 60,
        
        /// <summary>
        /// A 16-bit integer value.
        /// </summary>
        Int16 = 61,
        
        /// <summary>
        /// A 32-bit integer value.
        /// </summary>
        Int32 = 62,
        
        /// <summary>
        /// A 64-bit integer value.
        /// </summary>
        Int64 = 63,
        
        /// <summary>
        /// A 8-bit integer value.
        /// </summary>
        Int8 = 64,
        
        /// <summary>
        /// An <see cref="">Job</see> object.
        /// </summary>
        Job = 65,
        
        /// <summary>
        /// A job message.
        /// </summary>
        JobMessage = 66,
        
        /// <summary>
        /// A KML node object.
        /// </summary>
        KMLNode = 67,
        
        /// <summary>
        /// A KML geometry object.
        /// </summary>
        KMLGeometry = 68,
        
        /// <summary>
        /// A label class object.
        /// </summary>
        LabelingInfo = 69,
        
        /// <summary>
        /// A layer object.
        /// </summary>
        Layer = 70,
        
        /// <summary>
        /// A legend info object.
        /// </summary>
        LegendInfo = 71,
        
        /// <summary>
        /// A tile info level of detail (LOD).
        /// </summary>
        LevelOfDetail = 72,
        
        /// <summary>
        /// An <see cref="">LoadableImage</see> object. For internal use within C-API only.
        /// </summary>
        LoadableImage = 73,
        
        /// <summary>
        /// An <see cref="">LocatorAttribute</see> object.
        /// </summary>
        LocatorAttribute = 74,
        
        /// <summary>
        /// An <see cref="">LocatorTask</see> object.
        /// </summary>
        LocatorTask = 75,
        
        /// <summary>
        /// An <see cref="">Map</see> object.
        /// </summary>
        Map = 76,
        
        /// <summary>
        /// An <see cref="">MobileBasemapLayer</see> object.
        /// </summary>
        MobileBasemapLayer = 77,
        
        /// <summary>
        /// An <see cref="">MobileMapPackage</see> object.
        /// </summary>
        MobileMapPackage = 78,
        
        /// <summary>
        /// An <see cref="">ModelSceneSymbol</see> object.
        /// </summary>
        ModelSceneSymbol = 79,
        
        /// <summary>
        /// An order by enum value.
        /// </summary>
        OrderBy = 80,
        
        /// <summary>
        /// An <see cref="">PictureMarkerSymbol</see> object.
        /// </summary>
        PictureMarkerSymbol = 81,
        
        /// <summary>
        /// A network analyst point barrier.
        /// </summary>
        PointBarrier = 82,
        
        /// <summary>
        /// A network analyst polygon barrier.
        /// </summary>
        PolygonBarrier = 83,
        
        /// <summary>
        /// A network analyst polyline barrier.
        /// </summary>
        PolylineBarrier = 84,
        
        /// <summary>
        /// A <see cref="">Popup</see> object.
        /// </summary>
        Popup = 85,
        
        /// <summary>
        /// A popup field representing how a geo-element's attribute (field) should be displayed in a pop-up.
        /// </summary>
        PopupField = 86,
        
        /// <summary>
        /// A popup media representing the media that is displayed in a pop-up for a geo-element.
        /// </summary>
        PopupMedia = 87,
        
        /// <summary>
        /// A <see cref="">Portal</see> object. For internal use within C-API only.
        /// </summary>
        Portal = 88,
        
        /// <summary>
        /// A <see cref="">PortalItem</see> object. For internal use within C-API only.
        /// </summary>
        PortalItem = 89,
        
        /// <summary>
        /// A <see cref="">Raster</see> object. For internal use within C-API only.
        /// </summary>
        Raster = 90,
        
        /// <summary>
        /// An attachment on a request object.
        /// </summary>
        RequestAttachment = 91,
        
        /// <summary>
        /// A network analyst restriction attribute.
        /// </summary>
        RestrictionAttribute = 92,
        
        /// <summary>
        /// A network analyst route.
        /// </summary>
        Route = 93,
        
        /// <summary>
        /// A network analyst route parameters.
        /// </summary>
        RouteParameters = 94,
        
        /// <summary>
        /// A network analyst route result.
        /// </summary>
        RouteResult = 95,
        
        /// <summary>
        /// An <see cref="">RouteTask</see> object.
        /// </summary>
        RouteTask = 96,
        
        /// <summary>
        /// An <see cref="">Scene</see> object.
        /// </summary>
        Scene = 97,
        
        /// <summary>
        /// A service area facility.
        /// </summary>
        ServiceAreaFacility = 98,
        
        /// <summary>
        /// A service area parameters.
        /// </summary>
        ServiceAreaParameters = 99,
        
        /// <summary>
        /// A service area polygon.
        /// </summary>
        ServiceAreaPolygon = 100,
        
        /// <summary>
        /// A service area polyline.
        /// </summary>
        ServiceAreaPolyline = 101,
        
        /// <summary>
        /// A service area result.
        /// </summary>
        ServiceAreaResult = 102,
        
        /// <summary>
        /// A service area task.
        /// </summary>
        ServiceAreaTask = 103,
        
        /// <summary>
        /// A network analyst stop.
        /// </summary>
        Stop = 104,
        
        /// <summary>
        /// A string value.
        /// </summary>
        String = 105,
        
        /// <summary>
        /// A result of suggest operation.
        /// </summary>
        SuggestResult = 106,
        
        /// <summary>
        /// An <see cref="">Surface</see> object.
        /// </summary>
        Surface = 107,
        
        /// <summary>
        /// A symbol object.
        /// </summary>
        Symbol = 108,
        
        /// <summary>
        /// An <see cref="">SymbolStyle</see> object.
        /// </summary>
        SymbolStyle = 109,
        
        /// <summary>
        /// An <see cref="">SymbolStyleSearchParameters</see> object.
        /// </summary>
        SymbolStyleSearchParameters = 110,
        
        /// <summary>
        /// An <see cref="">SymbolStyleSearchResult</see> object.
        /// </summary>
        SymbolStyleSearchResult = 111,
        
        /// <summary>
        /// An <see cref="">SyncGeodatabaseParameters</see> object.
        /// </summary>
        SyncGeodatabaseParameters = 112,
        
        /// <summary>
        /// An <see cref="">SyncLayerOption</see> object.
        /// </summary>
        SyncLayerOption = 113,
        
        /// <summary>
        /// An <see cref="">SyncLayerResult</see> object.
        /// </summary>
        SyncLayerResult = 114,
        
        /// <summary>
        /// A <see cref="">TileCache</see> object.
        /// </summary>
        TileCache = 115,
        
        /// <summary>
        /// An <see cref="">TransportationNetworkDataset</see> object.
        /// </summary>
        TransportationNetworkDataset = 116,
        
        /// <summary>
        /// A travel mode.
        /// </summary>
        TravelMode = 117,
        
        /// <summary>
        /// An unsigned 16-bit integer value.
        /// </summary>
        UInt16 = 118,
        
        /// <summary>
        /// An unsigned 32-bit integer value.
        /// </summary>
        UInt32 = 119,
        
        /// <summary>
        /// An unsigned 64-bit integer value.
        /// </summary>
        UInt64 = 120,
        
        /// <summary>
        /// An unsigned 8-bit integer value.
        /// </summary>
        UInt8 = 121,
        
        /// <summary>
        /// A unique value object.
        /// </summary>
        UniqueValue = 122,
        
        /// <summary>
        /// An variant type.
        /// </summary>
        Variant = 123,
        
        /// <summary>
        /// Element holds a vector.
        /// </summary>
        Vector = 124,
        
        /// <summary>
        /// An <see cref="GameEngine.Layers.VectorTile.ArcGISVectorTileSourceInfo">ArcGISVectorTileSourceInfo</see> object. For internal use within C-API only.
        /// </summary>
        VectorTileSourceInfo = 125,
        
        /// <summary>
        /// An <see cref="">GeoprocessingParameterInfo</see> object.
        /// </summary>
        GeoprocessingParameterInfo = 126,
        
        /// <summary>
        /// An <see cref="">GeoprocessingTask</see> object.
        /// </summary>
        GeoprocessingTask = 127,
        
        /// <summary>
        /// An <see cref="">GeoprocessingParameters</see> object.
        /// </summary>
        GeoprocessingParameters = 128,
        
        /// <summary>
        /// An <see cref="">WMTSLayerInfo</see> object.
        /// </summary>
        WMTSLayerInfo = 129,
        
        /// <summary>
        /// An <see cref="">WMTSServiceInfo</see> object.
        /// </summary>
        WMTSServiceInfo = 130,
        
        /// <summary>
        /// An <see cref="">WMTSTileMatrix</see> object.
        /// </summary>
        WMTSTileMatrix = 131,
        
        /// <summary>
        /// An <see cref="">WMTSTileMatrixSet</see> object.
        /// </summary>
        WMTSTileMatrixSet = 132,
        
        /// <summary>
        /// An <see cref="">TileImageFormat</see> enum value.
        /// </summary>
        TileImageFormat = 133,
        
        /// <summary>
        /// An <see cref="">OfflineMapTask</see> object.
        /// </summary>
        OfflineMapTask = 134,
        
        /// <summary>
        /// An <see cref="">ExportVectorTilesTask</see> object.
        /// </summary>
        ExportVectorTilesTask = 135,
        
        /// <summary>
        /// An <see cref="">ExportVectorTilesParameters</see> object.
        /// </summary>
        ExportVectorTilesParameters = 136,
        
        /// <summary>
        /// An <see cref="">ArcGISFeatureTable</see> object.
        /// </summary>
        ArcGISFeatureTable = 137,
        
        /// <summary>
        /// An <see cref="">RelationshipInfo</see> object.
        /// </summary>
        RelationshipInfo = 138,
        
        /// <summary>
        /// An <see cref="">RelatedFeatureQueryResult</see> object.
        /// </summary>
        RelatedFeatureQueryResult = 139,
        
        /// <summary>
        /// An <see cref="">WMTSService</see> object.
        /// </summary>
        WMTSService = 140,
        
        /// <summary>
        /// A <see cref="Standard.ArcGISError">ArcGISError</see> object.
        /// </summary>
        Error = 141,
        
        /// <summary>
        /// A <see cref="">ServiceFeatureTable</see> object.
        /// </summary>
        ServiceFeatureTable = 142,
        
        /// <summary>
        /// A <see cref="">GenerateOfflineMapParameters</see> object.
        /// </summary>
        GenerateOfflineMapParameters = 143,
        
        /// <summary>
        /// An <see cref="">PictureFillSymbol</see> object.
        /// </summary>
        PictureFillSymbol = 145,
        
        /// <summary>
        /// A <see cref="">OfflineCapability</see> object.
        /// </summary>
        OfflineCapability = 146,
        
        /// <summary>
        /// A <see cref="">OfflineCapability</see> object.
        /// </summary>
        OfflineMapCapabilities = 147,
        
        /// <summary>
        /// An <see cref="">RenderingRuleInfo</see> object.
        /// </summary>
        RenderingRuleInfo = 148,
        
        /// <summary>
        /// A <see cref="">LabelDefinition</see> object.
        /// </summary>
        LabelDefinition = 149,
        
        /// <summary>
        /// A <see cref="">RelationshipConstraintViolationType</see> value.
        /// </summary>
        RelationshipConstraintViolation = 150,
        
        /// <summary>
        /// A <see cref="">OfflineMapSyncTask</see> object.
        /// </summary>
        OfflineMapSyncTask = 151,
        
        /// <summary>
        /// An <see cref="">OfflineMapSyncLayerResult</see> object.
        /// </summary>
        OfflineMapSyncLayerResult = 152,
        
        /// <summary>
        /// A <see cref="">PopupRelatedFeaturesSortOrder</see> object.
        /// </summary>
        PopupRelatedFeaturesSortOrder = 153,
        
        /// <summary>
        /// An <see cref="">StatisticDefinition</see> object.
        /// </summary>
        StatisticDefinition = 154,
        
        /// <summary>
        /// An <see cref="">StatisticsQueryResult</see> object.
        /// </summary>
        StatisticsQueryResult = 155,
        
        /// <summary>
        /// An <see cref="">StatisticRecord</see> object.
        /// </summary>
        StatisticRecord = 156,
        
        /// <summary>
        /// A <see cref="">KMLDataset</see> object.
        /// </summary>
        KMLDataset = 157,
        
        /// <summary>
        /// A <see cref="">PreplannedMapArea</see> object.
        /// </summary>
        PreplannedMapArea = 158,
        
        /// <summary>
        /// An <see cref="">WMSService</see> object.
        /// </summary>
        WMSService = 159,
        
        /// <summary>
        /// An <see cref="">WMSServiceInfo</see> object.
        /// </summary>
        WMSServiceInfo = 160,
        
        /// <summary>
        /// An <see cref="">WMSLayerInfo</see> object.
        /// </summary>
        WMSLayerInfo = 161,
        
        /// <summary>
        /// An <see cref="">MapServiceImageFormat</see> enum value.
        /// </summary>
        MapServiceImageFormat = 162,
        
        /// <summary>
        /// An <see cref="GameEngine.Geometry.ArcGISSpatialReference">ArcGISSpatialReference</see> object.
        /// </summary>
        SpatialReference = 163,
        
        /// <summary>
        /// A <see cref="">GeoPackage</see> object.
        /// </summary>
        Geopackage = 164,
        
        /// <summary>
        /// A <see cref="">GeoPackageFeatureTable</see> object.
        /// </summary>
        GeopackageFeatureTable = 165,
        
        /// <summary>
        /// A <see cref="">GeoPackageRaster</see> object.
        /// </summary>
        GeopackageRaster = 166,
        
        /// <summary>
        /// An <see cref="">WMSSublayer</see> object.
        /// </summary>
        WMSSublayer = 167,
        
        /// <summary>
        /// A <see cref="">VectorTileCache</see> object.
        /// </summary>
        VectorTileCache = 168,
        
        /// <summary>
        /// A <see cref="">Analysis</see> object.
        /// </summary>
        Analysis = 169,
        
        /// <summary>
        /// A <see cref="">AnalysisOverlay</see> object.
        /// </summary>
        AnalysisOverlay = 170,
        
        /// <summary>
        /// An <see cref="">ItemResourceCache</see> object.
        /// </summary>
        ItemResourceCache = 171,
        
        /// <summary>
        /// An <see cref="">WMSFeature</see> object.
        /// </summary>
        WMSFeature = 172,
        
        /// <summary>
        /// A <see cref="">NMEASatelliteInfo</see> object.
        /// </summary>
        NMEASatelliteInfo = 173,
        
        /// <summary>
        /// A symbol layer object.
        /// </summary>
        SymbolLayer = 174,
        
        /// <summary>
        /// A vector marker symbol element object.
        /// </summary>
        VectorMarkerSymbolElement = 175,
        
        /// <summary>
        /// A geometric effect object.
        /// </summary>
        GeometricEffect = 176,
        
        /// <summary>
        /// A picture marker symbol layer object.
        /// </summary>
        PictureMarkerSymbolLayer = 177,
        
        /// <summary>
        /// A picture fill symbol layer object.
        /// </summary>
        PictureFillSymbolLayer = 178,
        
        /// <summary>
        /// A feature subtype object.
        /// </summary>
        FeatureSubtype = 179,
        
        /// <summary>
        /// A <see cref="">LabelStackSeparator</see> object.
        /// </summary>
        LabelStackSeparator = 180,
        
        /// <summary>
        /// An <see cref="">WFSService</see> object.
        /// </summary>
        WFSService = 181,
        
        /// <summary>
        /// An <see cref="">WFSLayerInfo</see> object.
        /// </summary>
        WFSLayerInfo = 182,
        
        /// <summary>
        /// A <see cref="">OfflineMapParametersKey</see> object.
        /// </summary>
        OfflineMapParametersKey = 183,
        
        /// <summary>
        /// A <see cref="">GenerateOfflineMapParameterOverrides</see> object.
        /// </summary>
        GenerateOfflineMapParameterOverrides = 184,
        
        /// <summary>
        /// An <see cref="">QueryParameters</see> object.
        /// </summary>
        QueryParameters = 186,
        
        /// <summary>
        /// An <see cref="">StatisticsQueryParameters</see> object.
        /// </summary>
        StatisticsQueryParameters = 187,
        
        /// <summary>
        /// A <see cref="">RouteTracker</see> object.
        /// </summary>
        RouteTracker = 188,
        
        /// <summary>
        /// A <see cref="">WFSFeatureTable</see> object.
        /// </summary>
        WFSFeatureTable = 189,
        
        /// <summary>
        /// A <see cref="">DownloadPreplannedOfflineMapParameters</see> object.
        /// </summary>
        DownloadPreplannedOfflineMapParameters = 190,
        
        /// <summary>
        /// A <see cref="">AnnotationSublayer</see> object.
        /// </summary>
        AnnotationSublayer = 192,
        
        /// <summary>
        /// A <see cref="">OfflineMapSyncParameters</see> object.
        /// </summary>
        OfflineMapSyncParameters = 193,
        
        /// <summary>
        /// A <see cref="">OfflineMapUpdatesInfo</see> object.
        /// </summary>
        OfflineMapUpdatesInfo = 194,
        
        /// <summary>
        /// A <see cref="">DictionarySymbolStyleConfiguration</see> object.
        /// </summary>
        DictionarySymbolStyleConfiguration = 195,
        
        /// <summary>
        /// A <see cref="">Location</see> object.
        /// </summary>
        Location = 197,
        
        /// <summary>
        /// A <see cref="">ImageOverlay</see> object.
        /// </summary>
        ImageFrame = 198,
        
        /// <summary>
        /// A <see cref="">ImageOverlay</see> object.
        /// </summary>
        ImageOverlay = 199,
        
        /// <summary>
        /// A <see cref="">GeodatabaseDeltaInfo</see>.
        /// </summary>
        GeodatabaseDeltaInfo = 200,
        
        /// <summary>
        /// An <see cref="">OGCFeatureService</see> object.
        /// </summary>
        OGCFeatureService = 300,
        
        /// <summary>
        /// An <see cref="">OGCFeatureCollectionInfo</see> object.
        /// </summary>
        OGCFeatureCollectionInfo = 301,
        
        /// <summary>
        /// A <see cref="">OGCFeatureCollectionTable</see> object.
        /// </summary>
        OGCFeatureCollectionTable = 302,
        
        /// <summary>
        /// A <see cref="GameEngine.Geometry.ArcGISDatumTransformation">ArcGISDatumTransformation</see> object.
        /// </summary>
        DatumTransformation = 500,
        
        /// <summary>
        /// A <see cref="GameEngine.Geometry.ArcGISGeographicTransformationStep">ArcGISGeographicTransformationStep</see> object.
        /// </summary>
        GeographicTransformationStep = 501,
        
        /// <summary>
        /// A <see cref="GameEngine.Geometry.ArcGISHorizontalVerticalTransformationStep">ArcGISHorizontalVerticalTransformationStep</see> object.
        /// </summary>
        HorizontalVerticalTransformationStep = 502,
        
        /// <summary>
        /// A <see cref="">ENCCell</see> object.
        /// </summary>
        ENCCell = 1000,
        
        /// <summary>
        /// A <see cref="">ENCDataset</see> object.
        /// </summary>
        ENCDataset = 1001,
        
        /// <summary>
        /// A <see cref="">ENCExchangeSet</see> object.
        /// </summary>
        ENCExchangeSet = 1002,
        
        /// <summary>
        /// A <see cref="">ENCFeature</see> object.
        /// </summary>
        ENCFeature = 1003,
        
        /// <summary>
        /// A <see cref="">MobileScenePackage</see> object.
        /// </summary>
        MobileScenePackage = 1004,
        
        /// <summary>
        /// A popup expression defining an arcade expression on a popup.
        /// </summary>
        PopupExpression = 1005,
        
        /// <summary>
        /// A <see cref="">UtilityNetwork</see> object.
        /// </summary>
        UtilityNetwork = 1006,
        
        /// <summary>
        /// A <see cref="">UtilityAssetType</see> object.
        /// </summary>
        UtilityAssetType = 1007,
        
        /// <summary>
        /// A <see cref="">UtilityAssetGroup</see> object.
        /// </summary>
        UtilityAssetGroup = 1008,
        
        /// <summary>
        /// A <see cref="">UtilityCategory</see> object.
        /// </summary>
        UtilityCategory = 1009,
        
        /// <summary>
        /// A <see cref="">UtilityTerminal</see> object.
        /// </summary>
        UtilityTerminal = 1010,
        
        /// <summary>
        /// A <see cref="">UtilityNetworkAttribute</see> object.
        /// </summary>
        UtilityNetworkAttribute = 1011,
        
        /// <summary>
        /// A <see cref="">UtilityNetworkSource</see> object.
        /// </summary>
        UtilityNetworkSource = 1012,
        
        /// <summary>
        /// A <see cref="">UtilityElement</see> object.
        /// </summary>
        UtilityElement = 1013,
        
        /// <summary>
        /// A <see cref="">UtilityTraceResultType</see> value.
        /// </summary>
        UtilityTraceResultType = 1014,
        
        /// <summary>
        /// A <see cref="">TrackingStatus</see> object.
        /// </summary>
        TrackingStatus = 1015,
        
        /// <summary>
        /// A <see cref="">UtilityTraceResult</see> value.
        /// </summary>
        UtilityTraceResult = 1016,
        
        /// <summary>
        /// A <see cref="">UtilityDomainNetwork</see> object.
        /// </summary>
        UtilityDomainNetwork = 1017,
        
        /// <summary>
        /// A <see cref="">UtilityTerminalConfiguration</see> object.
        /// </summary>
        UtilityTerminalConfiguration = 1018,
        
        /// <summary>
        /// A <see cref="">UtilityTier</see> object.
        /// </summary>
        UtilityTier = 1019,
        
        /// <summary>
        /// A <see cref="">UtilityTierGroup</see> object.
        /// </summary>
        UtilityTierGroup = 1020,
        
        /// <summary>
        /// A <see cref="">UtilityPropagator</see> object.
        /// </summary>
        UtilityPropagator = 1021,
        
        /// <summary>
        /// A <see cref="">SubtypeSublayer</see> object.
        /// </summary>
        SubtypeSublayer = 1022,
        
        /// <summary>
        /// A <see cref="">UtilityAssociation</see> object.
        /// </summary>
        UtilityAssociation = 1023,
        
        /// <summary>
        /// A <see cref="">UtilityTraceFunctionBarrier</see> object.
        /// </summary>
        UtilityTraceFunctionBarrier = 1024,
        
        /// <summary>
        /// A <see cref="">LicenseInfo</see> object.
        /// </summary>
        LicenseInfo = 1025,
        
        /// <summary>
        /// A <see cref="">RasterCell</see> object.
        /// </summary>
        RasterCell = 1026,
        
        /// <summary>
        /// A <see cref="">UtilityTerminalPath</see> object.
        /// </summary>
        UtilityTerminalPath = 1027,
        
        /// <summary>
        /// A <see cref="">UtilityTerminalConfigurationPath</see> object.
        /// </summary>
        UtilityTerminalConfigurationPath = 1028,
        
        /// <summary>
        /// The element is currently not holding any value.
        /// </summary>
        None = -1,
        
        /// <summary>
        /// An object that represents the result of an attempt to evaluate a popup expression.
        /// </summary>
        PopupExpressionEvaluation = 1029,
        
        /// <summary>
        /// A <see cref="">UtilityTraceFunction</see> object.
        /// </summary>
        UtilityTraceFunction = 1030,
        
        /// <summary>
        /// A <see cref="">UtilityFunctionTraceResult</see> object.
        /// </summary>
        UtilityFunctionTraceResult = 1031,
        
        /// <summary>
        /// A <see cref="">UtilityTraceFunctionOutput</see> object.
        /// </summary>
        UtilityTraceFunctionOutput = 1032,
        
        /// <summary>
        /// A <see cref="">ServiceVersionInfo</see> object.
        /// </summary>
        ServiceVersionInfo = 1033,
        
        /// <summary>
        /// A <see cref="">UtilityGeometryTraceResult</see> object.
        /// </summary>
        UtilityGeometryTraceResult = 1034,
        
        /// <summary>
        /// A <see cref="">FeatureTableEditResult</see> object.
        /// </summary>
        FeatureTableEditResult = 1035,
        
        /// <summary>
        /// A <see cref="GameEngine.Security.ArcGISAuthenticationConfiguration">ArcGISAuthenticationConfiguration</see> object.
        /// </summary>
        GEAuthenticationConfiguration = 1036,
        
        /// <summary>
        /// A <see cref="">UtilityNamedTraceConfiguration</see> object.
        /// </summary>
        UtilityNamedTraceConfiguration = 1037,
        
        /// <summary>
        /// A <see cref="">LocalFeatureEdit</see> object.
        /// </summary>
        LocalFeatureEdit = 1039,
        
        /// <summary>
        /// A <see cref="">FloorFacility</see> object.
        /// </summary>
        FloorFacility = 1041,
        
        /// <summary>
        /// A <see cref="">FloorLevel</see> object.
        /// </summary>
        FloorLevel = 1042,
        
        /// <summary>
        /// A <see cref="">FloorSite</see> object.
        /// </summary>
        FloorSite = 1043,
        
        /// <summary>
        /// A <see cref="GameEngine.Attributes.ArcGISVisualizationAttributeDescription">ArcGISVisualizationAttributeDescription</see> object.
        /// </summary>
        VisualizationAttributeDescription = 1044,
        
        /// <summary>
        /// A <see cref="GameEngine.Attributes.ArcGISVisualizationAttribute">ArcGISVisualizationAttribute</see> object.
        /// </summary>
        VisualizationAttribute = 1045,
        
        /// <summary>
        /// A <see cref="GameEngine.Attributes.ArcGISAttribute">ArcGISAttribute</see> object.
        /// </summary>
        Attribute = 1046,
        
        /// <summary>
        /// A <see cref="">LocalFeatureEditsResult</see> object.
        /// </summary>
        LocalFeatureEditsResult = 1047,
        
        /// <summary>
        /// A <see cref="">Geotrigger</see>.
        /// </summary>
        Geotrigger = 1048,
        
        /// <summary>
        /// A <see cref="">DisplayFilter</see> object.
        /// </summary>
        DisplayFilter = 1049,
        
        /// <summary>
        /// A <see cref="">ScaleRangeDisplayFilter</see> object.
        /// </summary>
        ScaleRangeDisplayFilter = 1050,
        
        /// <summary>
        /// A <see cref="">Contingency</see> object.
        /// </summary>
        Contingency = 1052,
        
        /// <summary>
        /// A <see cref="">ContingencyConstraintViolation</see> object.
        /// </summary>
        ContingencyConstraintViolation = 1053,
        
        /// <summary>
        /// A <see cref="">ContingentValue</see> object.
        /// </summary>
        ContingentValue = 1054,
        
        /// <summary>
        /// A <see cref="">FieldGroup</see> object.
        /// </summary>
        FieldGroup = 1055,
        
        /// <summary>
        /// A <see cref="">ArcadeEvaluationResult</see> object.
        /// </summary>
        ArcadeEvaluationResult = 1056,
        
        /// <summary>
        /// A <see cref="">ServiceGeodatabase</see> object.
        /// </summary>
        ServiceGeodatabase = 1058,
        
        /// <summary>
        /// A <see cref="">PopupElement</see> object.
        /// </summary>
        PopupElement = 1060,
        
        /// <summary>
        /// A <see cref="">FieldDescription</see> object.
        /// </summary>
        FieldDescription = 1061,
        
        /// <summary>
        /// A <see cref="">CodedValueDescription</see> object.
        /// </summary>
        CodedValueDescription = 1062,
        
        /// <summary>
        /// A <see cref="">DynamicEntityObservation</see> object.
        /// </summary>
        DynamicEntityObservation = 1063,
        
        /// <summary>
        /// A <see cref="">PopupAttachment</see> object.
        /// </summary>
        PopupAttachment = 1064,
        
        /// <summary>
        /// A <see cref="">LicenseStatus</see> value.
        /// </summary>
        LicenseStatus = 1065,
        
        /// <summary>
        /// A <see cref="">DynamicEntity</see> object.
        /// </summary>
        DynamicEntity = 1076,
        
        /// <summary>
        /// A <see cref="">UtilityRule</see> object.
        /// </summary>
        UtilityRule = 1077,
        
        /// <summary>
        /// A <see cref="">AggregateGeoElement</see> object.
        /// </summary>
        AggregateGeoElement = 1083
    };
}