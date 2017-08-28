# WinPhone-SDKs-for-tiles

**This is demo project to show how integrate 2GIS Tiles in Universal Windows Apllication**

First, add Bing MapControl to page:
```
<Page xmlns:Maps="using:Windows.UI.Xaml.Controls.Maps" ...>
        <Maps:MapControl HorizontalAlignment="Stretch"
                         VerticalAlignment="Stretch"
                         x:Name="Map">
        </Maps:MapControl>
</Page>
```

Then you must register with Bing Maps and get map key, otherwise you will see red text "No MapServiseToken" over tiles.
[How to register and request key](https://docs.microsoft.com/en-us/windows/uwp/maps-and-location/authentication-key)

Final step: override tile source for map control:
```
            HttpMapTileDataSource dataSource = new HttpMapTileDataSource("http://tile2.maps.2gis.ru/tiles?x={x}&y={y}&z={zoomlevel}&v=1");
            MapTileSource tileSource = new MapTileSource(dataSource)
            {
                Layer = MapTileLayer.BackgroundReplacement,
                IsFadingEnabled = false,
            };
            Map.Style = MapStyle.None;
            Map.TileSources.Add(tileSource);

```
It's all! Build, run and enjoy!
