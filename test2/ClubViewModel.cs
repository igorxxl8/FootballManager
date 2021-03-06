﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace FootballManager
{
    public class ClubViewModel : DependencyObject
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(ClubViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ClubViewModel current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterClub;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(ClubViewModel), new PropertyMetadata(null));

        public ClubViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Base.ReadAllClubs);
            Items.Filter = FilterClub;
        }
        private bool FilterClub(object obj)
        {
            bool result = true;
            Club current = obj as Club;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.Name.Contains(FilterText))
            {
                result = false;
            }
            return result;
        }

    }
}
