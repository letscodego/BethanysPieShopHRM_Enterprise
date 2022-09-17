using Microsoft.AspNetCore.Components.Rendering;
using System.Runtime.CompilerServices;

namespace BethanysPieShopHRM.UI.Helpers
{
    public static class RenderTreeBuilderExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddAttributeIfNotNullOrEmpty(this RenderTreeBuilder builder, int sequence, string name, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                builder.AddAttribute(sequence, name, value);
            }
        }
    }
}
