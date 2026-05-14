using Microsoft.AspNetCore.Components;

namespace Complimentree.Models
{
    public class TreeItemDisplay() : ComponentBase
    {
        [Parameter]
        public Tree TreeItem { get; set; }
    }
}
