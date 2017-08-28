using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoubleGisTiles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            HttpMapTileDataSource dataSource = new HttpMapTileDataSource("http://tile2.maps.2gis.ru/tiles?x={x}&y={y}&z={zoomlevel}&v=1");
            MapTileSource tileSource = new MapTileSource(dataSource)
            {
                Layer = MapTileLayer.BackgroundReplacement,
                IsFadingEnabled = false,
            };
            Map.Style = MapStyle.None;
            Map.TileSources.Add(tileSource);
        }
    }
}
