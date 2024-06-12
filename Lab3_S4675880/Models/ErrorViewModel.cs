//-----------------------------------------------//  
// This is for showing error-related information
//-----------------------------------------------//   

namespace Lab3_S4675880.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
