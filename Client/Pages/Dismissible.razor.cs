﻿using Microsoft.AspNetCore.Components;

namespace SecondBlazorProject.Client.Pages
{
    public partial class Dismissible
    {
        [Parameter]
        public bool Show { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
        public void Dismiss()
        => Show = false;
    }
}


