using Microsoft.AspNetCore.Components;
using System;

namespace Blaze.Toast.Configuration
{
    internal class ToastInstance
    {
        public ToastInstance(ToastSettings toastSettings)
        {
            ToastSettings = toastSettings;
        }
        public ToastInstance(RenderFragment BlazeToast, ToastInstanceSettings settings)
        {
            BlazeToast = BlazeToast;
            ToastInstanceSettings = settings;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public ToastSettings ToastSettings { get; set; }
        public ToastInstanceSettings ToastInstanceSettings { get; }
        public RenderFragment BlazeToast { get; }
    }
}
