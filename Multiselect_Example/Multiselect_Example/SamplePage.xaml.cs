﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Multiselect_Example
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage()
        {
            InitializeComponent();

            this.BindingContext = new SampleViewModel();

            this._lvMulstiselectSample.ItemSelected += (o, e) => { this._lvMulstiselectSample.SelectedItem = null; };

        }
    }
}
