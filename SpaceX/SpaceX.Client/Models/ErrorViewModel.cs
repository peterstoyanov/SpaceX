using System;

namespace SpaceX.Client.Models
{
    /// <summary>
    /// A class used to display a view with information about an error
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
