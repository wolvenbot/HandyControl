using System.Windows;
using HandyControl.ThemeManager;

namespace HandyControl.Controls
{
    /// <summary>
    /// Default styles for controls.
    /// </summary>
    public class XamlControlsResources : ResourceDictionary
    {
        /// <summary>
        /// Initializes a new instance of the XamlControlsResources class.
        /// </summary>
        public XamlControlsResources()
        {
            MergedDictionaries.Add(ControlsResources);

            if (DesignMode.DesignModeEnabled)
            {
                _ = CompactResources;
            }
        }

        public bool UseCompactResources
        {
            get => _useCompactResources;
            set
            {
                if (_useCompactResources != value)
                {
                    _useCompactResources = value;

                    if (UseCompactResources)
                    {
                        MergedDictionaries.Add(CompactResources);
                    }
                    else
                    {
                        MergedDictionaries.Remove(CompactResources);
                    };
                }
            }
        }

        internal static ResourceDictionary ControlsResources
        {
            get
            {
                if (_controlsResources == null)
                {
                    _controlsResources = new ResourceDictionary { Source = PackUriHelper.GetAbsoluteUri("Themes/Theme.xaml") };
                }
                return _controlsResources;
            }
        }

        internal static ResourceDictionary CompactResources
        {
            get
            {
                if (_compactResources == null)
                {
                    _compactResources = new ResourceDictionary { Source = PackUriHelper.GetAbsoluteUri("DensityStyles/Compact.xaml") };
                }
                return _compactResources;
            }
        }

        private static ResourceDictionary _controlsResources;
        private static ResourceDictionary _compactResources;

        private bool _useCompactResources;
    }
}
