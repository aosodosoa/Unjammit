﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jammit.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jammit.Mobile
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SongPage : ContentPage
  {
    public static readonly BindableProperty SongProperty =
      BindableProperty.Create("Song", typeof(SongInfo), typeof(SongInfo), new SongInfo { Title = "NULL" }, BindingMode.OneWayToSource);
    public SongInfo Song
    {
      get { return GetValue(SongProperty) as SongInfo; }
      set { SetValue(SongProperty, value); }
    }

    public SongPage(SongInfo song)
    {
      BindingContext = this; // Needed to actually bind local properties.
      Song = song;

      InitializeComponent();
    }

    private void SongPage_Close(object sender, EventArgs e)
    {
      Navigation.PopModalAsync();
    }
  }
}
